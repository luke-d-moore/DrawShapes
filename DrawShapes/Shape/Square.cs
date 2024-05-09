namespace DrawShapes.Shape
{
    public class Square : Shape
    {
        public Square(int x, int y, int size)
        {
            Name = nameof(Square);
            Text = string.Empty;
            LocationX = x;
            LocationY = y;
            Width = size;
            Height = size;

            ValidateLocation();
            ValidateSize();
        }

        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) size={Width}");
        }
    }
}
