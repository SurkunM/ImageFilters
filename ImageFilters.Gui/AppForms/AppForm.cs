using ImagesFilters.Logic.Controller;
using ImagesFilters.Logic.Interfaces;
using ImagesFilters.Logic.Model.Components;
using System.Drawing.Imaging;

namespace ImagesFilters;

public partial class AppForm : Form, IAppView, IAsyncConversionAppView
{
    private string _fileName = "";

    private Bitmap _originalImage = default!;

    private Bitmap _currentImage = default!;

    public AppPresenter Presenter { get; set; } = default!;

    public AppForm()
    {
        InitializeComponent();
    }

    private void ToolStripMenuClick_OpenFile(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

        if (openFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        if (Presenter is null)
        {
            throw new NullReferenceException(nameof(Presenter));
        }

        _fileName = openFileDialog.FileName;

        try
        {
            _originalImage = new Bitmap(_fileName);
            _currentImage = _originalImage;

            pictureBoxOriginalImage.Image = _originalImage;
            pictureBoxResultImage.Image = _currentImage;

            SetStripMenuButtonsEnable(true);
            toolStripButtons.Visible = true;
        }
        catch (Exception)
        {
            _fileName = "";
            MessageBox.Show("Не удалось открыть файл", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ToolStripMenuClick_SaveFile(object sender, EventArgs e)
    {
        var saveImageDialog = new SaveFileDialog();

        saveImageDialog.Title = "Сохранить картинку как...";
        saveImageDialog.OverwritePrompt = true;
        saveImageDialog.CheckPathExists = true;
        saveImageDialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";

        if (saveImageDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                _currentImage.Save(saveImageDialog.FileName, ImageFormat.Jpeg);
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        toolStripMenuSave.Enabled = true;
    }

    private void SetStripMenuButtonsEnable(bool isEnable)
    {
        toolStripButtons.Enabled = isEnable;
        toolStripMenuDeleteImage.Enabled = isEnable;
        toolStripMenuCancel.Enabled = isEnable;
    }

    public void SetVisibleProgressPanel(bool isVisible)
    {
        conversionProgressPanel.Visible = isVisible;
    }

    public void IsFormEnabled(bool isDisable)
    {
        if (isDisable)
        {
            panelApp.Cursor = Cursors.WaitCursor;

            menuStrip.Enabled = false;
            panelApp.Enabled = false;
        }
        else
        {
            panelApp.Cursor = Cursors.Default;

            menuStrip.Enabled = true;
            panelApp.Enabled = true;
        }
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
            pictureBoxResultImage.Image = null;
            pictureBoxOriginalImage.Image = null;

            toolStripMenuDeleteImage.Enabled = false;
            toolStripButtons.Enabled = false;
            toolStripMenuSave.Enabled = false;

            SetStripMenuButtonsEnable(false);
        }
    }

    private void ButtonClick_Cancel(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Сбросить изменения?", "Подтверждение", MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {
            Presenter.FilterKey = FiltersKey.Original;
            Presenter.SetOriginalImageFilter(_originalImage);
        }
    }

    private void ButtonClick_Blur(object sender, EventArgs e)
    {
        Presenter.FilterKey = FiltersKey.Blur;
        Presenter.SetFilter(_currentImage);
    }

    private void ButtonClick_BlackWhite(object sender, EventArgs e)
    {
        Presenter.FilterKey = FiltersKey.BlackAndWhite;
        Presenter.SetFilter(_currentImage);

    }

    private void ButtonClick_Aqua(object sender, EventArgs e)
    {
        Presenter.FilterKey = FiltersKey.Aqua;
        Presenter.SetFilter(_currentImage);
    }

    private void ButtonClick_Embossing(object sender, EventArgs e)
    {
        Presenter.FilterKey = FiltersKey.Embossing;
        Presenter.SetFilter(_currentImage);
    }

    private void ButtonClick_Sharpen(object sender, EventArgs e)
    {
        Presenter.FilterKey = FiltersKey.Sharpen;
        Presenter.SetFilter(_currentImage);
    }

    private void ButtonClick_Exit(object sender, EventArgs e)
    {
        Application.Exit();
    }
}