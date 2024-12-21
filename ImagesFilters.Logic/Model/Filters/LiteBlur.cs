using ImagesFilters.Logic.Model.Components;

namespace ImagesFilters.Logic.Model.Filters;

internal class LiteBlur
{
    public uint[,] ConvertPixels(double[,] matrix, uint[,] pixels) //TODO: возможно через перевод пикселей в массив уинтов!
    {
        var resultPixels = new uint[pixels.GetLength(0), pixels.GetLength(1)];

        var halfMatrixSize = matrix.GetLength(0) / 2;
        var yUpperLimit = pixels.GetLength(1) - halfMatrixSize;
        var xUpperLimit = pixels.GetLength(0) - halfMatrixSize;

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
                        Color pixel = Color.FromArgb((int)pixels[xNeighboringPixel, yNeighboringPixel]);

                        redColor += pixel.R * matrix[i, j];
                        greenColor += pixel.G * matrix[i, j];
                        blueColor += pixel.B * matrix[i, j];
                    }
                }

                Color resultPixel = Color.FromArgb(ConvolutionMatrixComponents.GetSaturatedColor(redColor),
                                                   ConvolutionMatrixComponents.GetSaturatedColor(greenColor),
                                                   ConvolutionMatrixComponents.GetSaturatedColor(blueColor));

                //  resultPixels[x, y] = resultPixel.ToArgb();
            }
        }

        return resultPixels;
    }
}
