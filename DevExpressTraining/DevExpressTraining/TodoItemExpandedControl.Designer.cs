
namespace DevExpressTraining
{
    partial class TodoItemExpandedControl
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
            this.NotesEdit = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.NotesEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // NotesEdit
            // 
            this.NotesEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesEdit.Location = new System.Drawing.Point(0, 0);
            this.NotesEdit.Name = "NotesEdit";
            this.NotesEdit.Size = new System.Drawing.Size(367, 181);
            this.NotesEdit.TabIndex = 0;
            // 
            // TodoItemExpandedControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NotesEdit);
            this.Name = "TodoItemExpandedControl";
            this.Size = new System.Drawing.Size(367, 181);
            ((System.ComponentModel.ISupportInitialize)(this.NotesEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit NotesEdit;
    }
}
