using DrawShapes.Interfaces;

namespace DrawShapes.Shape
{
    public abstract class Shape : IShape
    {
        public string Name { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }

        public abstract void Draw();
    }
}
