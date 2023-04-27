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
            this.SaveBookButton = new System.Windows.Forms.Button();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.SelectedBookGroupBox = new System.Windows.Forms.GroupBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.PageLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.PageTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.BooksControlTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BooksGroupBox.SuspendLayout();
            this.SelectedBookGroupBox.SuspendLayout();
            this.BooksControlTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BooksGroupBox
            // 
            this.BooksGroupBox.Controls.Add(this.SaveBookButton);
            this.BooksGroupBox.Controls.Add(this.DeleteBookButton);
            this.BooksGroupBox.Controls.Add(this.AddBookButton);
            this.BooksGroupBox.Controls.Add(this.BooksListBox);
            this.BooksGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BooksGroupBox.Location = new System.Drawing.Point(3, 3);
            this.BooksGroupBox.Name = "BooksGroupBox";
            this.BooksGroupBox.Size = new System.Drawing.Size(354, 517);
            this.BooksGroupBox.TabIndex = 0;
            this.BooksGroupBox.TabStop = false;
            this.BooksGroupBox.Text = "Books";
            // 
            // SaveBookButton
            // 
            this.SaveBookButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveBookButton.FlatAppearance.BorderSize = 0;
            this.SaveBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBookButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveBookButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveBookButton.Image")));
            this.SaveBookButton.Location = new System.Drawing.Point(154, 460);
            this.SaveBookButton.Name = "SaveBookButton";
            this.SaveBookButton.Size = new System.Drawing.Size(48, 48);
            this.SaveBookButton.TabIndex = 2;
            this.SaveBookButton.UseVisualStyleBackColor = true;
            this.SaveBookButton.Click += new System.EventHandler(this.SaveBookButton_Click);
            // 
            // DeleteBookButton
            // 
            this.DeleteBookButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteBookButton.FlatAppearance.BorderSize = 0;
            this.DeleteBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBookButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBookButton.Image")));
            this.DeleteBookButton.Location = new System.Drawing.Point(289, 460);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(48, 48);
            this.DeleteBookButton.TabIndex = 3;
            this.DeleteBookButton.UseVisualStyleBackColor = true;
            this.DeleteBookButton.Click += new System.EventHandler(this.DeleteBookButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddBookButton.BackColor = System.Drawing.Color.Transparent;
            this.AddBookButton.FlatAppearance.BorderSize = 0;
            this.AddBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBookButton.Image = ((System.Drawing.Image)(resources.GetObject("AddBookButton.Image")));
            this.AddBookButton.Location = new System.Drawing.Point(17, 459);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(50, 50);
            this.AddBookButton.TabIndex = 1;
            this.AddBookButton.UseVisualStyleBackColor = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // BooksListBox
            // 
            this.BooksListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.HorizontalScrollbar = true;
            this.BooksListBox.ItemHeight = 20;
            this.BooksListBox.Location = new System.Drawing.Point(6, 25);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(337, 424);
            this.BooksListBox.TabIndex = 0;
            this.BooksListBox.SelectedIndexChanged += new System.EventHandler(this.BooksListBox_SelectedIndexChanged);
            // 
            // SelectedBookGroupBox
            // 
            this.SelectedBookGroupBox.Controls.Add(this.GenreLabel);
            this.SelectedBookGroupBox.Controls.Add(this.PageLabel);
            this.SelectedBookGroupBox.Controls.Add(this.AuthorLabel);
            this.SelectedBookGroupBox.Controls.Add(this.YearLabel);
            this.SelectedBookGroupBox.Controls.Add(this.NameLabel);
            this.SelectedBookGroupBox.Controls.Add(this.GenreComboBox);
            this.SelectedBookGroupBox.Controls.Add(this.PageTextBox);
            this.SelectedBookGroupBox.Controls.Add(this.AuthorTextBox);
            this.SelectedBookGroupBox.Controls.Add(this.YearTextBox);
            this.SelectedBookGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedBookGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedBookGroupBox.Location = new System.Drawing.Point(363, 3);
            this.SelectedBookGroupBox.Name = "SelectedBookGroupBox";
            this.SelectedBookGroupBox.Size = new System.Drawing.Size(354, 517);
            this.SelectedBookGroupBox.TabIndex = 1;
            this.SelectedBookGroupBox.TabStop = false;
            this.SelectedBookGroupBox.Text = "Selected Book";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(98, 188);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(51, 20);
            this.GenreLabel.TabIndex = 9;
            this.GenreLabel.Text = "Жанр:";
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(27, 149);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(122, 20);
            this.PageLabel.TabIndex = 8;
            this.PageLabel.Text = "Кол-во страниц:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(95, 110);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(54, 20);
            this.AuthorLabel.TabIndex = 7;
            this.AuthorLabel.Text = "Автор:";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(52, 71);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(97, 20);
            this.YearLabel.TabIndex = 6;
            this.YearLabel.Text = "Год выпуска:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(25, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(124, 20);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Название книги:";
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(155, 185);
            this.GenreComboBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(154, 28);
            this.GenreComboBox.TabIndex = 4;
            this.GenreComboBox.SelectedIndexChanged += new System.EventHandler(this.GenreComboBox_SelectedIndexChanged);
            // 
            // PageTextBox
            // 
            this.PageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageTextBox.Location = new System.Drawing.Point(155, 146);
            this.PageTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.PageTextBox.Name = "PageTextBox";
            this.PageTextBox.Size = new System.Drawing.Size(154, 27);
            this.PageTextBox.TabIndex = 3;
            this.PageTextBox.TextChanged += new System.EventHandler(this.PageTextBox_TextChanged);
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorTextBox.Location = new System.Drawing.Point(155, 107);
            this.AuthorTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(154, 27);
            this.AuthorTextBox.TabIndex = 2;
            this.AuthorTextBox.TextChanged += new System.EventHandler(this.AuthorTextBox_TextChanged);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YearTextBox.Location = new System.Drawing.Point(155, 68);
            this.YearTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(154, 27);
            this.YearTextBox.TabIndex = 1;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(155, 29);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(154, 27);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // BooksControlTableLayoutPanel
            // 
            this.BooksControlTableLayoutPanel.ColumnCount = 2;
            this.BooksControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BooksControlTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BooksControlTableLayoutPanel.Controls.Add(this.BooksGroupBox, 0, 0);
            this.BooksControlTableLayoutPanel.Controls.Add(this.SelectedBookGroupBox, 1, 0);
            this.BooksControlTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BooksControlTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.BooksControlTableLayoutPanel.Name = "BooksControlTableLayoutPanel";
            this.BooksControlTableLayoutPanel.RowCount = 1;
            this.BooksControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BooksControlTableLayoutPanel.Size = new System.Drawing.Size(720, 523);
            this.BooksControlTableLayoutPanel.TabIndex = 2;
            // 
            // BooksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BooksControlTableLayoutPanel);
            this.Name = "BooksControl";
            this.Size = new System.Drawing.Size(720, 523);
            this.BooksGroupBox.ResumeLayout(false);
            this.SelectedBookGroupBox.ResumeLayout(false);
            this.SelectedBookGroupBox.PerformLayout();
            this.BooksControlTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox BooksGroupBox;
        private ListBox BooksListBox;
        private Button AddBookButton;
        private Button DeleteBookButton;
        private Button SaveBookButton;
        private GroupBox SelectedBookGroupBox;
        private Label GenreLabel;
        private Label PageLabel;
        private Label AuthorLabel;
        private Label YearLabel;
        private Label NameLabel;
        private ComboBox GenreComboBox;
        private TextBox PageTextBox;
        private TextBox AuthorTextBox;
        private TextBox YearTextBox;
        private TextBox NameTextBox;
        private TableLayoutPanel BooksControlTableLayoutPanel;
    }
}
