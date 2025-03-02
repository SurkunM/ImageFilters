namespace ImagesFilters.Logic.Interfaces;

internal interface IAsyncConversionAppLogic
{
    Task<Bitmap> ConvertToAsync(Bitmap incomingImage);
}