namespace DrawShapes.Shape
{
    public static class ShapeValidate
    {
        public static bool ValidateLocation(int x, int y)
        {
            if (x < 0) throw new ArgumentException("X location must not be less than 0.");
            if (y < 0) throw new ArgumentException("Y location must not be less than 0.");

            return true;
        }
        public static bool ValidateText(string text)
        {
            if (text == null) throw new ArgumentException("Text must not be null.");
            return true;
        }
        public static bool ValidateSize(int size)
        {
            if (size <= 0) throw new ArgumentException("Size must be greater than 0.");

            return true;
        }
        public static bool ValidateDimensions(int width, int height)
        {
            if (width <= 0) throw new ArgumentException("Width must be greater than 0.");
            if (height <= 0) throw new ArgumentException("Height must be greater than 0.");

            return true;
        }
    }
}
