namespace ImagesFilters.Logic.Model.Filters;

internal class BlackAndWhite : IFilter
{
    public string Name { get; } = "BlackAndWhite";

    public static Bitmap Convert(Bitmap originalImage)
    {        
        var resultImage = new Bitmap(originalImage);

        for (int y = 0; y < originalImage.Height; y++)
        {
            for (int x = 0; x < originalImage.Width; x++)
            {
                Color pixel = originalImage.GetPixel(x, y);

                int greyColor = (int)Math.Round(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B, MidpointRounding.AwayFromZero);
                Color newPixel = Color.FromArgb(greyColor, greyColor, greyColor);

                resultImage.SetPixel(x, y, newPixel);
            }
        }
        
        return resultImage;
    }
}