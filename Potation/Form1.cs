using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Potation {
    public partial class Form1 : Form {

        private bool move = false;
        private int x, y;

        public Form1() {
            InitializeComponent();
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) {
            move = false;
            this.BackgroundImage = getBackground();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) {
            if (move == true) {
                this.SetDesktopLocation(Cursor.Position.X -
                    x - Screen.PrimaryScreen.WorkingArea.X 
                    - potationPanel.Location.X,
                    Cursor.Position.Y - y 
                    - Screen.PrimaryScreen.WorkingArea.Y 
                    - potationPanel.Location.Y);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.BackgroundImage = getBackground();
            notifyPotation.ShowBalloonTip(1000, "Thông báo", "Chương trình Potation đã được khởi động", ToolTipIcon.Info);
        }

        private void ctxExit_Click(object sender, EventArgs e) {
            notifyPotation.ShowBalloonTip(1000, "Thông báo", "Chương trình Potation đã dừng :)\nCảm ơn bạn đã sử dụng", ToolTipIcon.Info);
            Thread.Sleep(1000);
            Application.Exit();
        }

        private Image getBackground() {
            this.Hide();
            Bitmap bm = new Bitmap(this.Width, this.Height);
            Graphics gp = Graphics.FromImage(bm);
            gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gp.CopyFromScreen(this.DesktopLocation.X + Screen.PrimaryScreen.WorkingArea.X, this.DesktopLocation.Y + Screen.PrimaryScreen.WorkingArea.Y, 0, 0, new Size(this.Width, this.Height));
            this.Show();
            return bm;
        }
    }


}
