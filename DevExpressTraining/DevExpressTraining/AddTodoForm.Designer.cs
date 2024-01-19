
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
            this.BodyEdit = new DevExpress.XtraEditors.MemoEdit();
            this.HeaderLabel = new DevExpress.XtraEditors.LabelControl();
            this.BodyLabel = new DevExpress.XtraEditors.LabelControl();
            this.AddTodoButton = new DevExpress.XtraEditors.SimpleButton();
            this.CancelTodoButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodyEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderEdit
            // 
            this.HeaderEdit.Location = new System.Drawing.Point(76, 28);
            this.HeaderEdit.Name = "HeaderEdit";
            this.HeaderEdit.Size = new System.Drawing.Size(339, 20);
            this.HeaderEdit.TabIndex = 0;
            this.HeaderEdit.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // BodyEdit
            // 
            this.BodyEdit.Location = new System.Drawing.Point(76, 77);
            this.BodyEdit.Name = "BodyEdit";
            this.BodyEdit.Size = new System.Drawing.Size(339, 96);
            this.BodyEdit.TabIndex = 1;
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
            this.BodyLabel.Location = new System.Drawing.Point(23, 78);
            this.BodyLabel.Name = "BodyLabel";
            this.BodyLabel.Size = new System.Drawing.Size(28, 13);
            this.BodyLabel.TabIndex = 3;
            this.BodyLabel.Text = "Body:";
            // 
            // AddTodoButton
            // 
            this.AddTodoButton.Location = new System.Drawing.Point(122, 194);
            this.AddTodoButton.Name = "AddTodoButton";
            this.AddTodoButton.Size = new System.Drawing.Size(75, 23);
            this.AddTodoButton.TabIndex = 4;
            this.AddTodoButton.Text = "Add";
            // 
            // CancelTodoButton
            // 
            this.CancelTodoButton.Location = new System.Drawing.Point(273, 194);
            this.CancelTodoButton.Name = "CancelTodoButton";
            this.CancelTodoButton.Size = new System.Drawing.Size(75, 23);
            this.CancelTodoButton.TabIndex = 5;
            this.CancelTodoButton.Text = "Cancel";
            // 
            // AddTodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 240);
            this.Controls.Add(this.CancelTodoButton);
            this.Controls.Add(this.AddTodoButton);
            this.Controls.Add(this.BodyLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.BodyEdit);
            this.Controls.Add(this.HeaderEdit);
            this.Name = "AddTodoForm";
            this.Text = "AddTodoForm";
            ((System.ComponentModel.ISupportInitialize)(this.HeaderEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BodyEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit HeaderEdit;
        private DevExpress.XtraEditors.MemoEdit BodyEdit;
        private DevExpress.XtraEditors.LabelControl HeaderLabel;
        private DevExpress.XtraEditors.LabelControl BodyLabel;
        private DevExpress.XtraEditors.SimpleButton AddTodoButton;
        private DevExpress.XtraEditors.SimpleButton CancelTodoButton;
    }
}