
namespace FractalApp
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxFractalChoice = new System.Windows.Forms.ComboBox();
            this.labelFractalChoice = new System.Windows.Forms.Label();
            this.comboBoxEndColorChoice = new System.Windows.Forms.ComboBox();
            this.labelStartColorChoice = new System.Windows.Forms.Label();
            this.comboBoxStartColorChoice = new System.Windows.Forms.ComboBox();
            this.labelInitialRecursionChoice = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.labelEndColorChoice = new System.Windows.Forms.Label();
            this.textBoxInitialRecursion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxFractalChoice
            // 
            this.comboBoxFractalChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFractalChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFractalChoice.FormattingEnabled = true;
            this.comboBoxFractalChoice.Items.AddRange(new object[] {
            "Дерево Пифагора",
            "Кривая Коха",
            "Ковер Серпинского",
            "Треугольник Серпинского",
            "Множество Кантора"});
            this.comboBoxFractalChoice.Location = new System.Drawing.Point(12, 166);
            this.comboBoxFractalChoice.Name = "comboBoxFractalChoice";
            this.comboBoxFractalChoice.Size = new System.Drawing.Size(441, 33);
            this.comboBoxFractalChoice.TabIndex = 0;
            this.comboBoxFractalChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxFractalChoice_SelectedIndexChanged);
            // 
            // labelFractalChoice
            // 
            this.labelFractalChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFractalChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFractalChoice.Location = new System.Drawing.Point(22, 65);
            this.labelFractalChoice.Name = "labelFractalChoice";
            this.labelFractalChoice.Size = new System.Drawing.Size(431, 86);
            this.labelFractalChoice.TabIndex = 1;
            this.labelFractalChoice.Text = "Выберите фрактал для отрисовки:";
            // 
            // comboBoxEndColorChoice
            // 
            this.comboBoxEndColorChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndColorChoice.FormattingEnabled = true;
            this.comboBoxEndColorChoice.Items.AddRange(new object[] {
            "Красный",
            "Оранжевый",
            "Желтый",
            "Зеленый",
            "Голубой",
            "Синий",
            "Фиолетовый"});
            this.comboBoxEndColorChoice.Location = new System.Drawing.Point(560, 338);
            this.comboBoxEndColorChoice.Name = "comboBoxEndColorChoice";
            this.comboBoxEndColorChoice.Size = new System.Drawing.Size(426, 33);
            this.comboBoxEndColorChoice.TabIndex = 2;
            // 
            // labelStartColorChoice
            // 
            this.labelStartColorChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStartColorChoice.Location = new System.Drawing.Point(553, 65);
            this.labelStartColorChoice.Name = "labelStartColorChoice";
            this.labelStartColorChoice.Size = new System.Drawing.Size(431, 86);
            this.labelStartColorChoice.TabIndex = 5;
            this.labelStartColorChoice.Text = "Выберите начальный цвет градиента:";
            // 
            // comboBoxStartColorChoice
            // 
            this.comboBoxStartColorChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartColorChoice.FormattingEnabled = true;
            this.comboBoxStartColorChoice.Items.AddRange(new object[] {
            "Красный",
            "Оранжевый",
            "Желтый",
            "Зеленый",
            "Голубой",
            "Синий",
            "Фиолетовый"});
            this.comboBoxStartColorChoice.Location = new System.Drawing.Point(560, 166);
            this.comboBoxStartColorChoice.Name = "comboBoxStartColorChoice";
            this.comboBoxStartColorChoice.Size = new System.Drawing.Size(426, 33);
            this.comboBoxStartColorChoice.TabIndex = 4;
            // 
            // labelInitialRecursionChoice
            // 
            this.labelInitialRecursionChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInitialRecursionChoice.Location = new System.Drawing.Point(555, 429);
            this.labelInitialRecursionChoice.Name = "labelInitialRecursionChoice";
            this.labelInitialRecursionChoice.Size = new System.Drawing.Size(431, 84);
            this.labelInitialRecursionChoice.TabIndex = 7;
            this.labelInitialRecursionChoice.Text = "Выберите начальную глубину рекурсии:";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonDraw.Location = new System.Drawing.Point(12, 608);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(974, 77);
            this.buttonDraw.TabIndex = 8;
            this.buttonDraw.Text = "Нарисовать";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // labelEndColorChoice
            // 
            this.labelEndColorChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEndColorChoice.Location = new System.Drawing.Point(555, 233);
            this.labelEndColorChoice.Name = "labelEndColorChoice";
            this.labelEndColorChoice.Size = new System.Drawing.Size(431, 86);
            this.labelEndColorChoice.TabIndex = 9;
            this.labelEndColorChoice.Text = "Выберите конечный цвет градиента:";
            // 
            // textBoxInitialRecursion
            // 
            this.textBoxInitialRecursion.Location = new System.Drawing.Point(562, 526);
            this.textBoxInitialRecursion.Name = "textBoxInitialRecursion";
            this.textBoxInitialRecursion.Size = new System.Drawing.Size(422, 31);
            this.textBoxInitialRecursion.TabIndex = 10;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 697);
            this.Controls.Add(this.textBoxInitialRecursion);
            this.Controls.Add(this.labelEndColorChoice);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.labelInitialRecursionChoice);
            this.Controls.Add(this.labelStartColorChoice);
            this.Controls.Add(this.comboBoxStartColorChoice);
            this.Controls.Add(this.comboBoxEndColorChoice);
            this.Controls.Add(this.labelFractalChoice);
            this.Controls.Add(this.comboBoxFractalChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFractalChoice;
        private System.Windows.Forms.Label labelFractalChoice;
        private System.Windows.Forms.ComboBox comboBoxEndColorChoice;
        private System.Windows.Forms.Label labelStartColorChoice;
        private System.Windows.Forms.ComboBox comboBoxStartColorChoice;
        private System.Windows.Forms.Label labelInitialRecursionChoice;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Label labelEndColorChoice;
        private System.Windows.Forms.TextBox textBoxInitialRecursion;
    }
}