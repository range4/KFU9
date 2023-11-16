using System;
namespace KFU9
{
    internal interface iFigure
    {
        void MoveX(int dx);

        void MoveY(int dy);

        void SetColor(string color);

        void IsVisible(bool visible);

        void Print();
    }
}

