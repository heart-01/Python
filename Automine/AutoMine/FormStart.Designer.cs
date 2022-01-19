namespace AutoMine
{
    partial class FormStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsbFile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbFile
            // 
            this.lsbFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lsbFile.FormattingEnabled = true;
            this.lsbFile.ItemHeight = 24;
            this.lsbFile.Location = new System.Drawing.Point(2, 3);
            this.lsbFile.Name = "lsbFile";
            this.lsbFile.Size = new System.Drawing.Size(349, 244);
            this.lsbFile.TabIndex = 0;
            this.lsbFile.SelectedIndexChanged += new System.EventHandler(this.LsbFile_SelectedIndexChanged);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 265);
            this.Controls.Add(this.lsbFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStart";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbFile;
    }
}