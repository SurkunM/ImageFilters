using ImagesFilters.Logic.Model.Components;

namespace ImagesFilters.Logic.Model.Filters;

internal class Embossing : IFilter
{
    private readonly int[,] _convolutionMatrix;

    private readonly BlackAndWhite _blackAndWhiteFilter = default!;

    public Embossing()
    {
        _convolutionMatrix = new int[3, 3] 
        {
            { 0, 1, 0 },
            { -1, 0, 1},
            { 0, -1, 0}
        };

        _blackAndWhiteFilter = new BlackAndWhite();
    }

    public Bitmap Convert(Bitmap incomingImage)
    {
        var resultImage = _blackAndWhiteFilter.Convert(incomingImage);

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

                Color resultPixel = Color.FromArgb(MatrixComponents.GetSaturatedColor(redColor + 128),
                                                   MatrixComponents.GetSaturatedColor(greenColor + 128),
                                                   MatrixComponents.GetSaturatedColor(blueColor + 128));

                resultImage.SetPixel(x, y, resultPixel);
            }
        }

        return resultImage;
    }
}
