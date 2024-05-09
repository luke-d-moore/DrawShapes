namespace DrawShapes.Shape
{
    public class Ellipse : Shape
    {
        public Ellipse(int x, int y, int diameterH, int diameterV)
        {
            Name = nameof(Ellipse);
            Text = string.Empty;
            LocationX = x;
            LocationY = y;
            Width = diameterH;
            Height = diameterV;

            ValidateLocation();
            ValidateDimensions();
        }

        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) diameterH = {Width} diameterV = {Height}");
        }
    }
}
