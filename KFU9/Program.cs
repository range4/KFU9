using System;
using KFU9;

namespace KFU9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 10.1\n");
            ACipher aCipher = new ACipher();
            BCipher bCipher = new BCipher();

            String text = "I want Bentley i want money";

            Console.WriteLine($"Исходная строка: {text}");
            Console.WriteLine($"Зашифрованная строка A: {aCipher.Encode(text)}");
            Console.WriteLine($"Расшифрованная строка A: {aCipher.Decode(aCipher.Encode(text))}");
            Console.WriteLine($"Зашифрованная строка B: {bCipher.Encode(text)}");
            Console.WriteLine($"Расшифрованная строка B: {bCipher.Decode(bCipher.Encode(text))}");

            Console.WriteLine("DZ 1\n");
            Point point = new Point("Черный", true, 6, -7);
            point.Print();
            point.MoveX(100);
            point.SetColor("Красный");
            point.IsVisible(false);
            point.Print();

            Circle circle = new Circle("Черный", true, 25, 25, 5);
            circle.Print();
            double space = circle.GetSpace();
            Console.WriteLine("Площадь окружности: {0}", space);

            Rectangle rectangle = new Rectangle("Белый",false, 70, 150, 50, 80);
            rectangle.Print();
            uint space1 = rectangle.GetSpace();
            Console.WriteLine("Площадь прямоугольника: {0}", space1);
        }
    }
}

