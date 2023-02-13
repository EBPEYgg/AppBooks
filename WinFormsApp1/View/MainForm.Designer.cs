namespace WinFormsApp1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EnumsPage = new System.Windows.Forms.TabPage();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumerationLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ClassesPage = new System.Windows.Forms.TabPage();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LenghtTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.ResultParsingLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.FuckButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.EnumsPage.SuspendLayout();
            this.ClassesPage.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EnumsPage);
            this.tabControl1.Controls.Add(this.ClassesPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 424);
            this.tabControl1.TabIndex = 0;
            // 
            // EnumsPage
            // 
            this.EnumsPage.Controls.Add(this.IntValueLabel);
            this.EnumsPage.Controls.Add(this.ChooseValueLabel);
            this.EnumsPage.Controls.Add(this.ChooseEnumerationLabel);
            this.EnumsPage.Controls.Add(this.ValueTextBox);
            this.EnumsPage.Controls.Add(this.ValuesListBox);
            this.EnumsPage.Controls.Add(this.EnumsListBox);
            this.EnumsPage.Location = new System.Drawing.Point(4, 29);
            this.EnumsPage.Name = "EnumsPage";
            this.EnumsPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsPage.Size = new System.Drawing.Size(786, 391);
            this.EnumsPage.TabIndex = 0;
            this.EnumsPage.Text = "Enums";
            this.EnumsPage.UseVisualStyleBackColor = true;
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
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(409, 31);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(125, 27);
            this.ValueTextBox.TabIndex = 2;
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
            this.ClassesPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesPage.Location = new System.Drawing.Point(4, 29);
            this.ClassesPage.Name = "ClassesPage";
            this.ClassesPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesPage.Size = new System.Drawing.Size(778, 384);
            this.ClassesPage.TabIndex = 1;
            this.ClassesPage.Text = "Classes";
            this.ClassesPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.listBox1);
            this.RectanglesGroupBox.Controls.Add(this.FindButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LenghtTextBox);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.LenghtLabel);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(6, 6);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(766, 372);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(24, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 244);
            this.listBox1.TabIndex = 7;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(222, 248);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(125, 29);
            this.FindButton.TabIndex = 6;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(222, 164);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(125, 27);
            this.ColorTextBox.TabIndex = 5;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(222, 111);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(125, 27);
            this.WidthTextBox.TabIndex = 4;
            // 
            // LenghtTextBox
            // 
            this.LenghtTextBox.Location = new System.Drawing.Point(222, 58);
            this.LenghtTextBox.Name = "LenghtTextBox";
            this.LenghtTextBox.Size = new System.Drawing.Size(125, 27);
            this.LenghtTextBox.TabIndex = 3;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(222, 141);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(48, 20);
            this.ColorLabel.TabIndex = 2;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(222, 88);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(52, 20);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "Width:";
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Location = new System.Drawing.Point(222, 35);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(57, 20);
            this.LenghtLabel.TabIndex = 0;
            this.LenghtLabel.Text = "Lenght:";
            // 
            // ParseTextBox
            // 
            this.ParseTextBox.Location = new System.Drawing.Point(10, 39);
            this.ParseTextBox.Name = "ParseTextBox";
            this.ParseTextBox.Size = new System.Drawing.Size(224, 27);
            this.ParseTextBox.TabIndex = 8;
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
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.tabControl1);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(800, 450);
            this.EnumerationsGroupBox.TabIndex = 1;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.ResultParsingLabel);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(12, 470);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(395, 120);
            this.WeekdayParsingGroupBox.TabIndex = 9;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.FuckButton);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(422, 470);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(390, 120);
            this.SeasonHandleGroupBox.TabIndex = 10;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season handle";
            // 
            // FuckButton
            // 
            this.FuckButton.Location = new System.Drawing.Point(11, 78);
            this.FuckButton.Name = "FuckButton";
            this.FuckButton.Size = new System.Drawing.Size(251, 29);
            this.FuckButton.TabIndex = 2;
            this.FuckButton.Text = "Fuck go back!";
            this.FuckButton.UseVisualStyleBackColor = true;
            this.FuckButton.Visible = false;
            this.FuckButton.Click += new System.EventHandler(this.FuckButton_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.SeasonHandleGroupBox);
            this.Controls.Add(this.WeekdayParsingGroupBox);
            this.Controls.Add(this.EnumerationsGroupBox);
            this.Name = "MainForm";
            this.Text = "My app";
            this.tabControl1.ResumeLayout(false);
            this.EnumsPage.ResumeLayout(false);
            this.EnumsPage.PerformLayout();
            this.ClassesPage.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage EnumsPage;
        private Label IntValueLabel;
        private Label ChooseValueLabel;
        private Label ChooseEnumerationLabel;
        private TextBox ValueTextBox;
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
        private Button FuckButton;
        private TabPage ClassesPage;
        private GroupBox RectanglesGroupBox;
        private TextBox ColorTextBox;
        private TextBox WidthTextBox;
        private TextBox LenghtTextBox;
        private Label ColorLabel;
        private Label WidthLabel;
        private Label LenghtLabel;
        private ListBox listBox1;
        private Button FindButton;
    }
}