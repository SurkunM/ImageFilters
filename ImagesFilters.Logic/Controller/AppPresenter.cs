using ImagesFilters.Logic.Interfaces;
using ImagesFilters.Logic.Model.Components;

namespace ImagesFilters.Logic.Controller;

public class AppPresenter
{
    private readonly IAsyncAppLogic _logic;

    private readonly IAsyncAppView _appView;

    public FiltersKey FilterKey { private get; set; } = default!;

    public AppPresenter(IAsyncAppLogic logic, IAsyncAppView view)
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

        _logic.UsedFilterKey = FilterKey;

        var resultImage = _logic.ConvertTo(incomingImage);
        SetViewPictureBoxImage(resultImage);
    }

    public async void SetFilter(Bitmap incomingImage)
    {
        if (incomingImage is null)
        {
            throw new ArgumentNullException(nameof(incomingImage));
        }

        if (_appView is null)
        {
            throw new NullReferenceException(nameof(_appView));
        }

        _logic.UsedFilterKey = FilterKey;
        SetProgressLoad(true);

        Bitmap resultImage = await _logic.ConvertToAsync(incomingImage);

        SetProgressLoad(false);
        SetViewPictureBoxImage(resultImage);
    }

    private void SetViewPictureBoxImage(Bitmap image)
    {
        _appView.SetPictureBoxImage(image);
    }

    private void SetProgressLoad(bool isLoad)
    {
        _appView.SetVisibleProgressPanel(isLoad);
        _appView.IsFormEnabled(isLoad);
    }
}