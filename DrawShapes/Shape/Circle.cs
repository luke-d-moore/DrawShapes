namespace DrawShapes.Shape
{
    public class Circle : Shape
    {
        public Circle(int x, int y, int size)
        {
            Name = nameof(Circle);
            Text = string.Empty;
            LocationX = x;
            LocationY = y;
            Width = size;

            ValidateLocation();
            ValidateSize();
        }

        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) size={Width}");
        }
    }
}
