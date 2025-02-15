using ImagesFilters.Logic.Model.Components;

namespace ImagesFilters.Logic.Model.Filters;

internal class LiteBlur// Скорее всего не сработает! Удалить!!!
{
    private void ConvertBitmapToUintMatrix(Bitmap bitmap)
    {
        // _currentImagePixels = new uint[_currentImage.Height, _currentImage.Width]; это из View
        //for(int y = 0; y < _currentImage.Height; y++) 
        //{
        //    for(int x = 0;  x < _currentImage.Width; x++)
        //    {
        //        _currentImagePixels[y, x] = (uint)_currentImage.GetPixel(x, y).ToArgb();
        //    }
        //}
    }

    public uint[,] ConvertPixels(double[,] matrix, uint[,] pixels) //TODO: возможно через перевод пикселей в массив уинтов! Нужен класс RGB или Енум и побитово взять из pixel[x,y] по 3 значения
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

                Color resultPixel = Color.FromArgb(MatrixComponents.GetSaturatedColor(redColor),
                                                   MatrixComponents.GetSaturatedColor(greenColor),
                                                   MatrixComponents.GetSaturatedColor(blueColor));

                //  resultPixels[x, y] = resultPixel.ToArgb();
            }
        }

        return resultPixels;
    }

    //public static RGB calculationOfColor(UInt32 pixel, double coefficient)
    //{
    //    RGB Color = new RGB();
    //    Color.R = (float)(coefficient * ((pixel & 0x00FF0000) >> 16));
    //    Color.G = (float)(coefficient * ((pixel & 0x0000FF00) >> 8));
    //    Color.B = (float)(coefficient * (pixel & 0x000000FF));
    //    return Color;
    //}
}
