namespace Programming.View
{
    partial class SeasonsControl
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
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(6, 0);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(384, 110);
            this.SeasonHandleGroupBox.TabIndex = 11;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season handle";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(11, 39);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(151, 28);
            this.SeasonComboBox.TabIndex = 1;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(168, 38);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(94, 29);
            this.GoButton.TabIndex = 0;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // SeasonsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonHandleGroupBox);
            this.Name = "SeasonsControl";
            this.Size = new System.Drawing.Size(390, 110);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox SeasonHandleGroupBox;
        private ComboBox SeasonComboBox;
        private Button GoButton;
    }
}
