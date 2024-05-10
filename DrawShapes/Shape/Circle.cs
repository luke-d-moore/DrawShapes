namespace DrawShapes.Shape
{
    public class Circle : Shape
    {
        public Circle(int x, int y, int size)
        {
            Text = string.Empty;
            LocationX = x;
            LocationY = y;
            Width = size;

            Validate();
        }
        public override string Name => nameof(Circle);

        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) size={Width}");
        }
    }
}
