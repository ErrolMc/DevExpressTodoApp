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
    public partial class CompletedSpacerControl : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler OnToggleExpanded;

        public bool IsExpanded { get; set; } = false;

        public CompletedSpacerControl()
        {
            InitializeComponent();

            this.MouseEnter += CompletedSpacerControl_MouseEnter;
            this.MouseLeave += CompletedSpacerControl_MouseLeave;
            this.Click += ToggleExpanded;
        }

        private void CompletedSpacerControl_MouseEnter(object sender, EventArgs e)
        {
            this.Appearance.BackColor = Color.FromArgb(65, 65, 65);
        }

        private void CompletedSpacerControl_MouseLeave(object sender, EventArgs e)
        {
            this.Appearance.BackColor = Color.FromArgb(50, 50, 50);
        }

        public void SetCompletedNum(int numCompleted)
        {
            NumCompletedText.Text = numCompleted.ToString();
        }

        private void ToggleExpanded(object sender, EventArgs e)
        {
            IsExpanded = !IsExpanded;
            ArrowIcon.Image = RotateImage(Properties.Resources.arrow, IsExpanded ? 90 : 0);
            OnToggleExpanded?.Invoke(this, EventArgs.Empty);
        }

        private Bitmap RotateImage(Bitmap b, float angle)
        {
            Bitmap rotatedImage = new Bitmap(b.Width, b.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(b.Width / 2, b.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-b.Width / 2, -b.Height / 2);
                g.DrawImage(b, new Point(0, 0));
            }
            return rotatedImage;
        }
    }
}
