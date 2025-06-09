using ImagesFilters.Logic.Interfaces;
using ImagesFilters.Logic.Model.Components;

namespace ImagesFilters.Logic.Controller;

public class AppPresenter
{
    private readonly IAppLogic _logic;

    private readonly IAppView _appView;

    public FiltersKey FilterKey { private get; set; } = default!;

    public AppPresenter(IAppLogic logic, IAppView view)
    {
        _logic = logic;
        _appView = view;
    }

    public void SetOriginalImage(Bitmap incomingImage)
    {
        ArgumentNullException.ThrowIfNull(incomingImage);

        _logic.UsedFilterKey = FilterKey;

        var resultImage = _logic.ConvertTo(incomingImage);
        SetViewPictureBoxImage(resultImage);
    }

    public void SetFilter(Bitmap incomingImage)
    {
        ArgumentNullException.ThrowIfNull(incomingImage);

        if (_appView is null)
        {
            throw new NullReferenceException(nameof(_appView));
        }

        _logic.UsedFilterKey = FilterKey;
        SetProgressLoad(true);

        var resultImage = _logic.ConvertTo(incomingImage);

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