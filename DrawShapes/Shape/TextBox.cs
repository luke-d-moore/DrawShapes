namespace DrawShapes.Shape
{
    public class TextBox : Shape
    {
        public TextBox(int x, int y, int width, int height, string text)
        {
            Name = nameof(TextBox);

            if (ShapeValidate.ValidateLocation(x, y) && ShapeValidate.ValidateText(text) && ShapeValidate.ValidateDimensions(width, height))
            {
                LocationX = x;
                LocationY = y;
                Width = width;
                Height = height;
                Text = text;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) width={Width} height={Height} Text=\"{Text}\"");
        }
    }
}
