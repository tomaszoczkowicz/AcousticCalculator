namespace AcousticCalculator
{
    public class CalculatedWindow
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public double Area { get; set; }
        public CalculatedWindow(int width, int height)
        {
            Width = width;
            Height = height;
            Area = width * height / 1000 / 1000;
        }
    }
}