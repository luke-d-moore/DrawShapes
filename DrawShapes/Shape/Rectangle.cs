namespace DrawShapes.Shape
{
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, int width, int height)
        {
            Name = nameof(Rectangle);
            Text = string.Empty;

            if (ShapeValidate.ValidateLocation(x, y) && ShapeValidate.ValidateDimensions(width, height))
            {
                LocationX = x;
                LocationY = y;
                Width = width;
                Height = height;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) width={Width} height={Height}");
        }
    }
}
