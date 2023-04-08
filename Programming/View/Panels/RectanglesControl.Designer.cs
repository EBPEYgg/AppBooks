namespace Programming.View
{
    partial class RectanglesControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PointYLabel = new System.Windows.Forms.Label();
            this.PointXLabel = new System.Windows.Forms.Label();
            this.CenterRectangleLabel = new System.Windows.Forms.Label();
            this.PointYTextBox = new System.Windows.Forms.TextBox();
            this.PointXTextBox = new System.Windows.Forms.TextBox();
            this.RectangleWithMaxWidthLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.FindWidthButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.IdTextBox);
            this.RectanglesGroupBox.Controls.Add(this.IdLabel);
            this.RectanglesGroupBox.Controls.Add(this.PointYLabel);
            this.RectanglesGroupBox.Controls.Add(this.PointXLabel);
            this.RectanglesGroupBox.Controls.Add(this.CenterRectangleLabel);
            this.RectanglesGroupBox.Controls.Add(this.PointYTextBox);
            this.RectanglesGroupBox.Controls.Add(this.PointXTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleWithMaxWidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Controls.Add(this.FindWidthButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(384, 350);
            this.RectanglesGroupBox.TabIndex = 1;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(223, 58);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(125, 27);
            this.IdTextBox.TabIndex = 15;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(225, 35);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 20);
            this.IdLabel.TabIndex = 14;
            this.IdLabel.Text = "ID:";
            // 
            // PointYLabel
            // 
            this.PointYLabel.AutoSize = true;
            this.PointYLabel.Location = new System.Drawing.Point(292, 277);
            this.PointYLabel.Name = "PointYLabel";
            this.PointYLabel.Size = new System.Drawing.Size(20, 20);
            this.PointYLabel.TabIndex = 13;
            this.PointYLabel.Text = "Y:";
            // 
            // PointXLabel
            // 
            this.PointXLabel.AutoSize = true;
            this.PointXLabel.Location = new System.Drawing.Point(223, 277);
            this.PointXLabel.Name = "PointXLabel";
            this.PointXLabel.Size = new System.Drawing.Size(21, 20);
            this.PointXLabel.TabIndex = 12;
            this.PointXLabel.Text = "X:";
            // 
            // CenterRectangleLabel
            // 
            this.CenterRectangleLabel.AutoSize = true;
            this.CenterRectangleLabel.Location = new System.Drawing.Point(225, 247);
            this.CenterRectangleLabel.Name = "CenterRectangleLabel";
            this.CenterRectangleLabel.Size = new System.Drawing.Size(121, 20);
            this.CenterRectangleLabel.TabIndex = 11;
            this.CenterRectangleLabel.Text = "Center rectangle:";
            // 
            // PointYTextBox
            // 
            this.PointYTextBox.Location = new System.Drawing.Point(308, 274);
            this.PointYTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.PointYTextBox.Name = "PointYTextBox";
            this.PointYTextBox.ReadOnly = true;
            this.PointYTextBox.Size = new System.Drawing.Size(40, 27);
            this.PointYTextBox.TabIndex = 10;
            this.PointYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PointXTextBox
            // 
            this.PointXTextBox.Location = new System.Drawing.Point(240, 274);
            this.PointXTextBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.PointXTextBox.Name = "PointXTextBox";
            this.PointXTextBox.ReadOnly = true;
            this.PointXTextBox.Size = new System.Drawing.Size(40, 27);
            this.PointXTextBox.TabIndex = 9;
            this.PointXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RectangleWithMaxWidthLabel
            // 
            this.RectangleWithMaxWidthLabel.AutoSize = true;
            this.RectangleWithMaxWidthLabel.Location = new System.Drawing.Point(24, 317);
            this.RectangleWithMaxWidthLabel.Name = "RectangleWithMaxWidthLabel";
            this.RectangleWithMaxWidthLabel.Size = new System.Drawing.Size(210, 20);
            this.RectangleWithMaxWidthLabel.TabIndex = 8;
            this.RectangleWithMaxWidthLabel.Text = "RectangleWithMaxWidthLabel";
            this.RectangleWithMaxWidthLabel.Visible = false;
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Location = new System.Drawing.Point(24, 35);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(177, 244);
            this.RectanglesListBox.TabIndex = 7;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // FindWidthButton
            // 
            this.FindWidthButton.Location = new System.Drawing.Point(24, 285);
            this.FindWidthButton.Name = "FindWidthButton";
            this.FindWidthButton.Size = new System.Drawing.Size(177, 29);
            this.FindWidthButton.TabIndex = 6;
            this.FindWidthButton.Text = "Find";
            this.FindWidthButton.UseVisualStyleBackColor = true;
            this.FindWidthButton.Click += new System.EventHandler(this.FindWidthButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(223, 217);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(125, 27);
            this.ColorTextBox.TabIndex = 5;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(223, 164);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(125, 27);
            this.WidthTextBox.TabIndex = 4;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(223, 111);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(125, 27);
            this.LengthTextBox.TabIndex = 3;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(223, 194);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(48, 20);
            this.ColorLabel.TabIndex = 2;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(223, 141);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(52, 20);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "Width:";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(223, 88);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(57, 20);
            this.LengthLabel.TabIndex = 0;
            this.LengthLabel.Text = "Length:";
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesGroupBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(384, 350);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private TextBox IdTextBox;
        private Label IdLabel;
        private Label PointYLabel;
        private Label PointXLabel;
        private Label CenterRectangleLabel;
        private TextBox PointYTextBox;
        private TextBox PointXTextBox;
        private Label RectangleWithMaxWidthLabel;
        private ListBox RectanglesListBox;
        private Button FindWidthButton;
        private TextBox ColorTextBox;
        private TextBox WidthTextBox;
        private TextBox LengthTextBox;
        private Label ColorLabel;
        private Label WidthLabel;
        private Label LengthLabel;
    }
}
