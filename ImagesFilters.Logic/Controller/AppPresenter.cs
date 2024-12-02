using ImagesFilters.Logic.Interfaces;
using ImagesFilters.Logic.Model;
using ImagesFilters.Logic.Model.Components;

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

    public void SetFilters(Bitmap originalImage)
    {        
        foreach (var key in Enum.GetValues<FiltersKey>())
        {            
            SetFilter(originalImage, key);
        }
    }

    private void SetFilter(Bitmap originalImage, FiltersKey key)
    {
        _appView.SetInDictionaryFilter(_logic.ConvertTo(originalImage, key), key);        
    }
}