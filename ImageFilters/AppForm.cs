using ImagesFilters.Logic.Controller;
using ImagesFilters.Logic.Interfaces;
using ImagesFilters.Logic.Model.Components;

namespace ImagesFilters;

public partial class AppForm : Form, IAppView
{
    private string _fileName = "";

    private Dictionary<FiltersKey, Bitmap> _imagesDictionary = new Dictionary<FiltersKey, Bitmap>();

    private Bitmap _testImage = default!;

    public AppPresenter Presenter { get; set; } = default!;

    public AppForm()
    {
        InitializeComponent();        
    }

    private void ButtonBlur_Click(object sender, EventArgs e)
    {
        Presenter.SetPictureBoxImage(FiltersKey.Blur);
    }

    private void ButtonBlackWhite_Click(object sender, EventArgs e)
    {
        Presenter.SetPictureBoxImage(FiltersKey.BlackAndWhite);
    }

    private void ToolStripMenuOpenFile_Click(object sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

        if (openFileDialog.ShowDialog() != DialogResult.OK)
        {
            return;
        }

        try
        {
            if(_imagesDictionary.Count != 0)
            {
                ClearPictureBoxes();
            }

            _fileName = openFileDialog.FileName;
             
            _imagesDictionary.Add(FiltersKey.Original, new Bitmap(_fileName));            
        }
        catch
        {
            _fileName = "";
            DialogResult result = MessageBox.Show("Не удалось открыть файл", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        toolStripMenuClear.Enabled = true;       

        //this.Enabled = false;

        pictureBoxOriginalImage.Image = _imagesDictionary[FiltersKey.Original];
        pictureBoxResultImage.Image = _imagesDictionary[FiltersKey.Original];
        // Presenter.SetFilters((Bitmap)_imagesDictionary[FiltersKey.Original]);

        // Enabled = true;
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
        pictureBoxResultImage.Image = _imagesDictionary[filtersKey];
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
    }
}