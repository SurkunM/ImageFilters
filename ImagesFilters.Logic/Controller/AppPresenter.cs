using ImagesFilters.Logic.Interfaces;
using ImagesFilters.Logic.Model;
using ImagesFilters.Logic.Model.Components;
using System.Windows.Forms;

namespace ImagesFilters.Logic.Controller;

public class AppPresenter
{
    private AppLogic _logic;

    private IAppView _appView;

    public AppPresenter(AppLogic logic, IAppView view)
    {
        _logic = logic;
        _appView = view;
    }

    public void SetPictureBoxImage(FiltersKey key)
    {
        _appView.SetImagePictureBox(key);
    }

    public void SetFilters(Bitmap originalImage, FiltersKey key)
    {
        _appView.SetInDictionaryFilter(_logic.ConvertTo(originalImage, key), key);
    }
}