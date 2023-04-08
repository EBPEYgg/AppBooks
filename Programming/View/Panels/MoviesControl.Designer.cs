namespace Programming.View
{
    partial class MoviesControl
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
            this.FilmsGroupBox = new System.Windows.Forms.GroupBox();
            this.FilmWithMaxRatingLabel = new System.Windows.Forms.Label();
            this.FindRatingButton = new System.Windows.Forms.Button();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.FilmsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilmsGroupBox
            // 
            this.FilmsGroupBox.Controls.Add(this.FilmWithMaxRatingLabel);
            this.FilmsGroupBox.Controls.Add(this.FindRatingButton);
            this.FilmsGroupBox.Controls.Add(this.RatingLabel);
            this.FilmsGroupBox.Controls.Add(this.GenreLabel);
            this.FilmsGroupBox.Controls.Add(this.YearLabel);
            this.FilmsGroupBox.Controls.Add(this.TimeLabel);
            this.FilmsGroupBox.Controls.Add(this.RatingTextBox);
            this.FilmsGroupBox.Controls.Add(this.GenreTextBox);
            this.FilmsGroupBox.Controls.Add(this.YearTextBox);
            this.FilmsGroupBox.Controls.Add(this.TimeTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmsListBox);
            this.FilmsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Size = new System.Drawing.Size(384, 350);
            this.FilmsGroupBox.TabIndex = 2;
            this.FilmsGroupBox.TabStop = false;
            this.FilmsGroupBox.Text = "Films";
            // 
            // FilmWithMaxRatingLabel
            // 
            this.FilmWithMaxRatingLabel.AutoSize = true;
            this.FilmWithMaxRatingLabel.Location = new System.Drawing.Point(25, 317);
            this.FilmWithMaxRatingLabel.Name = "FilmWithMaxRatingLabel";
            this.FilmWithMaxRatingLabel.Size = new System.Drawing.Size(175, 20);
            this.FilmWithMaxRatingLabel.TabIndex = 12;
            this.FilmWithMaxRatingLabel.Text = "FilmWithMaxRatingLabel";
            this.FilmWithMaxRatingLabel.Visible = false;
            // 
            // FindRatingButton
            // 
            this.FindRatingButton.Location = new System.Drawing.Point(25, 285);
            this.FindRatingButton.Name = "FindRatingButton";
            this.FindRatingButton.Size = new System.Drawing.Size(177, 29);
            this.FindRatingButton.TabIndex = 11;
            this.FindRatingButton.Text = "Find";
            this.FindRatingButton.UseVisualStyleBackColor = true;
            this.FindRatingButton.Click += new System.EventHandler(this.FindRatingButton_Click);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(224, 194);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(55, 20);
            this.RatingLabel.TabIndex = 10;
            this.RatingLabel.Text = "Rating:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(224, 141);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(51, 20);
            this.GenreLabel.TabIndex = 9;
            this.GenreLabel.Text = "Genre:";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(224, 88);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(40, 20);
            this.YearLabel.TabIndex = 8;
            this.YearLabel.Text = "Year:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(224, 35);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(45, 20);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "Time:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(224, 217);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(125, 27);
            this.RatingTextBox.TabIndex = 6;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(224, 164);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(125, 27);
            this.GenreTextBox.TabIndex = 5;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(224, 111);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(125, 27);
            this.YearTextBox.TabIndex = 4;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(224, 58);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(125, 27);
            this.TimeTextBox.TabIndex = 3;
            this.TimeTextBox.TextChanged += new System.EventHandler(this.TimeTextBox_TextChanged);
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.HorizontalScrollbar = true;
            this.FilmsListBox.ItemHeight = 20;
            this.FilmsListBox.Location = new System.Drawing.Point(25, 35);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(177, 244);
            this.FilmsListBox.TabIndex = 2;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilmsGroupBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(384, 350);
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox FilmsGroupBox;
        private Label FilmWithMaxRatingLabel;
        private Button FindRatingButton;
        private Label RatingLabel;
        private Label GenreLabel;
        private Label YearLabel;
        private Label TimeLabel;
        private TextBox RatingTextBox;
        private TextBox GenreTextBox;
        private TextBox YearTextBox;
        private TextBox TimeTextBox;
        private ListBox FilmsListBox;
    }
}
