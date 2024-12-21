using ImagesFilters.Logic.Model.Components;

namespace ImagesFilters.Logic.Model.Filters;

internal class Blur : IFilter
{   
    private readonly double[,] _convolutionMatrix;

    public Blur(double[,] convolutionMatrix)
    {
        if (convolutionMatrix is null) 
        { 
            throw new ArgumentNullException(nameof(convolutionMatrix));
        }

        if (convolutionMatrix.Length == 0)
        {
            throw new ArgumentException($"Матрица {convolutionMatrix} не может быть размера {convolutionMatrix.Length} ");
        }

        _convolutionMatrix = convolutionMatrix;
    }

    public Bitmap Convert(Bitmap originalImage)
    {
        var resultImage = new Bitmap(originalImage);

        var halfMatrixSize = _convolutionMatrix.GetLength(0) / 2;
        var yUpperLimit = originalImage.Height - halfMatrixSize;
        var xUpperLimit = originalImage.Width - halfMatrixSize;

        for (int y = halfMatrixSize; y < yUpperLimit; y++)
        {
            for (int x = halfMatrixSize; x < xUpperLimit; x++)
            {
                var redColor = 0.0;
                var greenColor = 0.0;
                var blueColor = 0.0;

                for (int i = 0, yNeighboringPixel = y - halfMatrixSize; i < _convolutionMatrix.GetLength(0); i++, yNeighboringPixel++)
                {
                    for (int j = 0, xNeighboringPixel = x - halfMatrixSize; j < _convolutionMatrix.GetLength(0); j++, xNeighboringPixel++)
                    {
                        Color pixel = originalImage.GetPixel(xNeighboringPixel, yNeighboringPixel);

                        redColor += pixel.R * _convolutionMatrix[i, j];
                        greenColor += pixel.G * _convolutionMatrix[i, j];
                        blueColor += pixel.B * _convolutionMatrix[i, j];
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