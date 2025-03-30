namespace ImagesFilters.Logic.Interfaces;

public interface IAsyncAppLogic : IAppLogic
{
    Task<Bitmap> ConvertToAsync(Bitmap incomingImage);
}