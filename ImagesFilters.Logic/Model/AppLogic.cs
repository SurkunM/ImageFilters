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
            {FiltersKey.Blur, new Blur(ConvolutionMatrixComponents.GetMatrix(5))},
            {FiltersKey.BlackAndWhite, new BlackAndWhite()},
            {FiltersKey.Aqua, new Aqua()}
        };
    }

    public Bitmap ConvertTo(Bitmap originalImage, IFilter filter)
    {
        return filter.Convert(originalImage);
    }
}