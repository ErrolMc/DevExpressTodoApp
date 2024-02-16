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
    public partial class TodoItemExpandedControl : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler NotesChanged;

        public string Notes
        {
            get { return NotesEdit.Text; }
            set { NotesEdit.Text = value; }
        }

        public TodoItemExpandedControl()
        {
            InitializeComponent();
            NotesEdit.TextChanged += NotesEdit_OnValueChanged;
        }

        private void NotesEdit_OnValueChanged(object sender, EventArgs e)
        {
            NotesChanged?.Invoke(this, e);
        }
    }
}
