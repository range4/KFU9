using System;
namespace KFU9
{
    internal abstract class Figure : iFigure
    {
        protected string color;
        protected bool visibility;

        public Figure(string color, bool visibility)
        {
            this.color = color;
            this.visibility = visibility;
        }

        public abstract void MoveX(int dx);

        public abstract void MoveY(int dy);

        public abstract void SetColor(string color);

        public abstract void IsVisible(bool visibility);

        public abstract void Print();
    }
}

