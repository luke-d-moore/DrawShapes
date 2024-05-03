namespace DrawShapes.Shape
{
    public class Circle : Shape
    {
        public Circle(int x, int y, int size)
        {
            Name = nameof(Circle);
            Text = string.Empty;

            if (ShapeValidate.ValidateLocation(x, y) && ShapeValidate.ValidateSize(size))
            {
                LocationX = x;
                LocationY = y;
                Width = size;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) size={Width}");
        }
    }
}
