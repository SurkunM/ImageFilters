using ImagesFilters.Logic.Controller;
using ImagesFilters.Logic.Interfaces;
using ImagesFilters.Logic.Model.Components;
using ImagesFilters.Logic.Model.Filters;

namespace ImagesFilters;

public partial class AppForm : Form, IAppView
{
    private string _fileName = "";

    public Dictionary<FiltersKey, IFilter> Filters { get; set; } = default!;

    private Dictionary<FiltersKey, bool> _isFilterUsed = default!;

    private Bitmap _originalImage = default!;

    private Bitmap _currentImage = default!;

    public AppPresenter Presenter { get; set; } = default!;

    public AppForm()
    {
        InitializeComponent();
    }

    private void ToolStripMenuOpenFile_Click(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

        if (openFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            if (Presenter is null)
            {
                throw new ArgumentNullException(nameof(Presenter));
            }

            Filters = Presenter.Filters;
            CreateFiltersDictionary();

            _fileName = openFileDialog.FileName;

            _originalImage = new Bitmap(_fileName);
            _currentImage = _originalImage;

            pictureBoxOriginalImage.Image = _originalImage;
            pictureBoxResultImage.Image = _currentImage;

            StripMenuButtonsEnable(true);
            toolStripButtons.Visible = true;
        }
        catch (ArgumentNullException)
        {
            throw;
        }
        catch (ArgumentException)
        {
            _fileName = "";
            MessageBox.Show("Не удалось открыть файл", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void SetPictureBoxImage(Bitmap image)
    {
        if (image is null)
        {
            throw new ArgumentNullException(nameof(image));
        }

        _currentImage = image;
        pictureBoxResultImage.Image = _currentImage;
    }

    public void CreateFiltersDictionary()
    {
        _isFilterUsed = new Dictionary<FiltersKey, bool>();

        foreach (FiltersKey key in Filters.Keys)
        {
            _isFilterUsed[key] = false;
        }
    }

    private void StripMenuButtonsEnable(bool isEnable)
    {
        toolStripButtons.Enabled = isEnable;

        toolStripMenuAqua.Enabled = isEnable;
        toolStripMenuBlur.Enabled = isEnable;
        toolStripMenuBlackAndWhite.Enabled = isEnable;

        toolStripMenuDeleteImage.Enabled = isEnable;
        toolStripMenuCancel.Enabled = isEnable;
    }

    private void ClearPictureBoxes()
    {
        pictureBoxResultImage.Image = null;

        pictureBoxOriginalImage.Image = null;

        toolStripMenuDeleteImage.Enabled = false;
        toolStripButtons.Enabled = false;
    }

    private void FormEnable(bool isEnable)
    {
        if (!isEnable)
        {
            this.Cursor = Cursors.WaitCursor;
        }
        else
        {
            this.Cursor = Cursors.Default;
        }

        menuStrip.Enabled = isEnable;//TODO: Заменить диалоговым окном!
        panelApp.Enabled = isEnable;
    }

    private void ButtonClick_SetToolBar(object sender, EventArgs e)
    {
        if (toolStripButtons.Visible)
        {
            toolStripButtons.Visible = false;
        }
        else
        {
            toolStripButtons.Visible = true;
        }
    }

    private void ButtonClick_DeleteImage(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Удалить изображение?", "Подтверждение", MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {
            ClearPictureBoxes();
            StripMenuButtonsEnable(false);
        }
    }

    private void ButtonClick_Cancel(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Сбросить изменения?", "Подтверждение", MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {
            Presenter.SetOriginalImage(_originalImage);
        }
    }

    private void ButtonClick_Blur(object sender, EventArgs e)
    {
        FormEnable(false);

        Presenter.SetFilters(_currentImage, Filters[FiltersKey.Blur]);
        _isFilterUsed[FiltersKey.Blur] = true;

        FormEnable(true);
    }

    private void ButtonClick_BlackWhite(object sender, EventArgs e)
    {
        if (_isFilterUsed[FiltersKey.BlackAndWhite])
        {
            return;
        }

        FormEnable(false);

        Presenter.SetFilters(_currentImage, Filters[FiltersKey.BlackAndWhite]);
        _isFilterUsed[FiltersKey.BlackAndWhite] = true;

        FormEnable(true);
    }

    private void ButtonClick_Aqua(object sender, EventArgs e)
    {
        if (_isFilterUsed[FiltersKey.Aqua])
        {
            return;
        }

        FormEnable(false);

        Presenter.SetFilters(_currentImage, Filters[FiltersKey.Aqua]);
        _isFilterUsed[FiltersKey.Aqua] = true;

        FormEnable(true);
    }

    private void ButtonClick_Embossing(object sender, EventArgs e)
    {
        if (_isFilterUsed[FiltersKey.Embossing])
        {
            return;
        }

        FormEnable(false);

        Presenter.SetFilters(_currentImage, Filters[FiltersKey.Embossing]);
        _isFilterUsed[FiltersKey.Embossing] = true;

        FormEnable(true);
    }

    private void ButtonClick_Sharpen(object sender, EventArgs e)
    {
        FormEnable(false);

        Presenter.SetFilters(_currentImage, Filters[FiltersKey.Sharpen]);
        _isFilterUsed[FiltersKey.Sharpen] = true;

        FormEnable(true);
    }

    private void ButtonClick_Noise(object sender, EventArgs e)
    {
        FormEnable(false);

        Presenter.SetFilters(_currentImage, Filters[FiltersKey.Noise]);
        _isFilterUsed[FiltersKey.Noise] = true;

        FormEnable(true);
    }

    private void ButtonClick_Exit(object sender, EventArgs e)
    {
        Application.Exit();
    }
}