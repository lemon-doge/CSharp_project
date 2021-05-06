using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalApp
{
    class KochCurve : FractalBase
    {
        internal KochCurve(int recursionDepth, int initialLength, float initialX, float initialY) : base(recursionDepth, initialLength, initialX, initialY)
        {
            Type = "koch";
        }
        internal override void Draw(int recursionStep, PointF p1, PointF p2,  PointF pn)
        {
            
            if (recursionStep == RecursionDepth) return;
            FractalForm.pen1.Color = FractalForm.gradient[recursionStep];
            if (recursionStep == 0)
            {
                FractalForm.gr.DrawLine(FractalForm.pen1, p1, p2);
            }
            
            var p3 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
            var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
            var p5 = new PointF((2 * p1.X + 2 * p2.X - pn.X) / 3, (2 * p1.Y + 2 * p2.Y - pn.Y) / 3);

            FractalForm.gr.DrawLine(FractalForm.pen1, p3, p5);
            FractalForm.gr.DrawLine(FractalForm.pen1, p4, p5);
            FractalForm.gr.DrawLine(FractalForm.pen2, p3, p4);

            Draw(recursionStep + 1, p3,p5,p4);
            Draw(recursionStep + 1, p4, p5,p3);
            Draw(recursionStep + 1, p1, p4, new PointF((2 * p1.X +pn.X) / 3, (2 * p1.Y + pn.Y) / 3));
            Draw(recursionStep + 1, p3, p2, new PointF((2 * p2.X + pn.X) / 3, (2 * p2.Y + pn.Y) / 3));

        }

    
}
}
