using ImagesFilters.Logic.Interfaces;
using ImagesFilters.Logic.Model;
using ImagesFilters.Logic.Model.Components;
using ImagesFilters.Logic.Model.Filters;

namespace ImagesFilters.Logic.Controller;

public class AppPresenter
{
    private readonly AppLogic _logic;

    private readonly IAppView _appView;

    public Dictionary<FiltersKey, IFilter> Filters { get; set; }

    public AppPresenter(AppLogic logic, IAppView view)
    {
        _logic = logic;
        _appView = view;

        Filters = _logic.Filters;
    }

    public void SetFilters(Bitmap image, IFilter filter)
    {
        var imageBlur = _logic.ConvertTo(image, filter);
        _appView.SetPictureBoxImage(imageBlur);
    }
}