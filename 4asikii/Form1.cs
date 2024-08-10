using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4asikii.Properties;
using System.Drawing.Drawing2D;
using System.Media;
using System.Runtime.InteropServices;

namespace _4asikii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int fff = 0;
        int xc, yc, x, y, r = 160;
        Graphics gr;
        double ang =0, dangle = 2 * Math.PI / 60;
        Pen pen = new Pen(Color.Red);

        int xc1, yc1, x1, y1, r1 = 150;
        Graphics gr1;
        double ang1 = 0, dangle1 = 2 * Math.PI / 60;
        Pen pen1 = new Pen(Color.Blue);

        int xc2, yc2, x2, y2, r2 = 130;
        Graphics gr2;
        double ang2 = 0, dangle2 = 2 * Math.PI / 60;
        Pen pen2 = new Pen(Color.Black);

        Graphics gr3;
        int w = 0, h = 0;
        string s,s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,s11,s12;
        Font f = new Font("Arial", 30, FontStyle.Italic);
        SolidBrush br = new SolidBrush(Color.Black);
        StringFormat sf = new StringFormat();
        PointF p = new PointF();
        

        private void buttonBudStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш будильник был остановлен!");
            buttonBudStop.Enabled = false;
            buttonBudDop.Enabled = true;
            maskedTextBox2.Text = "";
            maskedTextBox2.Enabled = true;
            maskedTextBox2.Visible = true;
            labelVremya.Visible = false;
        }

        private void buttonBudDop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш будильник установлен!" + Environment.NewLine + Environment.NewLine + "Проверьте правильность поставленого времени, чтобы избежать ошибок");
            labelVremya.Text = maskedTextBox2.Text;
            maskedTextBox2.Visible = false;
            labelVremya.Visible = true;
            buttonBudStop.Enabled = true;
            buttonBudDop.Enabled = false;
            maskedTextBox2.Enabled = false;
        }

        private void timer4TimeNow_Tick(object sender, EventArgs e)
        {
            label1TimeNow.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");

            if (dateTimePicker1.Value.Date == DateTime.Today && label1TimeNow.Text == labelVremya.Text + ":00")
            {
                SoundPlayer BudStop = new SoundPlayer(@"C:\Windows\Media\Alarm01.wav");
                maskedTextBox2.Text = "";
                labelVremya.Visible = false;
                maskedTextBox2.Visible = true;
                buttonBudDop.Enabled = true;
                buttonBudStop.Enabled = false;
                BudStop.Play();
                maskedTextBox2.Enabled = true;
                fff++;
                if (fff == 1)
                {
                    MessageBox.Show("Будильник: *Звенит* ");
                }
                
            }
            

        
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ang1 += dangle1;
            pictureBox1.Invalidate();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            ang2 += dangle2;
            pictureBox1.Invalidate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            maskedTextBox2.Text = "";
            maskedTextBox2.Visible = true;
            labelVremya.Visible = false;

            timer4TimeNow.Start();
            timer1.Start();
            timer2.Start();
            timer3.Start();

            pen.Width = 2;
            this.pictureBox1.Image = Resources.Chiferblat;
            xc = pictureBox1.Width / 2;
            yc = pictureBox1.Height / 2;
            gr = pictureBox1.CreateGraphics();

            pen1.Width = 2;
            xc1 = pictureBox1.Width / 2;
            yc1 = pictureBox1.Height / 2;
            gr1 = pictureBox1.CreateGraphics();

            pen2.Width = 4;
            pen2.StartCap = LineCap.Square;
            pen2.EndCap = LineCap.ArrowAnchor;
            xc2 = pictureBox1.Width / 2;
            yc2 = pictureBox1.Height / 2;
            gr2 = pictureBox1.CreateGraphics();

            w = this.ClientSize.Width;
            h = this.ClientSize.Height;
            s = "12"; s1 = "1"; s2 = "2"; s3 = "3"; s4 = "4"; s5 = "5";
            s6 = "6"; s7 = "7"; s8 = "8"; s9 = "9"; s10 = "10"; s11 = "11";

            SizeF size = gr.MeasureString(s, f);

            textBox1.Text = dateTimePicker1.Value.Date.ToString();
            textBox2.Text = DateTime.Today.ToString();
        }
        int aaa = int.Parse(DateTime.Now.Second.ToString("00"));
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int sec = DateTime.Now.Second;
            int[] handCoord = new int[2];
            handCoord = msCoord(sec, 190);

            Graphics gr = e.Graphics;
            x = xc + (int)(r * Math.Sin(ang));
            y = yc - (int)(r * Math.Cos(ang));
            gr.DrawLine(pen, xc, yc, handCoord[0], handCoord[1]);

            Graphics gr1 = e.Graphics;
            x1 = xc1 + (int)(r1 * Math.Sin(ang1));
            y1 = yc1 - (int)(r1 * Math.Cos(ang1));
            gr1.DrawLine(pen1, xc1, yc1, x1, y1);

            Graphics gr2 = e.Graphics;
            x2 = xc2 + (int)(r2 * Math.Sin(ang2));
            y2 = yc2 - (int)(r2 * Math.Cos(ang2));
            gr2.DrawLine(pen2, xc2, yc2, x2, y2);

            Graphics gr3 = e.Graphics;
            gr3.DrawString(s, f, br, 230, 40, sf); gr3.DrawString(s6, f, br, 242, 400, sf); gr3.DrawString(s3, f, br, 430, 220, sf); gr3.DrawString(s9, f, br, 50, 220, sf);

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            ang += dangle;
            pictureBox1.Invalidate();
             
        }


        private int[] msCoord(int grad, int r)
        {
            int[] coord = new int[2];
            grad *= 6;

            if (grad >= 0 && grad <= 180)
            {
                coord[0] = xc + (int)(r * Math.Sin(Math.PI * grad / 180));
                coord[1] = yc - (int)(r * Math.Cos(Math.PI * grad / 180));
            }
            else
            {
                coord[0] = xc - (int)(r * -Math.Sin(Math.PI * grad / 180));
                coord[1] = yc - (int)(r * Math.Cos(Math.PI * grad / 180));
            }
            return coord;
        }



    }
}
