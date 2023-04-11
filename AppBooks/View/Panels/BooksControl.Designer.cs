namespace AppBooks.View.Panels
{
    partial class BooksControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksControl));
            this.BooksGroupBox = new System.Windows.Forms.GroupBox();
            this.EditBookButton = new System.Windows.Forms.Button();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.BooksGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BooksGroupBox
            // 
            this.BooksGroupBox.Controls.Add(this.EditBookButton);
            this.BooksGroupBox.Controls.Add(this.DeleteBookButton);
            this.BooksGroupBox.Controls.Add(this.AddBookButton);
            this.BooksGroupBox.Controls.Add(this.BooksListBox);
            this.BooksGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BooksGroupBox.Location = new System.Drawing.Point(0, 0);
            this.BooksGroupBox.Name = "BooksGroupBox";
            this.BooksGroupBox.Size = new System.Drawing.Size(250, 523);
            this.BooksGroupBox.TabIndex = 0;
            this.BooksGroupBox.TabStop = false;
            // 
            // EditBookButton
            // 
            this.EditBookButton.FlatAppearance.BorderSize = 0;
            this.EditBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBookButton.Image = ((System.Drawing.Image)(resources.GetObject("EditBookButton.Image")));
            this.EditBookButton.Location = new System.Drawing.Point(104, 457);
            this.EditBookButton.Name = "EditBookButton";
            this.EditBookButton.Size = new System.Drawing.Size(48, 48);
            this.EditBookButton.TabIndex = 3;
            this.EditBookButton.UseVisualStyleBackColor = true;
            this.EditBookButton.Click += new System.EventHandler(this.EditBookButton_Click);
            // 
            // DeleteBookButton
            // 
            this.DeleteBookButton.FlatAppearance.BorderSize = 0;
            this.DeleteBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBookButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBookButton.Image")));
            this.DeleteBookButton.Location = new System.Drawing.Point(194, 463);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(42, 42);
            this.DeleteBookButton.TabIndex = 2;
            this.DeleteBookButton.UseVisualStyleBackColor = true;
            this.DeleteBookButton.Click += new System.EventHandler(this.DeleteBookButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.BackColor = System.Drawing.Color.Transparent;
            this.AddBookButton.FlatAppearance.BorderSize = 0;
            this.AddBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBookButton.Image = ((System.Drawing.Image)(resources.GetObject("AddBookButton.Image")));
            this.AddBookButton.Location = new System.Drawing.Point(15, 455);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(50, 50);
            this.AddBookButton.TabIndex = 1;
            this.AddBookButton.UseVisualStyleBackColor = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // BooksListBox
            // 
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.ItemHeight = 20;
            this.BooksListBox.Location = new System.Drawing.Point(15, 25);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(221, 424);
            this.BooksListBox.TabIndex = 0;
            this.BooksListBox.SelectedIndexChanged += new System.EventHandler(this.BooksListBox_SelectedIndexChanged);
            // 
            // BooksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BooksGroupBox);
            this.Name = "BooksControl";
            this.Size = new System.Drawing.Size(250, 523);
            this.BooksGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox BooksGroupBox;
        private ListBox BooksListBox;
        private Button AddBookButton;
        private Button DeleteBookButton;
        private Button EditBookButton;
    }
}
