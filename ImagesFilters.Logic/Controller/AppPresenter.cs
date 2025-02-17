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

        var filtersKeysCount = Enum.GetValues(typeof(FiltersKey)).Length;

        if (Filters.Count != filtersKeysCount)
        {
            throw new ArgumentException("Не все фильтры инициализированы или добавлены в 'FiltersKey'");
        }
    }

    public void SetOriginalImage(Bitmap incomingImage)
    {
        if (incomingImage is null)
        {
            throw new ArgumentNullException(nameof(incomingImage));
        }

        SetFilterAsync(incomingImage, FiltersKey.Original);
    }

    public void SetFilterAsync(Bitmap incomingImage, FiltersKey filterKey)
    {
        if (incomingImage is null)
        {
            throw new ArgumentNullException(nameof(incomingImage));
        }

        if (Filters[filterKey] is null)
        {
            throw new ArgumentNullException($"({filterKey}) фильтра с таким ключом не существует");
        }

        var asyncConversionView = (IAsyncConversionApp)_appView;
        Bitmap? resultImage = null;        

        var thread = new Thread(() =>
        {
            resultImage = _logic.ConvertTo(incomingImage, Filters[filterKey]);
        });

        asyncConversionView.IsFormEnabled(false);
        asyncConversionView.SetVisibleProgressPanel(true);
        thread.Start();

        thread.Join();
        asyncConversionView.IsFormEnabled(true);
        asyncConversionView.SetVisibleProgressPanel(false);

        if (resultImage is not null)
        {
            _appView.SetPictureBoxImage(resultImage);
        }
    }
}