namespace ImagesFilters.Logic.Model.Components;

public class MatrixComponents
{
    public static int GetSaturatedColor(double color)
    {
        if (color <= 0)
        {
            return 0;
        }

        if (color >= 255)
        {
            return 255;
        }

        return (int)Math.Round(color, MidpointRounding.AwayFromZero);
    }
}