using ImagesFilters.Logic.Model.Components;
using ImagesFilters.Logic.Model.Filters;

namespace ImagesFilters.Logic.Model;

public class AppLogic
{
    public Bitmap ConvertTo(Bitmap originalImage, FiltersKey key)
    {
        var matrix = ConvolutionMatrixComponents.GetBlurMatrix(5);
        if (key == FiltersKey.Blur)
        {
            return Blur.Convert(matrix, originalImage);
        }

        return BlackAndWhite.Convert(originalImage);
    }
}
