using System.Drawing;

/// <summary>
/// Filters the gray component from an image.
/// </summary>
namespace _02_BitmapPlayground.Filters
{
    public class GrayFilter : IFilter
    {
        public Color[,] Apply(Color[,] input)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            Color[,] result = new Color[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var p = input[x, y];

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    int avg = (r + g + b) / 3;

                    result[x, y] = Color.FromArgb(a, avg, avg, avg);
                }
            }

            return result;
        }

        public string Name => "Filter gray component";

        public override string ToString()
            => Name;
    }
}
