using DevExpress.XtraEditors;
using System;
using System.Drawing;

namespace DevExpressTraining
{
    public partial class TodoItemControl : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler DeleteClicked;
        public event EventHandler CheckedChanged;
        public event EventHandler SaveTodoItems;

        const int COLLAPSED_HEIGHT = 41;
        const int EXPANDED_HEIGHT = 177;

        public TodoItemControl()
        {
            InitializeComponent();

            this.MouseEnter += TodoItemControl_MouseEnter;
            this.MouseLeave += TodoItemControl_MouseLeave;
            this.Click += ToggleCollapsed;
            this.NotesControl.NotesChanged += NotesEdit_OnValueChanged;

            SetCollapsedState(false);
        }

        public string Label
        {
            get { return LabelText.Text; }
            set { LabelText.Text = value; }
        }

        public string Notes
        {
            get { return NotesControl.Notes; }
            set { NotesControl.Notes = value; }
        }

        public bool Completed
        {
            get { return CompletedCheckEdit.Checked; }
            set { CompletedCheckEdit.Checked = value; }
        }

        public TodoItem TodoItem { get; set; }

        public bool Collapsed { get; set; }

        public void SetCollapsedState(bool state)
        {
            Collapsed = state;

            if (state)
            {
                this.Height = EXPANDED_HEIGHT;
                this.NotesControl.Show();
            }
            else
            {
                this.Height = COLLAPSED_HEIGHT;
                this.NotesControl.Hide();
            }
        }

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

        private void ToggleCollapsed(object sender, EventArgs e)
        {
            SetCollapsedState(!Collapsed);
        }

        private void TodoItemControl_MouseEnter(object sender, EventArgs e)
        {
            this.Appearance.BackColor = Color.FromArgb(65, 65, 65);
        }

        private void TodoItemControl_MouseLeave(object sender, EventArgs e)
        {
            this.Appearance.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void NotesEdit_OnValueChanged(object sender, EventArgs e)
        {
            if (TodoItem != null)
                TodoItem.Notes = Notes;
            SaveTodoItems?.Invoke(this, EventArgs.Empty);
        }
    }
}
