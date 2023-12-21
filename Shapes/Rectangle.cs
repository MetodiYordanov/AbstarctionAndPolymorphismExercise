using System;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width 
        { 
            get
            {
                return this._width;
            }
            private set
            { 
                this._width = value;
            }
        }

        public int Height
        {
            get
            {
                return this._height;
            }
            private set
            {
                this._height = value;
            }
        }

        public void Draw()
        {
            DrawLine(this.Width, '*', '*');
            for (int i = 1; i < this.Height - 1; ++i)
            {
                DrawLine(this.Width, '*', ' ');
            }
            DrawLine(this.Width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}
