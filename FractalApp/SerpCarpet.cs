using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalApp
{
    class SerpCarpet : FractalBase
    {
        internal SerpCarpet(int recursionDepth, int initialLength, float initialX, float initialY) : base(recursionDepth, initialLength, initialX, initialY)
        {
            Type = "serpcarp";
        }
        internal override void Draw(int recursionStep, float x, float y, float length, double LeftAngle = 0, double RightAngle = 0)
        {

            if (recursionStep == RecursionDepth) return;

            FractalForm.brush2.Color = FractalForm.gradient[recursionStep];
            // Check if theres any color. 
            if (FractalForm.gradient[0].R == FractalForm.gradient[this.RecursionDepth-1].R && 
                FractalForm.gradient[0].G == FractalForm.gradient[this.RecursionDepth - 1].G &&
                FractalForm.gradient[0].R == FractalForm.gradient[this.RecursionDepth - 1].B) FractalForm.brush2.Color = Color.White;

            FractalForm.gr.FillRectangle(FractalForm.brush1, x, y, length,length);
            FractalForm.gr.FillRectangle(FractalForm.brush2, x + length / 3, y + length / 3, length / 3, length / 3);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != 1 || j != 1)
                    {
                        Draw(recursionStep + 1, x + length / 3 * i, y + length / 3 * j, length / 3);
                    }
                }
            }

        }
    }
}
