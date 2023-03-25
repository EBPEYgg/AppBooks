namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AppTabControl = new System.Windows.Forms.TabControl();
            this.EnumsPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ResultParsingLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumerationLabel = new System.Windows.Forms.Label();
            this.ValueIntTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ClassesPage = new System.Windows.Forms.TabPage();
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
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.PanelDeleteRectangleButton = new System.Windows.Forms.Button();
            this.PanelAddRectangleButton = new System.Windows.Forms.Button();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelLengthTextBox = new System.Windows.Forms.TextBox();
            this.PanelWidthTextBox = new System.Windows.Forms.TextBox();
            this.PanelYTextBox = new System.Windows.Forms.TextBox();
            this.PanelXTextBox = new System.Windows.Forms.TextBox();
            this.PanelIdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.PanelRectanglesListBox = new System.Windows.Forms.ListBox();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.AppTabControl.SuspendLayout();
            this.EnumsPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.ClassesPage.SuspendLayout();
            this.FilmsGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppTabControl
            // 
            this.AppTabControl.Controls.Add(this.EnumsPage);
            this.AppTabControl.Controls.Add(this.ClassesPage);
            this.AppTabControl.Controls.Add(this.RectanglesTabPage);
            this.AppTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppTabControl.Location = new System.Drawing.Point(3, 23);
            this.AppTabControl.Name = "AppTabControl";
            this.AppTabControl.SelectedIndex = 0;
            this.AppTabControl.Size = new System.Drawing.Size(794, 543);
            this.AppTabControl.TabIndex = 0;
            // 
            // EnumsPage
            // 
            this.EnumsPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumsPage.Controls.Add(this.IntValueLabel);
            this.EnumsPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsPage.Controls.Add(this.ChooseValueLabel);
            this.EnumsPage.Controls.Add(this.ChooseEnumerationLabel);
            this.EnumsPage.Controls.Add(this.ValueIntTextBox);
            this.EnumsPage.Controls.Add(this.ValuesListBox);
            this.EnumsPage.Controls.Add(this.EnumsListBox);
            this.EnumsPage.Location = new System.Drawing.Point(4, 29);
            this.EnumsPage.Name = "EnumsPage";
            this.EnumsPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsPage.Size = new System.Drawing.Size(786, 510);
            this.EnumsPage.TabIndex = 0;
            this.EnumsPage.Text = "Enums";
            this.EnumsPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(393, 390);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(390, 110);
            this.SeasonHandleGroupBox.TabIndex = 10;
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
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(168, 38);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(94, 29);
            this.SeasonButton.TabIndex = 0;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(409, 8);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(68, 20);
            this.IntValueLabel.TabIndex = 5;
            this.IntValueLabel.Text = "int value:";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.ResultParsingLabel);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(0, 390);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(390, 110);
            this.WeekdayParsingGroupBox.TabIndex = 9;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.Location = new System.Drawing.Point(10, 39);
            this.ParseTextBox.Name = "ParseTextBox";
            this.ParseTextBox.Size = new System.Drawing.Size(224, 27);
            this.ParseTextBox.TabIndex = 8;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(240, 39);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(88, 29);
            this.ParseButton.TabIndex = 6;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ResultParsingLabel
            // 
            this.ResultParsingLabel.AutoSize = true;
            this.ResultParsingLabel.Location = new System.Drawing.Point(10, 78);
            this.ResultParsingLabel.Name = "ResultParsingLabel";
            this.ResultParsingLabel.Size = new System.Drawing.Size(132, 20);
            this.ResultParsingLabel.TabIndex = 7;
            this.ResultParsingLabel.Text = "ResultParsingLabel";
            this.ResultParsingLabel.Visible = false;
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(214, 8);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(100, 20);
            this.ChooseValueLabel.TabIndex = 4;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ChooseEnumerationLabel
            // 
            this.ChooseEnumerationLabel.AutoSize = true;
            this.ChooseEnumerationLabel.Location = new System.Drawing.Point(18, 8);
            this.ChooseEnumerationLabel.Name = "ChooseEnumerationLabel";
            this.ChooseEnumerationLabel.Size = new System.Drawing.Size(149, 20);
            this.ChooseEnumerationLabel.TabIndex = 3;
            this.ChooseEnumerationLabel.Text = "Choose enumeration:";
            // 
            // ValueIntTextBox
            // 
            this.ValueIntTextBox.Location = new System.Drawing.Point(409, 31);
            this.ValueIntTextBox.Name = "ValueIntTextBox";
            this.ValueIntTextBox.Size = new System.Drawing.Size(125, 27);
            this.ValueIntTextBox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(214, 31);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.ScrollAlwaysVisible = true;
            this.ValuesListBox.Size = new System.Drawing.Size(180, 304);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Location = new System.Drawing.Point(18, 31);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.ScrollAlwaysVisible = true;
            this.EnumsListBox.Size = new System.Drawing.Size(180, 304);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ClassesPage
            // 
            this.ClassesPage.Controls.Add(this.FilmsGroupBox);
            this.ClassesPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesPage.Location = new System.Drawing.Point(4, 29);
            this.ClassesPage.Name = "ClassesPage";
            this.ClassesPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesPage.Size = new System.Drawing.Size(786, 510);
            this.ClassesPage.TabIndex = 1;
            this.ClassesPage.Text = "Classes";
            this.ClassesPage.UseVisualStyleBackColor = true;
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
            this.FilmsGroupBox.Location = new System.Drawing.Point(396, 6);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Size = new System.Drawing.Size(384, 350);
            this.FilmsGroupBox.TabIndex = 1;
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
            this.RectanglesGroupBox.Location = new System.Drawing.Point(6, 6);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(384, 350);
            this.RectanglesGroupBox.TabIndex = 0;
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
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.PanelDeleteRectangleButton);
            this.RectanglesTabPage.Controls.Add(this.PanelAddRectangleButton);
            this.RectanglesTabPage.Controls.Add(this.CanvasPanel);
            this.RectanglesTabPage.Controls.Add(this.label5);
            this.RectanglesTabPage.Controls.Add(this.label4);
            this.RectanglesTabPage.Controls.Add(this.label3);
            this.RectanglesTabPage.Controls.Add(this.label2);
            this.RectanglesTabPage.Controls.Add(this.label1);
            this.RectanglesTabPage.Controls.Add(this.PanelLengthTextBox);
            this.RectanglesTabPage.Controls.Add(this.PanelWidthTextBox);
            this.RectanglesTabPage.Controls.Add(this.PanelYTextBox);
            this.RectanglesTabPage.Controls.Add(this.PanelXTextBox);
            this.RectanglesTabPage.Controls.Add(this.PanelIdTextBox);
            this.RectanglesTabPage.Controls.Add(this.SelectedRectangleLabel);
            this.RectanglesTabPage.Controls.Add(this.RectanglesLabel);
            this.RectanglesTabPage.Controls.Add(this.PanelRectanglesListBox);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 29);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(786, 510);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // PanelDeleteRectangleButton
            // 
            this.PanelDeleteRectangleButton.Location = new System.Drawing.Point(176, 239);
            this.PanelDeleteRectangleButton.Name = "PanelDeleteRectangleButton";
            this.PanelDeleteRectangleButton.Size = new System.Drawing.Size(140, 29);
            this.PanelDeleteRectangleButton.TabIndex = 15;
            this.PanelDeleteRectangleButton.Text = "Удалить";
            this.PanelDeleteRectangleButton.UseVisualStyleBackColor = true;
            // 
            // PanelAddRectangleButton
            // 
            this.PanelAddRectangleButton.Location = new System.Drawing.Point(15, 239);
            this.PanelAddRectangleButton.Name = "PanelAddRectangleButton";
            this.PanelAddRectangleButton.Size = new System.Drawing.Size(155, 29);
            this.PanelAddRectangleButton.TabIndex = 14;
            this.PanelAddRectangleButton.Text = "Добавить";
            this.PanelAddRectangleButton.UseVisualStyleBackColor = true;
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.AutoSize = true;
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(355, 6);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(425, 498);
            this.CanvasPanel.TabIndex = 13;
            this.CanvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasPanel_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            // 
            // PanelLengthTextBox
            // 
            this.PanelLengthTextBox.Location = new System.Drawing.Point(128, 470);
            this.PanelLengthTextBox.Name = "PanelLengthTextBox";
            this.PanelLengthTextBox.Size = new System.Drawing.Size(125, 27);
            this.PanelLengthTextBox.TabIndex = 7;
            // 
            // PanelWidthTextBox
            // 
            this.PanelWidthTextBox.Location = new System.Drawing.Point(128, 437);
            this.PanelWidthTextBox.Name = "PanelWidthTextBox";
            this.PanelWidthTextBox.Size = new System.Drawing.Size(125, 27);
            this.PanelWidthTextBox.TabIndex = 6;
            // 
            // PanelYTextBox
            // 
            this.PanelYTextBox.Location = new System.Drawing.Point(128, 404);
            this.PanelYTextBox.Name = "PanelYTextBox";
            this.PanelYTextBox.Size = new System.Drawing.Size(125, 27);
            this.PanelYTextBox.TabIndex = 5;
            // 
            // PanelXTextBox
            // 
            this.PanelXTextBox.Location = new System.Drawing.Point(128, 371);
            this.PanelXTextBox.Name = "PanelXTextBox";
            this.PanelXTextBox.Size = new System.Drawing.Size(125, 27);
            this.PanelXTextBox.TabIndex = 4;
            // 
            // PanelIdTextBox
            // 
            this.PanelIdTextBox.Location = new System.Drawing.Point(128, 338);
            this.PanelIdTextBox.Name = "PanelIdTextBox";
            this.PanelIdTextBox.Size = new System.Drawing.Size(125, 27);
            this.PanelIdTextBox.TabIndex = 3;
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(31, 315);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(139, 20);
            this.SelectedRectangleLabel.TabIndex = 2;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(15, 6);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(84, 20);
            this.RectanglesLabel.TabIndex = 1;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // PanelRectanglesListBox
            // 
            this.PanelRectanglesListBox.FormattingEnabled = true;
            this.PanelRectanglesListBox.ItemHeight = 20;
            this.PanelRectanglesListBox.Location = new System.Drawing.Point(15, 29);
            this.PanelRectanglesListBox.Name = "PanelRectanglesListBox";
            this.PanelRectanglesListBox.Size = new System.Drawing.Size(301, 204);
            this.PanelRectanglesListBox.TabIndex = 0;
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumerationsGroupBox.AutoSize = true;
            this.EnumerationsGroupBox.Controls.Add(this.AppTabControl);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(800, 569);
            this.EnumerationsGroupBox.TabIndex = 1;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.EnumerationsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 650);
            this.Name = "MainForm";
            this.Text = "I ❤ programming";
            this.AppTabControl.ResumeLayout(false);
            this.EnumsPage.ResumeLayout(false);
            this.EnumsPage.PerformLayout();
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.ClassesPage.ResumeLayout(false);
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.RectanglesTabPage.ResumeLayout(false);
            this.RectanglesTabPage.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl AppTabControl;
        private TabPage EnumsPage;
        private Label IntValueLabel;
        private Label ChooseValueLabel;
        private Label ChooseEnumerationLabel;
        private TextBox ValueIntTextBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label ResultParsingLabel;
        private Button ParseButton;
        private TextBox ParseTextBox;
        private GroupBox EnumerationsGroupBox;
        private GroupBox WeekdayParsingGroupBox;
        private GroupBox SeasonHandleGroupBox;
        private ComboBox SeasonComboBox;
        private Button SeasonButton;
        private TabPage ClassesPage;
        private GroupBox RectanglesGroupBox;
        private TextBox ColorTextBox;
        private TextBox WidthTextBox;
        private TextBox LengthTextBox;
        private Label ColorLabel;
        private Label WidthLabel;
        private Label LengthLabel;
        private ListBox RectanglesListBox;
        private Button FindWidthButton;
        private Label RectangleWithMaxWidthLabel;
        private GroupBox FilmsGroupBox;
        private ListBox FilmsListBox;
        private TextBox GenreTextBox;
        private TextBox YearTextBox;
        private TextBox TimeTextBox;
        private Label RatingLabel;
        private Label GenreLabel;
        private Label YearLabel;
        private Label TimeLabel;
        private TextBox RatingTextBox;
        private Button FindRatingButton;
        private Label FilmWithMaxRatingLabel;
        private Label CenterRectangleLabel;
        private TextBox PointYTextBox;
        private TextBox PointXTextBox;
        private Label PointYLabel;
        private Label PointXLabel;
        private TextBox IdTextBox;
        private Label IdLabel;
        private TabPage RectanglesTabPage;
        private Panel CanvasPanel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox PanelLengthTextBox;
        private TextBox PanelWidthTextBox;
        private TextBox PanelYTextBox;
        private TextBox PanelXTextBox;
        private TextBox PanelIdTextBox;
        private Label SelectedRectangleLabel;
        private Label RectanglesLabel;
        private ListBox PanelRectanglesListBox;
        private Button PanelDeleteRectangleButton;
        private Button PanelAddRectangleButton;
    }
}