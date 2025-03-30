using ImagesFilters.Logic.Model.Components;

namespace ImagesFilters.Logic.Model.Filters;

internal class Sharpen : IFilter
{
    private readonly int[,] _sharpnessIncreaseMatrix;

    public Sharpen()
    {
        _sharpnessIncreaseMatrix = GetSharpnessIncreaseMatrix();
    }

    public Bitmap Convert(Bitmap incomingImage)
    {
        var resultImage = new Bitmap(incomingImage);

        var halfMatrixSize = _sharpnessIncreaseMatrix.GetLength(0) / 2;

        var yUpperLimit = incomingImage.Height - halfMatrixSize;
        var xUpperLimit = incomingImage.Width - halfMatrixSize;

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
                        Color pixel = incomingImage.GetPixel(xNeighboringPixel, yNeighboringPixel);

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

    public static int[,] GetSharpnessIncreaseMatrix()
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