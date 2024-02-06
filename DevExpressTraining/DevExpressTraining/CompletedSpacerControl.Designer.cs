
namespace DevExpressTraining
{
    partial class CompletedSpacerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CompletedLabel = new DevExpress.XtraEditors.LabelControl();
            this.NumCompletedText = new DevExpress.XtraEditors.LabelControl();
            this.ArrowIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // CompletedLabel
            // 
            this.CompletedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CompletedLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.CompletedLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.CompletedLabel.Appearance.Options.UseFont = true;
            this.CompletedLabel.Appearance.Options.UseForeColor = true;
            this.CompletedLabel.Enabled = false;
            this.CompletedLabel.Location = new System.Drawing.Point(34, 6);
            this.CompletedLabel.Name = "CompletedLabel";
            this.CompletedLabel.Size = new System.Drawing.Size(67, 17);
            this.CompletedLabel.TabIndex = 3;
            this.CompletedLabel.Text = "Completed";
            // 
            // NumCompletedText
            // 
            this.NumCompletedText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NumCompletedText.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.NumCompletedText.Appearance.ForeColor = System.Drawing.Color.White;
            this.NumCompletedText.Appearance.Options.UseFont = true;
            this.NumCompletedText.Appearance.Options.UseForeColor = true;
            this.NumCompletedText.Enabled = false;
            this.NumCompletedText.Location = new System.Drawing.Point(118, 6);
            this.NumCompletedText.Name = "NumCompletedText";
            this.NumCompletedText.Size = new System.Drawing.Size(14, 17);
            this.NumCompletedText.TabIndex = 4;
            this.NumCompletedText.Text = "10";
            // 
            // ArrowIcon
            // 
            this.ArrowIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ArrowIcon.Enabled = false;
            this.ArrowIcon.Image = global::DevExpressTraining.Properties.Resources.arrow;
            this.ArrowIcon.Location = new System.Drawing.Point(8, 8);
            this.ArrowIcon.Name = "ArrowIcon";
            this.ArrowIcon.Size = new System.Drawing.Size(14, 14);
            this.ArrowIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ArrowIcon.TabIndex = 0;
            this.ArrowIcon.TabStop = false;
            // 
            // CompletedSpacerControl
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumCompletedText);
            this.Controls.Add(this.CompletedLabel);
            this.Controls.Add(this.ArrowIcon);
            this.Name = "CompletedSpacerControl";
            this.Size = new System.Drawing.Size(143, 30);
            ((System.ComponentModel.ISupportInitialize)(this.ArrowIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ArrowIcon;
        private DevExpress.XtraEditors.LabelControl CompletedLabel;
        private DevExpress.XtraEditors.LabelControl NumCompletedText;
    }
}
