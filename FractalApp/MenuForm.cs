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
    public partial class MenuForm : Form
    {
        // Тип базового фрактала.
        internal string fractalType = "";
        // Начальный цет градиента.
        internal Color startColor = Color.Black;
        //Конечный цвет градиента.
        internal Color endColor = Color.Black;
        //Начальная глубина рекурсии.
        internal int initialRecursionDepth = 0;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            if (fractalType != "")
            {
                InitialRecursionHandler();
                if (initialRecursionDepth != 0)
                {
                    ChooseStartColor();
                    ChooseEndColor();
                    this.Hide();
                    FractalForm fractalForm = new FractalForm(this);
                    fractalForm.Show();
                    fractalForm.Redraw();
                }
            }
            else
            {
                MessageBox.Show("Ошибка!" + Environment.NewLine + "Пожалуйста, выберите фрактал.");
            }
        }

        private void comboBoxFractalChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFractalChoice.SelectedIndex)
            {
                case 0:
                    fractalType = "pythtree";
                    break;
                case 1:
                    fractalType = "koch";
                    break;
                case 2:
                    fractalType = "serpcarp";
                    break;
                case 3:
                    fractalType = "serptri";
                    break;
                case 4:
                    fractalType = "kantor";
                    break;
                default:
                    MessageBox.Show("Ошибка!" + Environment.NewLine + "Пожалуйста, выберите фрактал.");
                    break;


            }
        }

        private void InitialRecursionHandler()
        {
            try
            {
                initialRecursionDepth = int.Parse(textBoxInitialRecursion.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! " + Environment.NewLine + "Initial recursion handler:" + Environment.NewLine + ex.Message);
            }
            if (initialRecursionDepth < 0)
            {
                MessageBox.Show("Ошибка! " + Environment.NewLine + "Initial recursion handler:"
                                + Environment.NewLine + "Веденное значение глубины рекурсии меньше 0.");
                initialRecursionDepth = 0;
            }
        }

        private void ChooseStartColor()
        {
            switch (comboBoxStartColorChoice.SelectedIndex)
            {
                case 0:
                    startColor = Color.Red;
                    break;
                case 1:
                    startColor = Color.Orange;
                    break;
                case 2:
                    startColor = Color.Yellow;
                    break;
                case 3:
                    startColor = Color.Green;
                    break;
                case 4:
                    startColor = Color.Blue;
                    break;
                case 5:
                    startColor = Color.DarkBlue;
                    break;
                case 6:
                    startColor = Color.Violet;
                    break;
            }
        }

        private void ChooseEndColor()
        {
            switch (comboBoxEndColorChoice.SelectedIndex)
            {
                case 0:
                    endColor = Color.Red;
                    break;
                case 1:
                    endColor = Color.Orange;
                    break;
                case 2:
                    endColor = Color.Yellow;
                    break;
                case 3:
                    endColor = Color.Green;
                    break;
                case 4:
                    endColor = Color.Blue;
                    break;
                case 5:
                    endColor = Color.DarkBlue;
                    break;
                case 6:
                    endColor = Color.Violet;
                    break;
            }
        }
    }
}

