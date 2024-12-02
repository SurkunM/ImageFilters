using ImagesFilters.Logic.Model.Components;

namespace ImagesFilters.Logic.Model.Filters;

internal class Blur : IFilter
{
    public string Name { get; } = "Blur";

    public static Bitmap Convert(double[,] matrix, Bitmap originalImage)
    {        
        var resultImage = new Bitmap(originalImage);

        var halfMatrixSize = matrix.GetLength(0) / 2;
        var yUpperLimit = originalImage.Height - halfMatrixSize;
        var xUpperLimit = originalImage.Width - halfMatrixSize;

        for (int y = halfMatrixSize; y < yUpperLimit; y++)
        {
            for (int x = halfMatrixSize; x < xUpperLimit; x++)
            {
                var redColor = 0.0;
                var greenColor = 0.0;
                var blueColor = 0.0;

                for (int i = 0, yNeighboringPixel = y - halfMatrixSize; i < matrix.GetLength(0); i++, yNeighboringPixel++)
                {
                    for (int j = 0, xNeighboringPixel = x - halfMatrixSize; j < matrix.GetLength(0); j++, xNeighboringPixel++)
                    {
                        Color pixel = originalImage.GetPixel(xNeighboringPixel, yNeighboringPixel);

                        redColor += pixel.R * matrix[i, j];
                        greenColor += pixel.G * matrix[i, j];
                        blueColor += pixel.B * matrix[i, j];
                    }
                }

                Color resultPixel = Color.FromArgb(ConvolutionMatrixComponents.GetSaturatedColor(redColor),
                                                   ConvolutionMatrixComponents.GetSaturatedColor(greenColor),
                                                   ConvolutionMatrixComponents.GetSaturatedColor(blueColor));

                resultImage.SetPixel(x, y, resultPixel);
            }
        }

        return resultImage;
    }
}
