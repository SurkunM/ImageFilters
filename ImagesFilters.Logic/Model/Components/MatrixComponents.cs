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

    public static double[,] GetMatrix(int matrixSize)
    {
        double[,] matrix = new double[matrixSize, matrixSize];
        double ratio = 1.0 / matrix.Length;

        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                matrix[i, j] = ratio;
            }
        }

        return matrix;
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

    public static int[,] GetEmbossingMatrix()
    {
        int[,] matrix = new int[3, 3]
        {
            { 0, 1, 0 },
            { -1, 0, 1},
            { 0, -1, 0}
        };

        return matrix;
    }
}