using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonHover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clickbtn.MouseHover += clickbtn_Hover;
        }
        private void clickbtn_Hover(object sender, EventArgs e)
        {
            if (sender is Button bt)
            {
                bt.Dispose();
                Button button = new Button();
                button.Size = new Size(140, 50);
                Random randm = new Random();
                int radomX = randm.Next(this.Size.Width - 100);
                int radomY = randm.Next(this.Size.Height - 100);

                button.Location = new Point(radomX, radomY);
                button.Text = "try to click me";
                button.BackColor = Color.Honeydew;
                button.MouseHover += clickbtn_Hover;
                this.Controls.Add(button);
            }
        }
    }
}
