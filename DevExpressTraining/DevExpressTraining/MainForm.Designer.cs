
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
            this.AddTodoButton = new DevExpress.XtraEditors.SimpleButton();
            this.BehaviorManager = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.TodoLayoutPanel = new CustomFlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BehaviorManager)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTodoButton
            // 
            this.AddTodoButton.Location = new System.Drawing.Point(223, 15);
            this.AddTodoButton.Name = "AddTodoButton";
            this.AddTodoButton.Size = new System.Drawing.Size(75, 23);
            this.AddTodoButton.TabIndex = 1;
            this.AddTodoButton.Text = "Add Todo";
            this.AddTodoButton.Click += new System.EventHandler(this.AddTodoButton_OnClick);
            // 
            // TodoLayoutPanel
            // 
            this.TodoLayoutPanel.AutoScroll = true;
            this.TodoLayoutPanel.Location = new System.Drawing.Point(16, 51);
            this.TodoLayoutPanel.Name = "TodoLayoutPanel";
            this.TodoLayoutPanel.Size = new System.Drawing.Size(288, 466);
            this.TodoLayoutPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 523);
            this.Controls.Add(this.TodoLayoutPanel);
            this.Controls.Add(this.AddTodoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Todo Manager";
            this.Load += new System.EventHandler(this.MainForm_OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.BehaviorManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton AddTodoButton;
        private DevExpress.Utils.Behaviors.BehaviorManager BehaviorManager;
        private CustomFlowLayoutPanel TodoLayoutPanel;
    }
}

