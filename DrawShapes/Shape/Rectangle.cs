namespace DrawShapes.Shape
{
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, int width, int height)
        {
            Text = string.Empty;
            LocationX = x;
            LocationY = y;
            Width = width;
            Height = height;

            Validate();
        }

        public override string Name => nameof(Rectangle);

        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) width={Width} height={Height}");
        }
    }
}
