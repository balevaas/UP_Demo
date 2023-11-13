using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP_Demo.Forms
{
    public partial class Capcha : Form
    {
        private string text = string.Empty;
        public Capcha()
        {
            InitializeComponent();
        }

        private void Capcha_Load(object sender, EventArgs e)
        {
            pictureBoxCaptha.Image = this.CreateImage(pictureBoxCaptha.Width, pictureBoxCaptha.Height);
        }

        private Bitmap CreateImage(int Windth, int Height)
        {
            Random rnd = new Random();

            Bitmap result = new Bitmap(Width, Height);

            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            Graphics g = Graphics.FromImage((Image)result);

            g.Clear(Color.Gray);

            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void buttonAutorize_Click(object sender, EventArgs e)
        {
            if (textBoxCaptha.Text == this.text)
            {
                AutorizationForm authorization = new AutorizationForm();
                authorization.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильно введен код", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pictureBoxCaptha.Image = this.CreateImage(pictureBoxCaptha.Width, pictureBoxCaptha.Height);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            pictureBoxCaptha.Image = this.CreateImage(pictureBoxCaptha.Width, pictureBoxCaptha.Height);
        }
    }
}
