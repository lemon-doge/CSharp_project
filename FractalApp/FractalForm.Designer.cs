using System.Windows.Forms;
namespace FractalApp
{
    partial class FractalForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonQuit = new System.Windows.Forms.Button();
            this.maskedTextBoxRecursionCurrent = new System.Windows.Forms.MaskedTextBox();
            this.labelRecursionCurrent = new System.Windows.Forms.Label();
            this.labelZoom = new System.Windows.Forms.Label();
            this.labelLeftBranchAngle = new System.Windows.Forms.Label();
            this.labelLengthRatio = new System.Windows.Forms.Label();
            this.labelLayersDistance = new System.Windows.Forms.Label();
            this.labelRightBranchAngle = new System.Windows.Forms.Label();
            this.buttonRedraw = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxZoom = new System.Windows.Forms.ComboBox();
            this.textBoxDistanceBetweenLayers = new System.Windows.Forms.TextBox();
            this.textBoxLenRatio = new System.Windows.Forms.TextBox();
            this.textBoxLeftBranchAngle = new System.Windows.Forms.TextBox();
            this.textBoxRightBranchAngle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonQuit.Location = new System.Drawing.Point(676, 599);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(318, 86);
            this.buttonQuit.TabIndex = 3;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // maskedTextBoxRecursionCurrent
            // 
            this.maskedTextBoxRecursionCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxRecursionCurrent.Location = new System.Drawing.Point(671, 57);
            this.maskedTextBoxRecursionCurrent.Name = "maskedTextBoxRecursionCurrent";
            this.maskedTextBoxRecursionCurrent.Size = new System.Drawing.Size(311, 31);
            this.maskedTextBoxRecursionCurrent.TabIndex = 4;
            // 
            // labelRecursionCurrent
            // 
            this.labelRecursionCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecursionCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRecursionCurrent.Location = new System.Drawing.Point(670, 12);
            this.labelRecursionCurrent.Name = "labelRecursionCurrent";
            this.labelRecursionCurrent.Size = new System.Drawing.Size(311, 35);
            this.labelRecursionCurrent.TabIndex = 5;
            this.labelRecursionCurrent.Text = "Recursion depth:";
            // 
            // labelZoom
            // 
            this.labelZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelZoom.Location = new System.Drawing.Point(671, 118);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(311, 35);
            this.labelZoom.TabIndex = 9;
            this.labelZoom.Text = "Zoom:";
            // 
            // labelLeftBranchAngle
            // 
            this.labelLeftBranchAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLeftBranchAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLeftBranchAngle.Location = new System.Drawing.Point(670, 320);
            this.labelLeftBranchAngle.Name = "labelLeftBranchAngle";
            this.labelLeftBranchAngle.Size = new System.Drawing.Size(311, 40);
            this.labelLeftBranchAngle.TabIndex = 13;
            this.labelLeftBranchAngle.Text = "Left branch angle:";
            this.labelLeftBranchAngle.UseCompatibleTextRendering = true;
            this.labelLeftBranchAngle.Visible = false;
            // 
            // labelLengthRatio
            // 
            this.labelLengthRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLengthRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLengthRatio.Location = new System.Drawing.Point(670, 214);
            this.labelLengthRatio.Name = "labelLengthRatio";
            this.labelLengthRatio.Size = new System.Drawing.Size(311, 40);
            this.labelLengthRatio.TabIndex = 11;
            this.labelLengthRatio.Text = "Length ratio:";
            this.labelLengthRatio.Visible = false;
            // 
            // labelLayersDistance
            // 
            this.labelLayersDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLayersDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLayersDistance.Location = new System.Drawing.Point(675, 516);
            this.labelLayersDistance.Name = "labelLayersDistance";
            this.labelLayersDistance.Size = new System.Drawing.Size(311, 80);
            this.labelLayersDistance.TabIndex = 17;
            this.labelLayersDistance.Text = "Distance between layers(px):";
            this.labelLayersDistance.Visible = false;
            // 
            // labelRightBranchAngle
            // 
            this.labelRightBranchAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRightBranchAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRightBranchAngle.Location = new System.Drawing.Point(669, 426);
            this.labelRightBranchAngle.Name = "labelRightBranchAngle";
            this.labelRightBranchAngle.Size = new System.Drawing.Size(311, 40);
            this.labelRightBranchAngle.TabIndex = 15;
            this.labelRightBranchAngle.Text = "Right branch angle:";
            this.labelRightBranchAngle.Visible = false;
            // 
            // buttonRedraw
            // 
            this.buttonRedraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRedraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRedraw.Location = new System.Drawing.Point(12, 599);
            this.buttonRedraw.Name = "buttonRedraw";
            this.buttonRedraw.Size = new System.Drawing.Size(312, 86);
            this.buttonRedraw.TabIndex = 18;
            this.buttonRedraw.Text = "Redraw";
            this.buttonRedraw.UseVisualStyleBackColor = true;
            this.buttonRedraw.Click += new System.EventHandler(this.buttonRedraw_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSave.Location = new System.Drawing.Point(341, 599);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(312, 86);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 571);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // comboBoxZoom
            // 
            this.comboBoxZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZoom.FormattingEnabled = true;
            this.comboBoxZoom.Items.AddRange(new object[] {
            "x2",
            "x3",
            "x5",
            "normal"});
            this.comboBoxZoom.Location = new System.Drawing.Point(670, 165);
            this.comboBoxZoom.Name = "comboBoxZoom";
            this.comboBoxZoom.Size = new System.Drawing.Size(311, 33);
            this.comboBoxZoom.TabIndex = 21;
            this.comboBoxZoom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxDistanceBetweenLayers
            // 
            this.textBoxDistanceBetweenLayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDistanceBetweenLayers.Location = new System.Drawing.Point(674, 599);
            this.textBoxDistanceBetweenLayers.Name = "textBoxDistanceBetweenLayers";
            this.textBoxDistanceBetweenLayers.Size = new System.Drawing.Size(310, 31);
            this.textBoxDistanceBetweenLayers.TabIndex = 22;
            this.textBoxDistanceBetweenLayers.Visible = false;
            // 
            // textBoxLenRatio
            // 
            this.textBoxLenRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLenRatio.Location = new System.Drawing.Point(671, 257);
            this.textBoxLenRatio.Name = "textBoxLenRatio";
            this.textBoxLenRatio.Size = new System.Drawing.Size(310, 31);
            this.textBoxLenRatio.TabIndex = 23;
            this.textBoxLenRatio.Visible = false;
            // 
            // textBoxLeftBranchAngle
            // 
            this.textBoxLeftBranchAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLeftBranchAngle.Location = new System.Drawing.Point(671, 363);
            this.textBoxLeftBranchAngle.Name = "textBoxLeftBranchAngle";
            this.textBoxLeftBranchAngle.Size = new System.Drawing.Size(310, 31);
            this.textBoxLeftBranchAngle.TabIndex = 24;
            this.textBoxLeftBranchAngle.Visible = false;
            // 
            // textBoxRightBranchAngle
            // 
            this.textBoxRightBranchAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRightBranchAngle.Location = new System.Drawing.Point(671, 469);
            this.textBoxRightBranchAngle.Name = "textBoxRightBranchAngle";
            this.textBoxRightBranchAngle.Size = new System.Drawing.Size(310, 31);
            this.textBoxRightBranchAngle.TabIndex = 25;
            this.textBoxRightBranchAngle.Visible = false;
            // 
            // FractalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 697);
            this.Controls.Add(this.textBoxRightBranchAngle);
            this.Controls.Add(this.textBoxLeftBranchAngle);
            this.Controls.Add(this.textBoxLenRatio);
            this.Controls.Add(this.textBoxDistanceBetweenLayers);
            this.Controls.Add(this.comboBoxZoom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRedraw);
            this.Controls.Add(this.labelLayersDistance);
            this.Controls.Add(this.labelRightBranchAngle);
            this.Controls.Add(this.labelLeftBranchAngle);
            this.Controls.Add(this.labelLengthRatio);
            this.Controls.Add(this.labelZoom);
            this.Controls.Add(this.labelRecursionCurrent);
            this.Controls.Add(this.maskedTextBoxRecursionCurrent);
            this.Controls.Add(this.buttonQuit);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "FractalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FractalApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseForm);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRecursionCurrent;
        private System.Windows.Forms.Label labelRecursionCurrent;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.Label labelLeftBranchAngle;
        private System.Windows.Forms.Label labelLengthRatio;
        private System.Windows.Forms.Label labelLayersDistance;
        private System.Windows.Forms.Label labelRightBranchAngle;
        private System.Windows.Forms.Button buttonRedraw;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxZoom;
        private System.Windows.Forms.TextBox textBoxDistanceBetweenLayers;
        private TextBox textBoxLenRatio;
        private TextBox textBoxLeftBranchAngle;
        private TextBox textBoxRightBranchAngle;
    }
}

