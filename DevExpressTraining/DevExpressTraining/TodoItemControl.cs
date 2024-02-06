using DevExpress.XtraEditors;
using System;

namespace DevExpressTraining
{
    public partial class TodoItemControl : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler DeleteClicked;
        public event EventHandler CheckedChanged;

        public TodoItemControl()
        {
            InitializeComponent();
        }

        public string Label
        {
            get { return LabelText.Text; }
            set { LabelText.Text = value; }
        }

        public bool Completed
        {
            get { return CompletedCheckEdit.Checked; }
            set { CompletedCheckEdit.Checked = value; }
        }

        public TodoItem TodoItem { get; set; }

        private void CompletedCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit checkEdit = sender as CheckEdit;
            if (checkEdit != null)
            {
                bool isChecked = checkEdit.Checked;
                TodoItem.Completed = isChecked;
                CheckedChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
