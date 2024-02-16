
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
            this.NotesControl = new DevExpressTraining.TodoItemExpandedControl();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelText
            // 
            this.LabelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelText.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.7F);
            this.LabelText.Appearance.ForeColor = System.Drawing.Color.White;
            this.LabelText.Appearance.Options.UseFont = true;
            this.LabelText.Appearance.Options.UseForeColor = true;
            this.LabelText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.LabelText.Location = new System.Drawing.Point(37, 12);
            this.LabelText.MaximumSize = new System.Drawing.Size(300, 0);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(280, 17);
            this.LabelText.TabIndex = 0;
            this.LabelText.Text = "blank";
            this.LabelText.Enabled = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(333, 9);
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
            // NotesControl
            // 
            this.NotesControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesControl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.NotesControl.Appearance.Options.UseBackColor = true;
            this.NotesControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NotesControl.Location = new System.Drawing.Point(37, 38);
            this.NotesControl.Name = "NotesControl";
            this.NotesControl.Size = new System.Drawing.Size(318, 129);
            this.NotesControl.TabIndex = 3;
            // 
            // TodoItemControl
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NotesControl);
            this.Controls.Add(this.CompletedCheckEdit);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.LabelText);
            this.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "TodoItemControl";
            this.Size = new System.Drawing.Size(367, 177);
            ((System.ComponentModel.ISupportInitialize)(this.CompletedCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LabelText;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.CheckEdit CompletedCheckEdit;
        private TodoItemExpandedControl NotesControl;
    }
}
