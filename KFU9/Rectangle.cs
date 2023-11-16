using System;
namespace KFU9
{
    internal class Rectangle : Point
    {
        private uint width;
        private uint height;

        public Rectangle(string color, bool visibility, int x, int y, uint width, uint height)
            : base(color, visibility, x, y)
        {
            this.width = width;
            this.height = height;
        }

        public override void MoveX(int dx)
        {
            x += dx;
        }

        public override void MoveY(int dy)
        {
            y += dy;
        }

        public override void SetColor(string color)
        {
            this.color = color;
        }

        public override void IsVisible(bool visibility)
        {
            this.visibility = visibility;
        }

        public override void Print()
        {
            Console.WriteLine("Прямоугольник");
            Console.WriteLine($"////Цвет: {color}");
            Console.WriteLine($"////Видимость: {visibility}");
            Console.WriteLine($"////Ширина: {width}");
            Console.WriteLine($"////Высота: {height}");
            Console.WriteLine($"////Координаты: {x}, {y}");
        }

        public uint GetSpace()
        {
            return width * height;
        }
    }
}
