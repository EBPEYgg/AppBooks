namespace Programming.View
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            this.DeleteRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.PointYTextBox = new System.Windows.Forms.TextBox();
            this.PointXTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DeleteRectangleButton
            // 
            this.DeleteRectangleButton.FlatAppearance.BorderSize = 0;
            this.DeleteRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRectangleButton.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRectangleButton.Image")));
            this.DeleteRectangleButton.Location = new System.Drawing.Point(172, 239);
            this.DeleteRectangleButton.Name = "DeleteRectangleButton";
            this.DeleteRectangleButton.Size = new System.Drawing.Size(140, 40);
            this.DeleteRectangleButton.TabIndex = 31;
            this.DeleteRectangleButton.UseVisualStyleBackColor = false;
            this.DeleteRectangleButton.Click += new System.EventHandler(this.PanelDeleteRectangleButton_Click);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("AddRectangleButton.Image")));
            this.AddRectangleButton.Location = new System.Drawing.Point(11, 239);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(155, 40);
            this.AddRectangleButton.TabIndex = 30;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.PanelAddRectangleButton_Click);
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.AutoSize = true;
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(351, 6);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(425, 498);
            this.CanvasPanel.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(124, 470);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(125, 27);
            this.HeightTextBox.TabIndex = 23;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.PanelHeightTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(124, 437);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(125, 27);
            this.WidthTextBox.TabIndex = 22;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.PanelWidthTextBox_TextChanged);
            // 
            // PointYTextBox
            // 
            this.PointYTextBox.Location = new System.Drawing.Point(124, 404);
            this.PointYTextBox.Name = "PointYTextBox";
            this.PointYTextBox.Size = new System.Drawing.Size(125, 27);
            this.PointYTextBox.TabIndex = 21;
            this.PointYTextBox.TextChanged += new System.EventHandler(this.PanelYTextBox_TextChanged);
            // 
            // PointXTextBox
            // 
            this.PointXTextBox.Location = new System.Drawing.Point(124, 371);
            this.PointXTextBox.Name = "PointXTextBox";
            this.PointXTextBox.Size = new System.Drawing.Size(125, 27);
            this.PointXTextBox.TabIndex = 20;
            this.PointXTextBox.TextChanged += new System.EventHandler(this.PanelXTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Enabled = false;
            this.IdTextBox.Location = new System.Drawing.Point(124, 338);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(125, 27);
            this.IdTextBox.TabIndex = 19;
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(27, 315);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(139, 20);
            this.SelectedRectangleLabel.TabIndex = 18;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(11, 6);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(84, 20);
            this.RectanglesLabel.TabIndex = 17;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Location = new System.Drawing.Point(11, 29);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(301, 204);
            this.RectanglesListBox.TabIndex = 16;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.PanelRectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeleteRectangleButton);
            this.Controls.Add(this.AddRectangleButton);
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.PointYTextBox);
            this.Controls.Add(this.PointXTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.RectanglesLabel);
            this.Controls.Add(this.RectanglesListBox);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(786, 510);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DeleteRectangleButton;
        private Button AddRectangleButton;
        private System.Windows.Forms.Panel CanvasPanel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox HeightTextBox;
        private TextBox WidthTextBox;
        private TextBox PointYTextBox;
        private TextBox PointXTextBox;
        private TextBox IdTextBox;
        private Label SelectedRectangleLabel;
        private Label RectanglesLabel;
        private ListBox RectanglesListBox;
    }
}
