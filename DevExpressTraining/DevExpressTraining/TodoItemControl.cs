using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressTraining
{
    public partial class TodoItemControl : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler DeleteClicked;

        public TodoItemControl()
        {
            InitializeComponent();
        }

        public string Label
        {
            get { return LabelText.Text; }
            set { LabelText.Text = value; }
        }

        public TodoItem TodoItem { get; set; }

        private void CompletedCheckEdit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
