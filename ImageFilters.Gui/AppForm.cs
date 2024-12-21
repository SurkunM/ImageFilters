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
        using var openFileDialog = new OpenFileDialog();
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
            CreateFilterDictionary();

            _fileName = openFileDialog.FileName;

            _originalImage = new Bitmap(_fileName);
            _currentImage = _originalImage;

            pictureBoxOriginalImage.Image = _originalImage;
            pictureBoxResultImage.Image = _currentImage;

            StripMenuButtonsEnable(true);
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

    private void ButtonBlur_Click(object sender, EventArgs e)
    {
        if (_isFilterUsed[FiltersKey.Blur])
        {
            return;
        }

        FormEnable(false);

        Presenter.SetFilters(_currentImage, Filters[FiltersKey.Blur]);
        _isFilterUsed[FiltersKey.Blur] = true;

        FormEnable(true);
    }

    private void ButtonBlackWhite_Click(object sender, EventArgs e)
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

    private void ButtonAqua_Click(object sender, EventArgs e)
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

    private void ToolStripMenuIClear_Click(object sender, EventArgs e)
    {
        ClearPictureBoxes();
        StripMenuButtonsEnable(false);
    }

    private void ToolStripMenuCancel_Click(object sender, EventArgs e)
    {
        _currentImage = _originalImage;
        pictureBoxResultImage.Image = _currentImage;
        CreateFilterDictionary();
    }

    private void ToolStripMenuIExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    public void SetPictureBoxImage(Bitmap image)
    {
        if(image is null)
        {
            throw new ArgumentNullException();
        }

        _currentImage = image;
        pictureBoxResultImage.Image = _currentImage;
    }

    private void FormEnable(bool isEnable)
    {
        menuStrip.Enabled = isEnable;//TODO: Заменить диалоговым окном!
        panelApp.Enabled = isEnable;        
    }

    private void StripMenuButtonsEnable(bool isEnable)
    {
        toolStripButtons.Enabled = isEnable;

        toolStripMenuAqua.Enabled = isEnable;
        toolStripMenuBlur.Enabled = isEnable;
        toolStripMenuBlackAndWhite.Enabled = isEnable;

        toolStripMenuClear.Enabled = isEnable;
        toolStripMenuCancel.Enabled = isEnable;
    }

    private void CreateFilterDictionary()
    {
        _isFilterUsed = new Dictionary<FiltersKey, bool>();

        foreach(FiltersKey key in Filters.Keys)
        {
            _isFilterUsed[key] = false;
        }
    }

    private void ToolStripMenuToolBar_Click(object sender, EventArgs e)
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

    private void ClearPictureBoxes()
    {
        pictureBoxResultImage.Image.Dispose();
        pictureBoxResultImage.Image = null;

        pictureBoxOriginalImage.Image.Dispose();
        pictureBoxOriginalImage.Image = null;

        toolStripMenuClear.Enabled = false;
        toolStripButtons.Enabled = false;
    }

    private void ConvertBitmapToUintMatrix(Bitmap bitmap)
    {
        // _currentImagePixels = new uint[_currentImage.Height, _currentImage.Width];
        //for(int y = 0; y < _currentImage.Height; y++) "это попытка ускорения"
        //{
        //    for(int x = 0;  x < _currentImage.Width; x++)
        //    {
        //        _currentImagePixels[y, x] = (uint)_currentImage.GetPixel(x, y).ToArgb();
        //    }
        //}
    }
}