
namespace DevExpressTraining
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.TodoListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.AddTodoButton = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TodoListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // TodoListBox
            // 
            this.TodoListBox.Location = new System.Drawing.Point(12, 66);
            this.TodoListBox.Name = "TodoListBox";
            this.TodoListBox.Size = new System.Drawing.Size(290, 461);
            this.TodoListBox.TabIndex = 0;
            // 
            // AddTodoButton
            // 
            this.AddTodoButton.Location = new System.Drawing.Point(227, 21);
            this.AddTodoButton.Name = "AddTodoButton";
            this.AddTodoButton.Size = new System.Drawing.Size(75, 23);
            this.AddTodoButton.TabIndex = 1;
            this.AddTodoButton.Text = "Add ToDo";
            this.AddTodoButton.Click += new System.EventHandler(this.AddTodoButton_OnClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 539);
            this.Controls.Add(this.AddTodoButton);
            this.Controls.Add(this.TodoListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ToDo Manager";
            this.Load += new System.EventHandler(this.MainForm_OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.TodoListBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl TodoListBox;
        private DevExpress.XtraEditors.SimpleButton AddTodoButton;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}

