using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace EyeFresher
{
    public partial class NotificationForm : Form
    {
        string src = Directory.GetCurrentDirectory();
        public NotificationForm()
        {
            InitializeComponent();
        }

        private void pbCoffee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbCoffee_MouseLeave(object sender, EventArgs e)
        {
            pbCoffee.Image = Image.FromFile(src + "\\coffee-cup.png");
        }

        private void pbCoffee_MouseEnter(object sender, EventArgs e)
        {

            pbCoffee.Image = Image.FromFile(src + "\\coffee-cup-400-percent.png");
        }

    }
}
