using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FractalApp
{
    class SerpTriangle : FractalBase
    {
        //internal PointF p1;
        //internal PointF p2;
        //internal PointF p3;

        internal SerpTriangle(int recursionDepth, int initialLength, float initialX, float initialY) : base(recursionDepth, initialLength, initialX, initialY)
        {
            Type = "serptri";
            //p1 = new PointF(this.InitialX, this.InitialY);
            //p2 = new PointF(this.InitialX + InitialLength, this.InitialY);
            //p3 = new PointF(this.InitialX + InitialLength * (float)Math.Cos(Math.PI / 3), this.InitialY - InitialLength * (float)Math.Sin(Math.PI / 3));
        }
        internal override void Draw(int recursionStep, PointF p1, PointF p2, PointF p3)
        {
            if (recursionStep == RecursionDepth) return;

            FractalForm.pen1.Color = FractalForm.gradient[recursionStep];

            var p4 = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
            var p5 = new PointF((p2.X + p3.X) / 2, (p2.Y + p3.Y) / 2);
            var p6 = new PointF((p1.X + p3.X) / 2, (p1.Y + p3.Y) / 2);

            FractalForm.gr.DrawPolygon(FractalForm.pen1, new PointF[] { p2, p1, p3 });

            Draw(recursionStep + 1, p1, p4, p6);
            Draw(recursionStep + 1, p2, p4, p5);
            Draw(recursionStep + 1, p3, p5, p6);

        }

    }
    }
