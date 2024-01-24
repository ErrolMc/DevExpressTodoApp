
namespace DevExpressTraining
{
    partial class AddTodoForm
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
            this.HeaderEdit = new DevExpress.XtraEditors.TextEdit();
            this.NotesEdit = new DevExpress.XtraEditors.MemoEdit();
            this.HeaderLabel = new DevExpress.XtraEditors.LabelControl();
            this.NotesLabel = new DevExpress.XtraEditors.LabelControl();
            this.AddTodoButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelTodoButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotesEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderEdit
            // 
            this.HeaderEdit.Location = new System.Drawing.Point(76, 28);
            this.HeaderEdit.Name = "HeaderEdit";
            this.HeaderEdit.Size = new System.Drawing.Size(339, 20);
            this.HeaderEdit.TabIndex = 0;
            // 
            // BodyEdit
            // 
            this.NotesEdit.Location = new System.Drawing.Point(76, 77);
            this.NotesEdit.Name = "NotesEdit";
            this.NotesEdit.Size = new System.Drawing.Size(339, 96);
            this.NotesEdit.TabIndex = 1;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Location = new System.Drawing.Point(12, 31);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(39, 13);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "Header:";
            // 
            // BodyLabel
            // 
            this.NotesLabel.Location = new System.Drawing.Point(23, 78);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(28, 13);
            this.NotesLabel.TabIndex = 3;
            this.NotesLabel.Text = "Notes:";
            // 
            // AddTodoButton
            // 
            this.AddTodoButton.Location = new System.Drawing.Point(122, 194);
            this.AddTodoButton.Name = "AddTodoButton";
            this.AddTodoButton.Size = new System.Drawing.Size(75, 23);
            this.AddTodoButton.TabIndex = 4;
            this.AddTodoButton.Text = "Add";
            this.AddTodoButton.Click += new System.EventHandler(this.AddTodoButton_Click);
            // 
            // CancelTodoButton
            // 
            this.CancelTodoButton.Location = new System.Drawing.Point(273, 194);
            this.CancelTodoButton.Name = "CancelTodoButton";
            this.CancelTodoButton.Size = new System.Drawing.Size(75, 23);
            this.CancelTodoButton.TabIndex = 5;
            this.CancelTodoButton.Text = "Cancel";
            this.CancelTodoButton.Click += new System.EventHandler(this.CancelTodoButton_Click);
            // 
            // AddTodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 240);
            this.Controls.Add(this.CancelTodoButton);
            this.Controls.Add(this.AddTodoButton);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.NotesEdit);
            this.Controls.Add(this.HeaderEdit);
            this.Name = "AddTodoForm";
            this.Text = "Add New Todo";
            ((System.ComponentModel.ISupportInitialize)(this.HeaderEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotesEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit HeaderEdit;
        private DevExpress.XtraEditors.MemoEdit NotesEdit;
        private DevExpress.XtraEditors.LabelControl HeaderLabel;
        private DevExpress.XtraEditors.LabelControl NotesLabel;
        private DevExpress.XtraEditors.SimpleButton AddTodoButton;
        private DevExpress.XtraEditors.SimpleButton CancelTodoButton;
    }
}