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
    public partial class AddTodoForm : DevExpress.XtraEditors.XtraForm
    {
        public string HeaderText
        {
            get { return HeaderEdit.Text; }
        }

        public string NotesText
        {
            get { return NotesEdit.Text; }
        }

        public AddTodoForm()
        {
            InitializeComponent();
        }

        private void AddTodoButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CancelTodoButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}