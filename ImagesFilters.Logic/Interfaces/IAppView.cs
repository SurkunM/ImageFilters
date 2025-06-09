namespace ImagesFilters.Logic.Interfaces;

public interface IAppView
{
    void SetPictureBoxImage(Bitmap image);

    void IsFormEnabled(bool isEnable);

    void SetVisibleProgressPanel(bool isVisible);
}