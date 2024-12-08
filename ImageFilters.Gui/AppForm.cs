using ImagesFilters.Logic.Controller;
using ImagesFilters.Logic.Interfaces;
using ImagesFilters.Logic.Model.Components;

namespace ImagesFilters;

public partial class AppForm : Form, IAppView
{
    private string _fileName = "";

    private readonly Dictionary<FiltersKey, Bitmap> _imagesDictionary = new Dictionary<FiltersKey, Bitmap>();

    private Bitmap _currentImage = default!;

    private uint[,] _currentImagePixels = default!;

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
            if (_imagesDictionary.Count != 0)
            {
                ClearPictureBoxes();
            }

            _fileName = openFileDialog.FileName;
            _imagesDictionary.Add(FiltersKey.Original, new Bitmap(_fileName));

            _currentImage = new Bitmap(openFileDialog.FileName);


            pictureBoxOriginalImage.Image = _currentImage; //_imagesDictionary[FiltersKey.Original];
            pictureBoxResultImage.Image = _currentImage;//_imagesDictionary[FiltersKey.Original];

           //  Presenter.SetFilters(_imagesDictionary[FiltersKey.Original]);

            toolStripMenuClear.Enabled = true;
            Enabled = false;

            _currentImagePixels = new uint[_currentImage.Height, _currentImage.Width];
            //for(int y = 0; y < _currentImage.Height; y++) "это попытка ускорения"
            //{
            //    for(int x = 0;  x < _currentImage.Width; x++)
            //    {
            //        _currentImagePixels[y, x] = (uint)_currentImage.GetPixel(x, y).ToArgb();
            //    }
            //}

            Enabled = true;
            toolStripButtons.Enabled = true;
        }
        catch
        {
            _fileName = "";
            MessageBox.Show("Не удалось открыть файл", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ButtonBlur_Click(object sender, EventArgs e)
    {
        Presenter.SetFilters(_currentImage, FiltersKey.Blur);
       Presenter.SetPictureBoxImage(FiltersKey.Blur);        
    }

    private void ButtonBlackWhite_Click(object sender, EventArgs e)
    {

    }
    private void toolStripAquaButton_Click(object sender, EventArgs e)
    {

    }

    public void SetInDictionaryFilter(Bitmap image, FiltersKey filtersKey)
    {
        _imagesDictionary[filtersKey] = image;
    }

    private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    public void SetImagePictureBox(FiltersKey filtersKey)
    {
        if (_currentImage == _imagesDictionary[filtersKey])
        {
            return;
        }

        _currentImage = _imagesDictionary[filtersKey];
        pictureBoxResultImage.Image = _currentImage;
    }

    private void ToolStripMenuIClear_Click(object sender, EventArgs e)
    {
        ClearPictureBoxes();
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

        _imagesDictionary.Clear();

        toolStripMenuClear.Enabled = false;
        toolStripButtons.Enabled = false;
    }
}