﻿namespace Programming
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
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumerationLabel = new System.Windows.Forms.Label();
            this.ValueIntTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ClassesPage = new System.Windows.Forms.TabPage();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.ParseTextBox = new System.Windows.Forms.TextBox();
            this.ResultParsingLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.AppTabControl.SuspendLayout();
            this.EnumsPage.SuspendLayout();
            this.ClassesPage.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppTabControl
            // 
            this.AppTabControl.Controls.Add(this.EnumsPage);
            this.AppTabControl.Controls.Add(this.ClassesPage);
            this.AppTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppTabControl.Location = new System.Drawing.Point(3, 23);
            this.AppTabControl.Name = "AppTabControl";
            this.AppTabControl.SelectedIndex = 0;
            this.AppTabControl.Size = new System.Drawing.Size(794, 424);
            this.AppTabControl.TabIndex = 0;
            // 
            // EnumsPage
            // 
            this.EnumsPage.Controls.Add(this.IntValueLabel);
            this.EnumsPage.Controls.Add(this.ChooseValueLabel);
            this.EnumsPage.Controls.Add(this.ChooseEnumerationLabel);
            this.EnumsPage.Controls.Add(this.ValueIntTextBox);
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
            this.ClassesPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesPage.Location = new System.Drawing.Point(4, 29);
            this.ClassesPage.Name = "ClassesPage";
            this.ClassesPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesPage.Size = new System.Drawing.Size(786, 391);
            this.ClassesPage.TabIndex = 1;
            this.ClassesPage.Text = "Classes";
            this.ClassesPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Controls.Add(this.FindButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthLabel);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(6, 6);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(766, 372);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Items.AddRange(new object[] {
            "Rectangle 1",
            "Rectangle 2",
            "Rectangle 3",
            "Rectangle 4",
            "Rectangle 5"});
            this.RectanglesListBox.Location = new System.Drawing.Point(24, 35);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(177, 244);
            this.RectanglesListBox.TabIndex = 7;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
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
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(222, 111);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(125, 27);
            this.WidthTextBox.TabIndex = 4;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(222, 58);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(125, 27);
            this.LengthTextBox.TabIndex = 3;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
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
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(222, 35);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(57, 20);
            this.LengthLabel.TabIndex = 0;
            this.LengthLabel.Text = "Length:";
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
            this.EnumerationsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnumerationsGroupBox.Controls.Add(this.AppTabControl);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(800, 450);
            this.EnumerationsGroupBox.TabIndex = 1;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.SeasonHandleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(422, 470);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(390, 120);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 603);
            this.Controls.Add(this.SeasonHandleGroupBox);
            this.Controls.Add(this.WeekdayParsingGroupBox);
            this.Controls.Add(this.EnumerationsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 650);
            this.Name = "MainForm";
            this.Text = "I ❤ programming";
            this.AppTabControl.ResumeLayout(false);
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
        private Button FindButton;
    }
}