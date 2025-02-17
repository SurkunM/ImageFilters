using ImagesFilters.Logic.Model.Components;

namespace ImagesFilters.Logic.Model.Filters;

internal class Blur : IFilter
{
    private readonly double[,] _convolutionMatrix;

    public Blur(int convolutionMatrixSize)
    {
        if (convolutionMatrixSize <= 1 || convolutionMatrixSize % 2 == 0 || convolutionMatrixSize > 9)
        {
            throw new ArgumentException("Размер матрицы не может быть меньше или равной 1 или быть четным числом.");
        }

        _convolutionMatrix = MatrixComponents.GetMatrix(convolutionMatrixSize);
    }

    public Bitmap Convert(Bitmap incomingImage)
    {
        var resultImage = new Bitmap(incomingImage);

        var halfMatrixSize = _convolutionMatrix.GetLength(0) / 2;
        var yUpperLimit = incomingImage.Height - halfMatrixSize;
        var xUpperLimit = incomingImage.Width - halfMatrixSize;

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
                        Color pixel = incomingImage.GetPixel(xNeighboringPixel, yNeighboringPixel);

                        redColor += pixel.R * _convolutionMatrix[i, j];
                        greenColor += pixel.G * _convolutionMatrix[i, j];
                        blueColor += pixel.B * _convolutionMatrix[i, j];
                    }
                }

                Color resultPixel = Color.FromArgb(MatrixComponents.GetSaturatedColor(redColor),
                                                   MatrixComponents.GetSaturatedColor(greenColor),
                                                   MatrixComponents.GetSaturatedColor(blueColor));

                resultImage.SetPixel(x, y, resultPixel);
            }
        }

        return resultImage;
    }
}