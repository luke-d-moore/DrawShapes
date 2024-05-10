﻿using DrawShapes.Interfaces;
using System.Net.Http.Headers;
using System.Security.Principal;

namespace DrawShapes.Shape
{
    public abstract class Shape : IShape
    {
        public abstract string Name { get; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }

        public bool Validate()
        {
            switch (Name)
            {
                case nameof(Square):
                    ValidateLocation();
                    ValidateSize();
                break;
                case nameof(Circle):
                    ValidateLocation();
                    ValidateSize();
                break;
                case nameof(Ellipse):
                    ValidateLocation();
                    ValidateDimensions();
                break;
                case nameof(Rectangle):
                    ValidateLocation();
                    ValidateDimensions();
                break;
                case nameof(TextBox): 
                    ValidateLocation();
                    ValidateDimensions();
                    ValidateText();
                break;
                default:
                throw new NotImplementedException();
            }
            return true;
        }

        private bool ValidateLocation()
        {
            if (LocationX < 0) throw new ArgumentException("X location must not be less than 0.");
            if (LocationY < 0) throw new ArgumentException("Y location must not be less than 0.");

            return true;
        }
        private bool ValidateText()
        {
            if (Text == null) throw new ArgumentException("Text must not be null.");
            return true;
        }
        private bool ValidateSize()
        {
            if (Width <= 0) throw new ArgumentException("Size must be greater than 0.");

            return true;
        }
        private bool ValidateDimensions()
        {
            if (Width <= 0) throw new ArgumentException("Width must be greater than 0.");
            if (Height <= 0) throw new ArgumentException("Height must be greater than 0.");

            return true;
        }

        public abstract void Draw();
    }
}
