
namespace Tyuiu.FaizullinDR.Sprint7.Project.V7
{
    partial class FormQuickGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuickGuide));
            this.labelQuickGuide_FDR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuickGuide_FDR
            // 
            this.labelQuickGuide_FDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuickGuide_FDR.AutoSize = true;
            this.labelQuickGuide_FDR.Location = new System.Drawing.Point(12, 9);
            this.labelQuickGuide_FDR.Name = "labelQuickGuide_FDR";
            this.labelQuickGuide_FDR.Size = new System.Drawing.Size(869, 527);
            this.labelQuickGuide_FDR.TabIndex = 0;
            this.labelQuickGuide_FDR.Text = resources.GetString("labelQuickGuide_FDR.Text");
            // 
            // FormQuickGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 535);
            this.Controls.Add(this.labelQuickGuide_FDR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuickGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuickGuide_FDR;
    }
}