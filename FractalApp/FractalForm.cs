using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalApp
{
    public partial class FractalForm : Form
    {
    

        // Main pen.
        internal static Pen pen1;
        // Eraser pen.
        internal static Pen pen2;
        // Main solid brush.
        internal static SolidBrush brush1;
        // Eraser solid brush.
        internal static SolidBrush brush2;
        // Graphics object.
        internal static Graphics gr;

        // Recursion depth.
        private int recursionDepth;
        // Zoom value.
        private int zoom = 1;

        // Clicked state of pictureBox.
        bool isClicked = false;

        // Drag coordinates.
        float deltaX;
        float deltaY;

        // Parent menu form.
        MenuForm parent;

        // Gradient for coloring.
        internal static List<Color> gradient;

        // Main fractal.
        FractalBase fractal;


        public FractalForm(MenuForm parent)
        {
            InitializeComponent();
            this.parent = parent;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                recursionDepth = RecursionDepthHandler(parent.initialRecursionDepth.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Непредвиденная ошибка" + Environment.NewLine + ex.Message);
            }

            // Initialising main fractal and form.
            switch (parent.fractalType)
            {
                case "pythtree":

                    // Initialising special form elements.
                    labelLengthRatio.Visible = true;
                    labelRightBranchAngle.Visible = true;
                    labelLeftBranchAngle.Visible = true;
                    textBoxLenRatio.Visible = true;
                    textBoxRightBranchAngle.Visible = true;
                    textBoxLeftBranchAngle.Visible = true;

                    fractal = new PythTree(recursionDepth, pictureBox1.Height / 3, pictureBox1.Width / 2,
                                            pictureBox1.Height * 4 / 5, (float)0.6381, Math.PI / 4, Math.PI / 4);
                    textBoxLenRatio.Text = 0.6381.ToString();
                    textBoxRightBranchAngle.Text = 45.ToString();
                    textBoxLeftBranchAngle.Text = 45.ToString();

                    break;
                case "koch":
                    fractal = new KochCurve(recursionDepth, pictureBox1.Width * 3 / 5, pictureBox1.Width / 5,
                                            pictureBox1.Height * 4 / 5);
                    break;
                case "serpcarp":
                    fractal = new SerpCarpet(recursionDepth, pictureBox1.Width * 3 / 5, pictureBox1.Width / 5,
                                            pictureBox1.Height / 5);
                    break;
                case "serptri":
                    fractal = new SerpTriangle(recursionDepth, pictureBox1.Width * 3 / 5, pictureBox1.Width / 5,
                                            pictureBox1.Height * 3 / 5);
                    break;
                case "kantor":

                    // Initialising special form elements.
                    textBoxDistanceBetweenLayers.Visible = true;
                    labelLayersDistance.Visible = true;

                    textBoxDistanceBetweenLayers.Location = labelLeftBranchAngle.Location;
                    labelLayersDistance.Location = labelLengthRatio.Location ;

                    fractal = new KantorsQuantity(recursionDepth, pictureBox1.Width * 3 / 5, pictureBox1.Height / 20, pictureBox1.Width / 5,
                                            pictureBox1.Height / 5, pictureBox1.Height / 40);
                    break;
            }

            maskedTextBoxRecursionCurrent.Text = recursionDepth.ToString();

            gr = pictureBox1.CreateGraphics();

            // Initialising components.
            pen1 = new Pen(Color.Black, 1);
            pen2 = new Pen(pictureBox1.BackColor, 1);

            brush1 = new SolidBrush(Color.Black);
            brush2 = new SolidBrush(pictureBox1.BackColor);

            gradient = GetGradient(parent.startColor, parent.endColor, parent.initialRecursionDepth);

            gr.Clear(pictureBox1.BackColor);
        }

        private void buttonRedraw_Click(object sender, EventArgs e)
        {

            Redraw();

            //float.Parse(maskedTextBoxLeftBranchAngle.Text), float.Parse(maskedTextBoxRightBranchAngle.Text)
            //float.Parse(maskedTextBoxLengthRatio.Text)

        }

        //Redraw function.
        internal void Redraw()
        {
            if (fractal == null) return;

            pictureBox1.Refresh();
            gr = pictureBox1.CreateGraphics();
            
            
        // Indicating fractal type.
            if (fractal.Type == "pythtree")
            {
                try
                {
                    
                    fractal.StepRatio = LenRatioHandler(textBoxLenRatio.Text);
                    fractal.LeftBranchAngle = LeftAngleHandler(textBoxLeftBranchAngle.Text);
                    fractal.RightBranchAngle = RightAngleHandler(textBoxRightBranchAngle.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (fractal.Type == "kantor")
            {
                try
                {
                    fractal.DistanceBetweenLayers = DistanceBetweenLayersHandler(textBoxDistanceBetweenLayers.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (fractal.Type == "koch")
            {
                try
                {
                    fractal.InitialLength = pictureBox1.Width * 3 / 5;
                    fractal.RecursionDepth = RecursionDepthHandler(maskedTextBoxRecursionCurrent.Text);
                    fractal.Draw(0,
                        new PointF(fractal.InitialX, fractal.InitialY),
                        new PointF((fractal.InitialX + fractal.InitialLength * zoom), fractal.InitialY),
                        new PointF((fractal.InitialX + fractal.InitialX + fractal.InitialLength * zoom) / 2,
                                    fractal.InitialY - (fractal.InitialX - (fractal.InitialX + fractal.InitialLength * zoom)) / 2 * (float)Math.Tan(Math.PI / 3))
                        );

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (fractal.Type == "serptri")
            {
                try
                {
                    fractal.InitialLength = pictureBox1.Width * 3 / 5;
                    fractal.RecursionDepth = RecursionDepthHandler(maskedTextBoxRecursionCurrent.Text);
                    fractal.Draw(0,
                        new PointF(fractal.InitialX, fractal.InitialY),
                        new PointF(fractal.InitialX + fractal.InitialLength * zoom, fractal.InitialY),
                        new PointF(fractal.InitialX + fractal.InitialLength * zoom * (float)Math.Cos(Math.PI / 3),
                                   fractal.InitialY - fractal.InitialLength * zoom * (float)Math.Sin(Math.PI / 3)
                                   ));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    fractal.InitialLength = pictureBox1.Width * 3 / 5;
                    fractal.RecursionDepth = RecursionDepthHandler(maskedTextBoxRecursionCurrent.Text);
                    fractal.Draw(0, fractal.InitialX, fractal.InitialY, fractal.InitialLength * zoom,
                                    fractal.LeftBranchAngle, fractal.RightBranchAngle);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        // Recursion handler.
        private int RecursionDepthHandler(string inp)
        {
            int n = 0;
            if (inp != "")
            {
                try
                {
                    n = int.Parse(inp);
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка! " + Environment.NewLine + "Recursion depth:" + Environment.NewLine + ex.Message);
                }
                if (n >= 0)
                {
                    // Предупреждение.
                    if (n >= 15 && n < 20)
                    {
                        string message = "Высокий уровень рекурсии!" 
                                        + Environment.NewLine + "Возможно искажение изображения при работе программы."
                                        + Environment.NewLine + Environment.NewLine + "Хотите продолжить?";
                        string caption = "Внимание!" + Environment.NewLine;
                        MessageBox.Show(message, caption);


                    }
                    // Настоятельное предупреждение ,
                    if (n >= 20 && n < 25)
                    {
                        string message = "Опасно высокий уровень рекурсии!"
                                        + Environment.NewLine + "Высокая вероятность переполнения стека."
                                        + Environment.NewLine + Environment.NewLine + "Хотите продолжить?";
                        string caption = "Внимание!" + Environment.NewLine;
                        MessageBox.Show(message, caption);
                    }
                    // Превышение уровня рекурсии.
                    if (n >= 25) throw new Exception ("Превышена максимальная допустимая глубина рекурсии.");

                    gradient = GetGradient(parent.startColor, parent.endColor, n);
                    return n;

                }
                else
                {
                    throw new Exception("Ошибка! " + Environment.NewLine + "Recursion depth:"
                                    + Environment.NewLine + "Веденное значение глубины рекурсии меньше 0.");
                }

            }
            return recursionDepth;
        }
        // Обработчик для расстояния между слоями.
        private int DistanceBetweenLayersHandler(string inp)
        {
            int n = fractal.DistanceBetweenLayers;
            int k = -1;
            if (inp != "")
            {
                try
                {
                    k = int.Parse(inp);
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка! " + Environment.NewLine + "Distance between layers:" + Environment.NewLine + ex.Message);
                }
                if (k >= 0)
                {
                    n = k;
                }
                else
                {
                    throw new Exception("Ошибка! " + Environment.NewLine + "Distance between layers:"
                                    + Environment.NewLine + "Веденное значение расстояния между слоями меньше 0.");
                }
            }
            return n;
        }
    // Обработчк для отношения сторон7
        private float LenRatioHandler(string inp)
        {
            float n = fractal.StepRatio;
            float k = -1;
            if (inp != "")
            {
                try
                {
                    k = float.Parse(inp);
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка! " + Environment.NewLine + "Length ratio:" + Environment.NewLine + ex.Message);
                }
                if (k >= 0)
                {
                    if (k <= 1)
                    {
                        n = k;
                    }
                    else
                    {
                        throw new Exception("Ошибка! " + Environment.NewLine + "Length ratio:"
                                    + Environment.NewLine + "Веденное значение отношения длин на следующей итерации больше 1.");
                    }
                }
                else
                {
                    throw new Exception("Ошибка! " + Environment.NewLine + "Length ratio:"
                                    + Environment.NewLine + "Веденное значение отношения длин на следующей итерации меньше 0.");
                }
            }
            return n;
        }
        //обработчик для
        private double LeftAngleHandler(string inp)
        {
            double n = fractal.LeftBranchAngle;
            double k = -1;
            if (inp != "")
            {
                try
                {
                    k = double.Parse(inp);
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка! " + Environment.NewLine + "Left branch angle:" + Environment.NewLine + ex.Message);
                }
                if (k >= 0)
                {
                    if (k <= 180)
                    {
                        n = Math.PI * k / 180;
                    }
                    else
                    {
                        throw new Exception("Ошибка! " + Environment.NewLine + "Left branch angle:"
                                    + Environment.NewLine + "Веденное значение угла наклона левой ветки больше 180.");
                    }
                }
                else
                {
                    throw new Exception("Ошибка! " + Environment.NewLine + "Left branch angle:"
                                    + Environment.NewLine + "Веденное значение угла наклона левой ветки меньше 0.");
                }
            }
            return n;
        }
        // И так читается зачем я вообще это пишу
        private double RightAngleHandler(string inp)
        {
            double n = fractal.LeftBranchAngle;
            double k = -1;
            if (inp != "")
            {
                try
                {
                    k = double.Parse(inp);
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка! " + Environment.NewLine + "Right branch angle:" + Environment.NewLine + ex.Message);
                }
                if (k >= 0)
                {
                    if (k <= 180)
                    {
                        n = Math.PI * k / 180;
                    }
                    else
                    {
                        throw new Exception("Ошибка! " + Environment.NewLine + "Right branch angle:"
                                    + Environment.NewLine + "Веденное значение угла наклона левой ветки больше 180.");
                    }
                }
                else
                {
                    throw new Exception("Ошибка! " + Environment.NewLine + "Right branch angle:"
                                    + Environment.NewLine + "Веденное значение угла наклона левой ветки меньше 0.");
                }
            }
            return n;
        }

        // Логика обработки для зума.
        private int ZoomHandler(int index)
        {
            switch (index)
            {
                case 0:
                    return 2;
                case 1:
                    return 3;
                case 2:
                    return 5;
                default:
                    return 1;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            zoom = ZoomHandler(comboBoxZoom.SelectedIndex);
        }


        // Перерисовка при изменении размера формы.
        private void Form1_Resize(object sender, EventArgs e)
        { 
            Redraw();
        }

        // Логика для перемещения картинки по боксу.
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isClicked = true;
            deltaX = e.X - fractal.InitialX;
            deltaY = e.Y - fractal.InitialY;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                fractal.InitialX = e.X - deltaX;
                fractal.InitialY = e.Y - deltaY;
               
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;

            Redraw();
        }

        // Стандартная функция получения линейного градиента.
        private List<Color> GetGradient(Color startColor, Color endColor, int steps)
        {
            List<Color> gradient = new List<Color>();
            int rMax = endColor.R;
            int rMin = startColor.R;
            int gMax = endColor.G;
            int gMin = startColor.G;
            int bMax = endColor.B;
            int bMin = startColor.B;

            for (int i = 0; i < steps; i++)
            {
                var rAverage = rMin + (int)((rMax - rMin) * i / steps);
                var gAverage = gMin + (int)((gMax - gMin) * i / steps);
                var bAverage = bMin + (int)((bMax - bMin) * i / steps);
                gradient.Add(Color.FromArgb(rAverage, gAverage, bAverage));
            }

            return gradient;
        }

        // кнопка выхода.
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                parent.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            parent.Show();
        }

        // НЕ работает((
        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
