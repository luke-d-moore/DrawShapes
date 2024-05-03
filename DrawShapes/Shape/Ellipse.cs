namespace DrawShapes.Shape
{
    public class Ellipse : Shape
    {
        public Ellipse(int x, int y, int diameterH, int diameterV)
        {
            Name = nameof(Ellipse);
            Text = string.Empty;

            if (ShapeValidate.ValidateLocation(x, y) && ShapeValidate.ValidateDimensions(diameterH, diameterV))
            {
                LocationX = x;
                LocationY = y;
                Width = diameterH;
                Height = diameterV;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) diameterH = {Width} diameterV = {Height}");
        }
    }
}
