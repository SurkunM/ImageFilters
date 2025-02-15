namespace ImagesFilters.Logic.Model.Filters;

internal class BlackAndWhite : IFilter
{   
    public Bitmap Convert(Bitmap incomingImage)
    {        
        var resultImage = new Bitmap(incomingImage);

        for (int y = 0; y < incomingImage.Height; y++)
        {
            for (int x = 0; x < incomingImage.Width; x++)
            {
                Color pixel = incomingImage.GetPixel(x, y);

                int greyColor = (int)Math.Round(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B, MidpointRounding.AwayFromZero);
                Color newPixel = Color.FromArgb(greyColor, greyColor, greyColor);

                resultImage.SetPixel(x, y, newPixel);
            }
        }
        
        return resultImage;
    }
}