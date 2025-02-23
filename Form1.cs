using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCasino
{
    public partial class Form1 : Form
    {
        List<int> apuesta = new List<int>();
        List<Rectangle> numeros = new List<Rectangle>();
        private int nsaldo = 100;
        private bool banap = true;
        private int ficha;
        
        
        

        private void a100_Click(object sender, EventArgs e)
        {
            ficha = 100;
            banap = false;
        }

        private void a80_Click(object sender, EventArgs e)
        {
            ficha = 80;
            banap = false;
        }

        private void a50_Click(object sender, EventArgs e)
        {
            ficha = 50;
            banap = false;
        }

        private void a25_Click(object sender, EventArgs e)
        {
            ficha = 25;
            banap = false;
        }


        private void a10_Click(object sender, EventArgs e)
        {
            ficha = 10;
            banap = false;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio.Visible = false;
            mesa.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicNums();
            inicio.Visible = true;
            mesa.Visible = false;
            ayuda.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            mesa.Visible = false;
            ayuda.Visible = true;
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            ayuda.Visible=false;
            mesa.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saldo.Text = nsaldo.ToString();
            DesFichas();
            
        }

        private void mesajuego_MouseClick(object sender, MouseEventArgs e)
        {
            
            int x = e.X;
            int y = e.Y;

            AsignAp(e.X,e.Y);

        }
        private void RestarSaldo(int ficha)
        {
            nsaldo = nsaldo - ficha;
        }
        private void DesFichas()
        {
            if(banap == false)
            {
                a10.Enabled = false;
                a25.Enabled = false;
                a50.Enabled = false;
                a80.Enabled = false;
                a100.Enabled = false;
            }
            else
            {
                a10.Enabled = true;
                a25.Enabled = true;
                a50.Enabled = true;
                a80.Enabled = true;
                a100.Enabled = true;
            }
        }

        private void AsignAp(int x, int y)
        {
            if (nsaldo > 0 && ficha <= nsaldo)
            {
                foreach (var i in numeros)
                {

                    if (i.Contains(x, y))
                    {
                        apuesta.Add(ficha);
                        RestarSaldo(ficha);
                        banap = true;
                        ficha = 0;
                    }
                    
                }
                
            }
            
            else
            {
                MessageBox.Show("Saldo insuficiente");
                banap = true;
            }
        }
        private void InicNums()
        {
            numeros.Add(new Rectangle(88, 140, 42, 59));
            numeros.Add(new Rectangle(88, 82, 42, 59));
            numeros.Add(new Rectangle(88, 24, 42, 59));
            numeros.Add(new Rectangle(132, 140, 42, 59));
            numeros.Add(new Rectangle(132, 82, 42, 59));
            numeros.Add(new Rectangle(132, 24, 42, 59));
            numeros.Add(new Rectangle(175, 140, 42, 59));
            numeros.Add(new Rectangle(175, 82, 42, 59));
            numeros.Add(new Rectangle(175, 24, 42, 59));
            numeros.Add(new Rectangle(219, 140, 42, 59));
            numeros.Add(new Rectangle(219, 82, 42, 59));
            numeros.Add(new Rectangle(219, 24, 42, 59));
            numeros.Add(new Rectangle(262, 140, 42, 59));
            numeros.Add(new Rectangle(262, 82, 42, 59));
            numeros.Add(new Rectangle(262, 24, 42, 59));
            numeros.Add(new Rectangle(305, 140, 42, 59));
            numeros.Add(new Rectangle(305, 82, 42, 59));
            numeros.Add(new Rectangle(305, 24, 42, 59));
            numeros.Add(new Rectangle(348, 140, 42, 59));
            numeros.Add(new Rectangle(348, 82, 42, 59));
            numeros.Add(new Rectangle(348, 24, 42, 59));
            numeros.Add(new Rectangle(391, 140, 42, 59));
            numeros.Add(new Rectangle(391, 82, 42, 59));
            numeros.Add(new Rectangle(391, 24, 42, 59));
            numeros.Add(new Rectangle(435, 140, 42, 59));
            numeros.Add(new Rectangle(435, 82, 42, 59));
            numeros.Add(new Rectangle(435, 24, 42, 59));
            numeros.Add(new Rectangle(479, 140, 42, 59));
            numeros.Add(new Rectangle(479, 82, 42, 59));
            numeros.Add(new Rectangle(479, 24, 42, 59));
            numeros.Add(new Rectangle(521, 140, 42, 59));
            numeros.Add(new Rectangle(521, 82, 42, 59));
            numeros.Add(new Rectangle(521, 24, 42, 59));
            numeros.Add(new Rectangle(564, 140, 42, 59));
            numeros.Add(new Rectangle(564, 82, 42, 59));
            numeros.Add(new Rectangle(564, 24, 42, 59));
        }

    }
}
