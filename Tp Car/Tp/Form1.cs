using System.Windows.Forms;

namespace Tp
{
    public partial class Form1 : Form
    {
        int i = 0;
        int collectedcoin = 0;
        int speed = 5;
        bool f, ng;
        public Form1()
        {
            InitializeComponent();
        }
        void coinscollection()
        {
            Random r = new Random();
            int x;
            if (pbcar.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin++;
                lb1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(50, pnborder.Left - coin1.Width);
                coin1.Location = new Point(x, 0);
            }

            if (pbcar.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin++;
                lb1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(50, pnborder.Left - coin1.Width);
                coin2.Location = new Point(x, 0);
            }

            if (pbcar.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin++;
                lb1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(50, pnborder.Left - coin1.Width);
                coin3.Location = new Point(x, 0);
            }

            if (pbcar.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoin++;
                lb1.Text = "Coins=" + collectedcoin.ToString();
                x = r.Next(50, pnborder.Left - coin1.Width);
                coin4.Location = new Point(x, 0);
            }
        }

        void coins()
        {
            Random r = new Random();
            coin1.Top += speed;
            if (coin1.Top > this.Height)
            {
                coin1.Top = -coin1.Height - r.Next(100);
                coin1.Left = r.Next(pnborder.Left - coin1.Width);
            }
            coin2.Top += speed;
            if (coin1.Top > this.Height)
            {
                coin2.Top = -coin2.Height - r.Next(100);
                coin2.Left = r.Next(pnborder.Left - coin2.Width);
            }
            coin3.Top += speed;
            if (coin3.Top > this.Height)
            {
                coin3.Top = -coin3.Height-r.Next(100);
                coin3.Left = r.Next(pnborder.Left - coin3.Width);
            }
            coin4.Top += speed;
            if (coin4.Top > this.Height)
            {
                coin4.Top = -coin4.Height - r.Next(100);
                coin4.Left = r.Next(pnborder.Left - coin4.Width);
            }
        }

        void enemy()
        {
            Random r = new Random();
            pb1.Top = pb1.Top + speed;
            if (pb1.Top > this.Height)
            {
                pb1.Top = -pb1.Height;
                pb1.Left = r.Next(pnborder.Left - pb1.Width);
            }
            if (pbcar.Bounds.IntersectsWith(pb1.Bounds))
            {
                tm1.Enabled = false;
                MessageBox.Show("Проиграли");
                f = false;
                ng = false;
                pbcar.Enabled = false;
            }//bounds – возвращает местоположение и размер объекта в точках относительно родительского контейнера.
             //IntersectsWith – определяет, пересекается ли данный прямоугольник с заданым в скобках прямоугольником.
            pb2.Top = pb2.Top + speed;
            if (pb2.Top > this.Height)
            {
                pb2.Top = -pb2.Height;
                pb2.Left = r.Next(pnborder.Left - pb2.Width);
            }
            if (pbcar.Bounds.IntersectsWith(pb2.Bounds))
            {
                tm1.Enabled = false;
                MessageBox.Show("Проиграли");
                f = false;
                ng = false;
                pbcar.Enabled = false;
            }
        }

        void moveline()
        {
            if (pictureBox1.Top > this.Height)
            { pictureBox1.Top = -pictureBox1.Height; ; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top > this.Height)
            { pictureBox2.Top = -pictureBox2.Height; ; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top > this.Height)
            { pictureBox3.Top = -pictureBox3.Height; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top > this.Height)
            { pictureBox4.Top = -pictureBox4.Height; ; }
            else { pictureBox4.Top += speed; }

        }
        private void tm1_Tick(object sender, EventArgs e)
        {
            enemy();
            coins();
            coinscollection();
            moveline();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Right) &&
                (pbcar.Left + pbcar.Width < pnborder.Left) && f == true)
            {
                tmright.Enabled = true;
            }
            if ((e.KeyCode == Keys.Left) &&
                (pbcar.Left > 10) && f == true)
            {
                tmleft.Enabled = true;
            }


            /*if ((e.KeyCode == Keys.Right) &&
               (pbcar.Left + pbcar.Width < pnborder.Left))
            {
                pbcar.Left += 10;
            }
            if ((e.KeyCode == Keys.Left) &&
                (pbcar.Left > 10))
            {
                pbcar.Left -= 10;
            }*/
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ng == true)
            {
            tm1.Enabled = true;
            pbcar.Enabled = true;
            f = true;
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tm1.Enabled = false;
            pbcar.Enabled = false;
            f = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            pb1.Top = -pb1.Height;
            pb1.Left = r.Next(pnborder.Left - pb1.Width);
            pb2.Top = -pb2.Height - 265;
            pb2.Left = r.Next(pnborder.Left - pb2.Width);
            pbcar.Left = r.Next(pnborder.Left - pbcar.Width);
            coin4.Top = -coin4.Height - r.Next(100);
            coin4.Left = r.Next(pnborder.Left - coin4.Width);
            coin3.Top = -coin4.Height - r.Next(100);
            coin3.Left = r.Next(pnborder.Left - coin4.Width);
            coin2.Top = -coin4.Height - r.Next(100);
            coin2.Left = r.Next(pnborder.Left - coin4.Width);
            coin1.Top = -coin4.Height - r.Next(100);
            coin1.Left = r.Next(pnborder.Left - coin4.Width);
            lb1.Text = "Coins=0";
            collectedcoin = 0;
            tm1.Enabled = false;
            f = false;
            ng = true;
            
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tm1.Interval = 40;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tm1.Interval = 20;
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tm1.Interval = 10;
        }

        private void tmleft_Tick(object sender, EventArgs e)
        {
            pbcar.Left -= 10;
            tmleft.Enabled = false;
        }

        private void tmright_Tick(object sender, EventArgs e)
        {
            pbcar.Left += 10;
            tmright.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            pb1.Top = -pb1.Height;
            pb1.Left = r.Next(pnborder.Left - pb1.Width);
            pb2.Top = -pb2.Height - 265;
            pb2.Left = r.Next(pnborder.Left - pb2.Width);
            pbcar.Left = r.Next(pnborder.Left - pbcar.Width);
            coin4.Top = -coin4.Height - r.Next(100);
            coin4.Left = r.Next(pnborder.Left - coin4.Width);
            coin3.Top = -coin4.Height - r.Next(100);
            coin3.Left = r.Next(pnborder.Left - coin4.Width);
            coin2.Top = -coin4.Height - r.Next(100);
            coin2.Left = r.Next(pnborder.Left - coin4.Width);
            coin1.Top = -coin4.Height - r.Next(100);
            coin1.Left = r.Next(pnborder.Left - coin4.Width);
            lb1.Text = "Coins=0";
            f = false;
            ng = true;
        }
    }
}
