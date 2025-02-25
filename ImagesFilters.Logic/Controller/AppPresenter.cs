using ImagesFilters.Logic.Interfaces;
using ImagesFilters.Logic.Model;
using ImagesFilters.Logic.Model.Components;

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

    public void SetOriginalImageFilter(Bitmap incomingImage)
    {
        if (incomingImage is null)
        {
            throw new ArgumentNullException(nameof(incomingImage));
        }

        var resultImage = _logic.ConvertTo(incomingImage, FiltersKey.Original);
        SetViewPictureBoxImage(resultImage);
    }

    public void SetFilter(Bitmap incomingImage, FiltersKey filterKey)
    {
        if (incomingImage is null)
        {
            throw new ArgumentNullException(nameof(incomingImage));
        }

        if (_appView is null)
        {
            throw new ArgumentNullException(nameof(_appView));
        }

        Bitmap? resultImage = null;

        if (_appView is IAsyncConversionAppView asyncConversionView)
        {
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
        }
        else
        {
            resultImage = _logic.ConvertTo(incomingImage, filterKey);
        }

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