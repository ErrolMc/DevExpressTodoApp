using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DevExpressTraining
{
    public class CustomFlowLayoutPanel : FlowLayoutPanel
    {
        [DllImport("user32.dll")]
        public static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);
        private const int SB_HORZ = 0;
        private const int SB_VERT = 1;
        private const int SB_BOTH = 3;

        protected override void WndProc(ref Message m)
        {
            // Hide the scrollbars by intercepting the relevant Windows message
            if (m.Msg == 0x85) // WM_NCCALCSIZE
            {
                ShowScrollBar(this.Handle, SB_BOTH, 0); // 0 = false
            }
            base.WndProc(ref m);
        }

        public CustomFlowLayoutPanel()
        {
            this.AutoScroll = true;
            // Handle the mouse wheel event for custom scrolling
            this.MouseWheel += CustomFlowLayoutPanel_MouseWheel;
        }

        private void CustomFlowLayoutPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            // Scroll the panel in response to mouse wheel movements
            if (this.VerticalScroll.Visible)
            {
                // Calculate the new value
                int newValue = this.VerticalScroll.Value - (e.Delta * SystemInformation.MouseWheelScrollLines / 120);
                newValue = Math.Max(newValue, this.VerticalScroll.Minimum);
                newValue = Math.Min(newValue, this.VerticalScroll.Maximum);

                this.VerticalScroll.Value = newValue;
                this.Refresh();
            }
        }
    }
}