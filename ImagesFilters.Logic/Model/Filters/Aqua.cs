using ImagesFilters.Logic.Model.Components;

namespace ImagesFilters.Logic.Model.Filters;

internal class Aqua : IFilter
{
    private const int _matrixSize = 5;

    private readonly int[,] _sharpnessIncreaseMatrix;

    public Aqua()
    {
        _sharpnessIncreaseMatrix = GetSharpnessIncreaseMatrix();
    }

    public Bitmap Convert(Bitmap incomingImage)
    {
        var tempImage = new Bitmap(incomingImage);

        var halfMatrixSize = _matrixSize / 2;
        var pixelsArrayLength = _matrixSize * _matrixSize;
        var pixelsArrayMedian = pixelsArrayLength / 2;

        var yUpperLimit = incomingImage.Height - halfMatrixSize;
        var xUpperLimit = incomingImage.Width - halfMatrixSize;

        for (int y = halfMatrixSize; y < yUpperLimit; y++)
        {
            for (int x = halfMatrixSize; x < xUpperLimit; x++)
            {
                int[] redPixelsArray = new int[pixelsArrayLength];
                int[] greenPixelsArray = new int[pixelsArrayLength];
                int[] bluePixelsArray = new int[pixelsArrayLength];

                int index = 0;

                for (int i = 0, yNeighboringPixel = y - halfMatrixSize; i < _matrixSize; i++, yNeighboringPixel++)
                {
                    for (int j = 0, xNeighboringPixel = x - halfMatrixSize; j < _matrixSize; j++, xNeighboringPixel++)
                    {
                        Color pixel = incomingImage.GetPixel(xNeighboringPixel, yNeighboringPixel);

                        redPixelsArray[index] = pixel.R;
                        greenPixelsArray[index] = pixel.G;
                        bluePixelsArray[index] = pixel.B;

                        index++;
                    }
                }

                Array.Sort(redPixelsArray);
                Array.Sort(greenPixelsArray);
                Array.Sort(bluePixelsArray);

                Color resultPixel = Color.FromArgb(MatrixComponents.GetSaturatedColor(redPixelsArray[pixelsArrayMedian]),
                                                   MatrixComponents.GetSaturatedColor(greenPixelsArray[pixelsArrayMedian]),
                                                   MatrixComponents.GetSaturatedColor(bluePixelsArray[pixelsArrayMedian]));

                tempImage.SetPixel(x, y, resultPixel);
            }
        }

        var resultImage = new Bitmap(tempImage);

        halfMatrixSize = _sharpnessIncreaseMatrix.GetLength(0) / 2;
        yUpperLimit = tempImage.Height - halfMatrixSize;
        xUpperLimit = tempImage.Width - halfMatrixSize;

        for (int y = halfMatrixSize; y < yUpperLimit; y++)
        {
            for (int x = halfMatrixSize; x < xUpperLimit; x++)
            {
                var redColor = 0.0;
                var greenColor = 0.0;
                var blueColor = 0.0;

                for (int i = 0, yNeighboringPixel = y - halfMatrixSize; i < _sharpnessIncreaseMatrix.GetLength(0); i++, yNeighboringPixel++)
                {
                    for (int j = 0, xNeighboringPixel = x - halfMatrixSize; j < _sharpnessIncreaseMatrix.GetLength(0); j++, xNeighboringPixel++)
                    {
                        Color pixel = tempImage.GetPixel(xNeighboringPixel, yNeighboringPixel);

                        redColor += pixel.R * _sharpnessIncreaseMatrix[i, j];
                        greenColor += pixel.G * _sharpnessIncreaseMatrix[i, j];
                        blueColor += pixel.B * _sharpnessIncreaseMatrix[i, j];
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

    private static int[,] GetSharpnessIncreaseMatrix()
    {
        int[,] matrix = new int[3, 3]
        {
            {0, -1, 0 },
            {-1, 5, -1},
            {0, -1, 0 }
        };

        return matrix;
    }
}