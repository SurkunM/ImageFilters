using ImagesFilters.Logic.Interfaces;
using ImagesFilters.Logic.Model;
using ImagesFilters.Logic.Model.Components;
using ImagesFilters.Logic.Model.Filters;

namespace ImagesFilters.Logic.Controller;

public class AppPresenter
{
    private readonly AppLogic _logic;

    private readonly IAppView _appView;

    public AppPresenter(AppLogic logic, IAppView view)
    {
        _logic = logic;
        _appView = view;
    }

    public void SetOriginalImage(Bitmap incomingImage)
    {
        if (incomingImage is null)
        {
            throw new ArgumentNullException(nameof(incomingImage));
        }

        var resultImage = _logic.ConvertTo(incomingImage, FiltersKey.Original);
        SetViewPictureBoxImage(resultImage);
    }

    public void SetFilterAsync(Bitmap incomingImage, FiltersKey filterKey)
    {
        if (incomingImage is null)
        {
            throw new ArgumentNullException(nameof(incomingImage));
        }

        var asyncConversionView = (IAsyncConversionApp)_appView;
        Bitmap? resultImage = null;

        var thread = new Thread(() =>
        {
            resultImage = _logic.ConvertTo(incomingImage, filterKey);
        });

        asyncConversionView.IsFormEnabled(false);
        asyncConversionView.SetVisibleProgressPanel(true);
        thread.Start();

        thread.Join();
        asyncConversionView.IsFormEnabled(true);
        asyncConversionView.SetVisibleProgressPanel(false);

        if (resultImage is not null)
        {
            SetViewPictureBoxImage(resultImage);
        }
    }

    private void SetViewPictureBoxImage(Bitmap image)
    {
        _appView.SetPictureBoxImage(image);
    }
}