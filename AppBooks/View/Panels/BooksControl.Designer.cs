﻿namespace AppBooks.View.Panels
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksControl));
            this.BooksGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.SaveBookButton = new System.Windows.Forms.Button();
            this.SelectedBookGroupBox = new System.Windows.Forms.GroupBox();
            this.ApplyButton = new System.Windows.Forms.Button();
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
            this.ErrorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BooksGroupBox.SuspendLayout();
            this.SelectedBookGroupBox.SuspendLayout();
            this.BooksControlTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BooksGroupBox
            // 
            this.BooksGroupBox.Controls.Add(this.DeleteBookButton);
            this.BooksGroupBox.Controls.Add(this.AddBookButton);
            this.BooksGroupBox.Controls.Add(this.EditButton);
            this.BooksGroupBox.Controls.Add(this.BooksListBox);
            this.BooksGroupBox.Controls.Add(this.SaveBookButton);
            this.BooksGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BooksGroupBox.Location = new System.Drawing.Point(3, 2);
            this.BooksGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BooksGroupBox.Name = "BooksGroupBox";
            this.BooksGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BooksGroupBox.Size = new System.Drawing.Size(309, 388);
            this.BooksGroupBox.TabIndex = 0;
            this.BooksGroupBox.TabStop = false;
            this.BooksGroupBox.Text = "Books";
            // 
            // DeleteBookButton
            // 
            this.DeleteBookButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteBookButton.AutoSize = true;
            this.DeleteBookButton.FlatAppearance.BorderSize = 0;
            this.DeleteBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBookButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBookButton.Image")));
            this.DeleteBookButton.Location = new System.Drawing.Point(243, 346);
            this.DeleteBookButton.Margin = new System.Windows.Forms.Padding(18, 2, 3, 2);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(38, 38);
            this.DeleteBookButton.TabIndex = 4;
            this.DeleteBookButton.UseVisualStyleBackColor = true;
            this.DeleteBookButton.Click += new System.EventHandler(this.DeleteBookButton_Click);
            // 
            // AddBookButton
            // 
            this.AddBookButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddBookButton.AutoSize = true;
            this.AddBookButton.BackColor = System.Drawing.Color.Transparent;
            this.AddBookButton.FlatAppearance.BorderSize = 0;
            this.AddBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBookButton.Image = ((System.Drawing.Image)(resources.GetObject("AddBookButton.Image")));
            this.AddBookButton.Location = new System.Drawing.Point(21, 346);
            this.AddBookButton.Margin = new System.Windows.Forms.Padding(3, 2, 18, 2);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(38, 38);
            this.AddBookButton.TabIndex = 1;
            this.AddBookButton.UseVisualStyleBackColor = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditButton.AutoSize = true;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.Location = new System.Drawing.Point(169, 346);
            this.EditButton.Margin = new System.Windows.Forms.Padding(18, 2, 18, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(38, 38);
            this.EditButton.TabIndex = 3;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // BooksListBox
            // 
            this.BooksListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.HorizontalScrollbar = true;
            this.BooksListBox.ItemHeight = 15;
            this.BooksListBox.Location = new System.Drawing.Point(5, 19);
            this.BooksListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(294, 319);
            this.BooksListBox.TabIndex = 0;
            this.BooksListBox.SelectedIndexChanged += new System.EventHandler(this.BooksListBox_SelectedIndexChanged);
            // 
            // SaveBookButton
            // 
            this.SaveBookButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveBookButton.AutoSize = true;
            this.SaveBookButton.FlatAppearance.BorderSize = 0;
            this.SaveBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBookButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveBookButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveBookButton.Image")));
            this.SaveBookButton.Location = new System.Drawing.Point(95, 346);
            this.SaveBookButton.Margin = new System.Windows.Forms.Padding(18, 2, 18, 2);
            this.SaveBookButton.Name = "SaveBookButton";
            this.SaveBookButton.Size = new System.Drawing.Size(38, 38);
            this.SaveBookButton.TabIndex = 2;
            this.SaveBookButton.UseVisualStyleBackColor = true;
            this.SaveBookButton.Click += new System.EventHandler(this.SaveBookButton_Click);
            // 
            // SelectedBookGroupBox
            // 
            this.SelectedBookGroupBox.Controls.Add(this.ApplyButton);
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
            this.SelectedBookGroupBox.Location = new System.Drawing.Point(318, 2);
            this.SelectedBookGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectedBookGroupBox.Name = "SelectedBookGroupBox";
            this.SelectedBookGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectedBookGroupBox.Size = new System.Drawing.Size(309, 388);
            this.SelectedBookGroupBox.TabIndex = 1;
            this.SelectedBookGroupBox.TabStop = false;
            this.SelectedBookGroupBox.Text = "Selected Book";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyButton.Location = new System.Drawing.Point(136, 166);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(134, 22);
            this.ApplyButton.TabIndex = 10;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Visible = false;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(89, 142);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(41, 15);
            this.GenreLabel.TabIndex = 9;
            this.GenreLabel.Text = "Жанр:";
            // 
            // PageLabel
            // 
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(33, 113);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(97, 15);
            this.PageLabel.TabIndex = 8;
            this.PageLabel.Text = "Кол-во страниц:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(87, 83);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(43, 15);
            this.AuthorLabel.TabIndex = 7;
            this.AuthorLabel.Text = "Автор:";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(52, 54);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(78, 15);
            this.YearLabel.TabIndex = 6;
            this.YearLabel.Text = "Год выпуска:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(33, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(97, 15);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Название книги:";
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenreComboBox.BackColor = System.Drawing.Color.White;
            this.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBox.Enabled = false;
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(136, 139);
            this.GenreComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenreComboBox.MaxDropDownItems = 6;
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(134, 23);
            this.GenreComboBox.TabIndex = 9;
            this.GenreComboBox.SelectedIndexChanged += new System.EventHandler(this.GenreComboBox_SelectedIndexChanged);
            // 
            // PageTextBox
            // 
            this.PageTextBox.AccessibleDescription = "Некорректное число.";
            this.PageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageTextBox.BackColor = System.Drawing.Color.White;
            this.PageTextBox.Enabled = false;
            this.PageTextBox.Location = new System.Drawing.Point(136, 110);
            this.PageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PageTextBox.Name = "PageTextBox";
            this.PageTextBox.Size = new System.Drawing.Size(134, 23);
            this.PageTextBox.TabIndex = 8;
            this.PageTextBox.TextChanged += new System.EventHandler(this.PageTextBox_TextChanged);
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.AccessibleDescription = "Некорректное имя автора.";
            this.AuthorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorTextBox.BackColor = System.Drawing.Color.White;
            this.AuthorTextBox.Enabled = false;
            this.AuthorTextBox.Location = new System.Drawing.Point(136, 80);
            this.AuthorTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(134, 23);
            this.AuthorTextBox.TabIndex = 7;
            this.AuthorTextBox.TextChanged += new System.EventHandler(this.AuthorTextBox_TextChanged);
            // 
            // YearTextBox
            // 
            this.YearTextBox.AccessibleDescription = "Некорректное число.";
            this.YearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YearTextBox.BackColor = System.Drawing.Color.White;
            this.YearTextBox.Enabled = false;
            this.YearTextBox.Location = new System.Drawing.Point(136, 51);
            this.YearTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(134, 23);
            this.YearTextBox.TabIndex = 6;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.AccessibleDescription = "Некорректное название книги.";
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.BackColor = System.Drawing.Color.White;
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Location = new System.Drawing.Point(136, 22);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(134, 23);
            this.NameTextBox.TabIndex = 5;
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
            this.BooksControlTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BooksControlTableLayoutPanel.Name = "BooksControlTableLayoutPanel";
            this.BooksControlTableLayoutPanel.RowCount = 1;
            this.BooksControlTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BooksControlTableLayoutPanel.Size = new System.Drawing.Size(630, 392);
            this.BooksControlTableLayoutPanel.TabIndex = 2;
            // 
            // ErrorToolTip
            // 
            this.ErrorToolTip.AutoPopDelay = 5000;
            this.ErrorToolTip.InitialDelay = 100;
            this.ErrorToolTip.ReshowDelay = 100;
            this.ErrorToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.ErrorToolTip.ToolTipTitle = "Ошибка ввода";
            // 
            // BooksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BooksControlTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BooksControl";
            this.Size = new System.Drawing.Size(630, 392);
            this.BooksGroupBox.ResumeLayout(false);
            this.BooksGroupBox.PerformLayout();
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
        private Button EditButton;
        private Button ApplyButton;
        private ToolTip ErrorToolTip;
    }
}
