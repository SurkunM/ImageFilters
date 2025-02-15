using ImagesFilters.Logic.Model.Components;
using ImagesFilters.Logic.Model.Filters;

namespace ImagesFilters.Logic.Model;

public class AppLogic
{
    public Dictionary<FiltersKey, IFilter> Filters { get; }

    public AppLogic()
    {
        Filters = new Dictionary<FiltersKey, IFilter>
        {
            {FiltersKey.Original, new Original()},
            {FiltersKey.Blur, new Blur(3)},
            {FiltersKey.BlackAndWhite, new BlackAndWhite()},
            {FiltersKey.Aqua, new Aqua()},
            {FiltersKey.Embossing, new Embossing()},
            {FiltersKey.Sharpen, new Sharpen()},
            {FiltersKey.Noise, new Noise()}
        };
    }

    public Bitmap ConvertTo(Bitmap incomingImage, IFilter filter)
    {
        return filter.Convert(incomingImage);
    }
}