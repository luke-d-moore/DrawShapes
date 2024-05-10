namespace DrawShapes.Shape
{
    public class TextBox : Shape
    {
        public TextBox(int x, int y, int width, int height, string text)
        {
            LocationX = x;
            LocationY = y;
            Width = width;
            Height = height;
            Text = text;

            Validate();
        }

        public override string Name => nameof(TextBox);

        public override void Draw()
        {
            Console.WriteLine($"{Name} ({LocationX},{LocationY}) width={Width} height={Height} Text=\"{Text}\"");
        }
    }
}
