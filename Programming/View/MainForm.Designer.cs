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
            this.EnumsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.weekdayParsingControl1 = new Programming.View.WeekdayParsingControl();
            this.seasonsControl1 = new Programming.View.SeasonsControl();
            this.allEnumerationsControl1 = new Programming.View.AllEnumerationsControl();
            this.ClassesPage = new System.Windows.Forms.TabPage();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.ClassesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rectanglesControl1 = new Programming.View.RectanglesControl();
            this.moviesControl1 = new Programming.View.MoviesControl();
            this.rectanglesCollisionControl1 = new Programming.View.RectanglesCollisionControl();
            this.AppTabControl.SuspendLayout();
            this.EnumsPage.SuspendLayout();
            this.EnumsTableLayoutPanel.SuspendLayout();
            this.ClassesPage.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.ClassesTableLayoutPanel.SuspendLayout();
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
            this.EnumsPage.Controls.Add(this.EnumsTableLayoutPanel);
            this.EnumsPage.Location = new System.Drawing.Point(4, 29);
            this.EnumsPage.Name = "EnumsPage";
            this.EnumsPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsPage.Size = new System.Drawing.Size(786, 510);
            this.EnumsPage.TabIndex = 0;
            this.EnumsPage.Text = "Enums";
            this.EnumsPage.UseVisualStyleBackColor = true;
            // 
            // EnumsTableLayoutPanel
            // 
            this.EnumsTableLayoutPanel.ColumnCount = 2;
            this.EnumsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EnumsTableLayoutPanel.Controls.Add(this.weekdayParsingControl1, 0, 1);
            this.EnumsTableLayoutPanel.Controls.Add(this.seasonsControl1, 1, 1);
            this.EnumsTableLayoutPanel.Controls.Add(this.allEnumerationsControl1, 0, 0);
            this.EnumsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.EnumsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EnumsTableLayoutPanel.Name = "EnumsTableLayoutPanel";
            this.EnumsTableLayoutPanel.RowCount = 2;
            this.EnumsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EnumsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.EnumsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.EnumsTableLayoutPanel.Size = new System.Drawing.Size(780, 504);
            this.EnumsTableLayoutPanel.TabIndex = 0;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayParsingControl1.Location = new System.Drawing.Point(3, 369);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(384, 132);
            this.weekdayParsingControl1.TabIndex = 0;
            // 
            // seasonsControl1
            // 
            this.seasonsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seasonsControl1.Location = new System.Drawing.Point(393, 369);
            this.seasonsControl1.Name = "seasonsControl1";
            this.seasonsControl1.Size = new System.Drawing.Size(384, 132);
            this.seasonsControl1.TabIndex = 1;
            // 
            // allEnumerationsControl1
            // 
            this.EnumsTableLayoutPanel.SetColumnSpan(this.allEnumerationsControl1, 2);
            this.allEnumerationsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allEnumerationsControl1.Location = new System.Drawing.Point(3, 3);
            this.allEnumerationsControl1.Name = "allEnumerationsControl1";
            this.allEnumerationsControl1.Size = new System.Drawing.Size(774, 360);
            this.allEnumerationsControl1.TabIndex = 2;
            // 
            // ClassesPage
            // 
            this.ClassesPage.Controls.Add(this.ClassesTableLayoutPanel);
            this.ClassesPage.Location = new System.Drawing.Point(4, 29);
            this.ClassesPage.Name = "ClassesPage";
            this.ClassesPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesPage.Size = new System.Drawing.Size(786, 510);
            this.ClassesPage.TabIndex = 1;
            this.ClassesPage.Text = "Classes";
            this.ClassesPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 29);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(786, 510);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
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
            // ClassesTableLayoutPanel
            // 
            this.ClassesTableLayoutPanel.ColumnCount = 2;
            this.ClassesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.Controls.Add(this.rectanglesControl1, 0, 0);
            this.ClassesTableLayoutPanel.Controls.Add(this.moviesControl1, 1, 0);
            this.ClassesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ClassesTableLayoutPanel.Name = "ClassesTableLayoutPanel";
            this.ClassesTableLayoutPanel.RowCount = 1;
            this.ClassesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ClassesTableLayoutPanel.Size = new System.Drawing.Size(780, 504);
            this.ClassesTableLayoutPanel.TabIndex = 0;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(384, 498);
            this.rectanglesControl1.TabIndex = 0;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesControl1.Location = new System.Drawing.Point(393, 3);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(384, 498);
            this.moviesControl1.TabIndex = 1;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(780, 504);
            this.rectanglesCollisionControl1.TabIndex = 0;
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
            this.EnumsTableLayoutPanel.ResumeLayout(false);
            this.ClassesPage.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.ClassesTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl AppTabControl;
        private TabPage EnumsPage;
        private GroupBox EnumerationsGroupBox;
        private TabPage ClassesPage;
        private TabPage RectanglesTabPage;
        private TableLayoutPanel EnumsTableLayoutPanel;
        private View.WeekdayParsingControl weekdayParsingControl1;
        private View.SeasonsControl seasonsControl1;
        private View.AllEnumerationsControl allEnumerationsControl1;
        private TableLayoutPanel ClassesTableLayoutPanel;
        private View.RectanglesControl rectanglesControl1;
        private View.MoviesControl moviesControl1;
        private View.RectanglesCollisionControl rectanglesCollisionControl1;
    }
}