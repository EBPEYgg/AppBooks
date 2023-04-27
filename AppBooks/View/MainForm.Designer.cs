namespace AppBooks
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
            this.BookTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BooksControl = new AppBooks.View.Panels.BooksControl();
            this.BookTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookTableLayoutPanel
            // 
            this.BookTableLayoutPanel.ColumnCount = 1;
            this.BookTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BookTableLayoutPanel.Controls.Add(this.BooksControl, 0, 0);
            this.BookTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.BookTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BookTableLayoutPanel.Name = "BookTableLayoutPanel";
            this.BookTableLayoutPanel.RowCount = 1;
            this.BookTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BookTableLayoutPanel.Size = new System.Drawing.Size(721, 532);
            this.BookTableLayoutPanel.TabIndex = 0;
            // 
            // BooksControl
            // 
            this.BooksControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BooksControl.Location = new System.Drawing.Point(3, 3);
            this.BooksControl.Name = "BooksControl";
            this.BooksControl.Size = new System.Drawing.Size(715, 526);
            this.BooksControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 532);
            this.Controls.Add(this.BookTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(739, 579);
            this.Name = "MainForm";
            this.Text = "BookApp";
            this.BookTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel BookTableLayoutPanel;
        private View.Panels.BooksControl BooksControl;
    }
}