namespace DrawShapes.Shape
{
    public class TextBox : Shape
    {
        public TextBox(int x, int y, int width, int height, string text)
        {
            Name = nameof(TextBox);
            LocationX = x;
            LocationY = y;
            Width = width;
            Height = height;
            Text = text;

            ValidateLocation();
            ValidateText();
            ValidateDimensions();
        }

        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) width={Width} height={Height} Text=\"{Text}\"");
        }
    }
}
