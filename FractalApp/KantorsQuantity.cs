using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalApp
{
    class KantorsQuantity : FractalBase
    {


        internal int InitialHeight { get; set; }
        internal KantorsQuantity(int recursionDepth, int initialLength, int initialHeight, float initialX, float initialY, int distanceBetweenLayers) : base(recursionDepth, initialLength, initialX, initialY)
        {
            DistanceBetweenLayers = distanceBetweenLayers;
            InitialHeight = initialHeight;
            Type = "kantor";
        }
        internal override void Draw(int recursionStep, float x, float y, float length, double LeftAngle=0, double RightAngle=0)
        {

            if (recursionStep == RecursionDepth) return;

            FractalForm.brush1.Color = FractalForm.gradient[recursionStep];
            FractalForm.gr.FillRectangle(FractalForm.brush1, x, y, length, InitialHeight);

            if (recursionStep == 0)
            {
                Draw(recursionStep + 1, x, y + InitialHeight + DistanceBetweenLayers, length);
                return;
            }

            FractalForm.gr.FillRectangle(FractalForm.brush2, x + length / 3, y, length / 3, InitialHeight);

            Draw(recursionStep + 1, x, y + InitialHeight + DistanceBetweenLayers, length/3);
            Draw(recursionStep + 1, x + (float)2 / 3 * length, y + InitialHeight + DistanceBetweenLayers, length / 3);

        }
    }
}
