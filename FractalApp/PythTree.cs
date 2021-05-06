using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalApp
{
    class PythTree : FractalBase
    {

        // Конструктор с параметрами.
        internal PythTree(int recursionDepth, int initialLength, float initialX, float initialY, float stepRatio,double leftBranchAngle, double rightBranchAngle) : base(recursionDepth,initialLength, initialX,initialY)
        {
            StepRatio = stepRatio;
            LeftBranchAngle = leftBranchAngle;
            RightBranchAngle = rightBranchAngle;
            Type = "pythtree";
        }

        //Переопределенный метод для рисования фрактала с одной значимой точкой.
        internal override void Draw(int recursionStep, float x, float y, float length, double leftAngle, double rightAngle)
        {
            if (recursionStep == RecursionDepth) return;

            FractalForm.pen1.Color = FractalForm.gradient[recursionStep];

            if (recursionStep == 0)
            {
                FractalForm.gr.DrawLine(FractalForm.pen1, x, y, x, y - length);
                Draw(recursionStep + 1, x, y - length, length * StepRatio, LeftBranchAngle, RightBranchAngle);
                return;
            }
            // Рисуем две ветки.
            float xLeft = x - length * (float)Math.Sin(leftAngle);
            float yLeft = y - length * (float)Math.Cos(leftAngle);
            FractalForm.gr.DrawLine(FractalForm.pen1, x, y, xLeft, yLeft);
            float xRight = x + length * (float)Math.Sin(rightAngle);
            float yRight = y - length * (float)Math.Cos(rightAngle);
            FractalForm.gr.DrawLine(FractalForm.pen1, x, y, xRight, yRight);


            // Рекурсивно вызываем для слудующей пары.
            Draw(recursionStep + 1, xLeft, yLeft, length * StepRatio, leftAngle + LeftBranchAngle, rightAngle - LeftBranchAngle);
            Draw(recursionStep + 1, xRight, yRight, length * StepRatio, leftAngle - RightBranchAngle, rightAngle + RightBranchAngle);

        }

    }
}
