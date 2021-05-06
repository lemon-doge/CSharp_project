using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalApp

{
    abstract class FractalBase
    {
        // Тип фрактала.
        internal string Type { get; set; }
        // Глубина рекурсии.
        internal int RecursionDepth { get; set; }

        // Начальная длина базового отрезка.
        internal int InitialLength { get; set; }

        // Начальный х.
        internal float InitialX { get; set; }

        // Начальный у.
        internal float InitialY { get; set; }
        // Расстояние между слоями.
        internal int DistanceBetweenLayers { get; set; }

        // Отношение длин отрезков на селедующей итерации.
        internal float StepRatio { get; set; }

        // Угол наклона левой ветки.
        internal double LeftBranchAngle { get; set; }

        // Угол наклона правой ветки.
        internal double RightBranchAngle { get; set; }


        // Базовый конструктор.
        internal FractalBase(int recursionDepth, int initialLength,float initialX,float initialY)
        {
            RecursionDepth = recursionDepth;
            InitialLength = initialLength;
            InitialX = initialX;
            InitialY = initialY;
        }
        // Метод для рисования фракталов с одной значимой точкой.
        internal virtual void Draw(int recursionStep, float x, float y, float length, double leftAngle = 0, double rightAngle = 0) { }

        // Метод для рисования фракаталов с тремя значимыми точками.
        internal virtual void Draw(int recursionStep, PointF p1, PointF p2, PointF p3) { }
        

    }
    
}
