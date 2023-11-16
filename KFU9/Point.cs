using System;
namespace KFU9
{
    internal class Point : Figure
    {
        protected int x;
        protected int y;
        public Point(string color, bool visibility, int x, int y)
            : base(color, visibility)
        {
            this.x = x;
            this.y = y;
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
            Console.WriteLine("Точка:");
            Console.WriteLine($"////Цвет: {color}");
            Console.WriteLine($"////Видимость: {visibility}");
            Console.WriteLine($"////Координаты: {x}, {y}");
        }
    }
}
