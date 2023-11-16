using System;
namespace KFU9
{
    internal class Circle : Point
    {
        private uint radius;

        public Circle(string color, bool visibility, int x, int y, uint radius)
            : base(color, visibility, x, y)
        {
            this.radius = radius;
        }

        public override void Print()
        {
            Console.WriteLine("Окружность");
            Console.WriteLine($"////Цвет: {color}");
            Console.WriteLine($"////Видимость: {visibility}");
            Console.WriteLine($"////Радиус: {radius}");
            Console.WriteLine($"////Координаты: {x}, {y}");
        }

        public double GetSpace()
        {
            return Math.PI * radius * radius;
        }
    }
}

