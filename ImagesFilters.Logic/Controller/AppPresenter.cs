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

        var count = Enum.GetValues(typeof(FiltersKey)).Length;

        if (Filters.Count != count)
        {
            throw new ArgumentException("Не все фильтры инициализированы или добавлены в 'FiltersKey'");
        }
    }

    public void SetFilters(Bitmap incomingImage, IFilter filter)
    {
        if (incomingImage is null)
        {
            throw new ArgumentNullException(nameof(incomingImage));
        }

        if (filter is null)
        {
            throw new ArgumentNullException(nameof(filter));
        }

        var resultImage = _logic.ConvertTo(incomingImage, filter);
        _appView.SetPictureBoxImage(resultImage);
    }

    public void SetOriginalImage(Bitmap incomingImage)
    {
        SetFilters(incomingImage, Filters[FiltersKey.Original]);
        _appView.CreateFiltersDictionary();// Разделить интерфейсы? 
    }
}