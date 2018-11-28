namespace WindowsFormsApplication1
{
    partial class frmReview
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
            this.panelReview = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelReview
            // 
            this.panelReview.AutoScroll = true;
            this.panelReview.BackColor = System.Drawing.SystemColors.Control;
            this.panelReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReview.Location = new System.Drawing.Point(30, 30);
            this.panelReview.Name = "panelReview";
            this.panelReview.Size = new System.Drawing.Size(783, 513);
            this.panelReview.TabIndex = 2;
            // 
            // frmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.pra12;
            this.ClientSize = new System.Drawing.Size(843, 573);
            this.Controls.Add(this.panelReview);
            this.Name = "frmReview";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReview;
    }
}