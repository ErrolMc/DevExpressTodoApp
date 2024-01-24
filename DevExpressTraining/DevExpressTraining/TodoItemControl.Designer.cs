
namespace DevExpressTraining
{
    partial class TodoItemControl
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
            this.LabelText = new DevExpress.XtraEditors.LabelControl();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.CompletedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelText
            // 
            this.LabelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelText.Location = new System.Drawing.Point(37, 14);
            this.LabelText.MaximumSize = new System.Drawing.Size(260, 0);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(260, 13);
            this.LabelText.TabIndex = 0;
            this.LabelText.Text = "blank";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(305, 9);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(22, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "X";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CompletedCheckEdit
            // 
            this.CompletedCheckEdit.Location = new System.Drawing.Point(9, 11);
            this.CompletedCheckEdit.Name = "CompletedCheckEdit";
            this.CompletedCheckEdit.Properties.Caption = "";
            this.CompletedCheckEdit.Size = new System.Drawing.Size(15, 19);
            this.CompletedCheckEdit.TabIndex = 2;
            this.CompletedCheckEdit.CheckedChanged += new System.EventHandler(this.CompletedCheckEdit_CheckedChanged);
            // 
            // TodoItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CompletedCheckEdit);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.LabelText);
            this.Name = "TodoItemControl";
            this.Size = new System.Drawing.Size(339, 41);
            ((System.ComponentModel.ISupportInitialize)(this.CompletedCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LabelText;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.CheckEdit CompletedCheckEdit;
    }
}
