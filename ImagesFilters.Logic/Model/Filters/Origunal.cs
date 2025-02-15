namespace ImagesFilters.Logic.Model.Filters;

internal class Original : IFilter
{
    public Bitmap Convert(Bitmap incomingImage)
    {
        return incomingImage;
    }
}