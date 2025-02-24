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

namespace PracticaCasino
{
    public partial class Form1 : Form
    {
        
        Dictionary<string, string> apuesta = new Dictionary<string, string>();
        private int nsaldo = 100;
        private int ficha;
        private string color;
        private bool check = false;
        private string token;
        
        

        private void a100_Click(object sender, EventArgs e)
        {
            ficha = 100;
            check = true;
        }

        private void a80_Click(object sender, EventArgs e)
        {
            ficha = 80;
            check = true;
        }

        private void a50_Click(object sender, EventArgs e)
        {
            ficha = 50;
            check = true;
        }

        private void a25_Click(object sender, EventArgs e)
        {
            ficha = 25;
            check = true;
        }


        private void a10_Click(object sender, EventArgs e)
        {
            ficha = 10;
            check = true;
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
            
        }

        
        private void RestarSaldo(int ficha)
        {
            nsaldo = nsaldo - ficha;
        }
        

        private void AsignAp()
        {
            
            apuesta.Add(token, color);
            string log = $"Apuesta de ${ficha} al {token}";
            logapuestas.Text = log + Environment.NewLine + logapuestas.Text;
            RestarSaldo(ficha);
            ficha = 0;
            color = null;
        }

        private void btnrojo_Click(object sender, EventArgs e)
        {
            if (nsaldo > 0 && ficha <= nsaldo)
            {
                if (check == false)
                {
                    MessageBox.Show("Elija una apuesta primero");
                }
                else
                {

                    color = "rojo";
                    token = "rojo";
                    btnrojo.Enabled = false;
                    btnrojo.Text = "X";
                    AsignAp();
                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
            
            
        }

        private void brnnegro_Click(object sender, EventArgs e)
        {
            if (nsaldo > 0 && ficha <= nsaldo)
            {

                if (check == false)
                {
                    MessageBox.Show("Elija una apuesta primero");
                }
                else
                {
                    color = "negro";
                    token = "negro";
                    btnnegro.Enabled = false;
                    btnnegro.Text = "XX\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (nsaldo > 0 && ficha <= nsaldo)
            {
                if (check == false)
                {
                    MessageBox.Show("Elija una apuesta primero");
                }
                else
                {
                    color = "cero";
                    token = "0";
                    btncero.Enabled = false;
                    btncero.Text = "XX\nXX";
                    AsignAp();

                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
            
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (nsaldo > 0 && ficha <= nsaldo)
            {
                if (check == false)
                {
                    MessageBox.Show("Elija una apuesta primero");
                }
                else
                {
                    color = "rojo";
                    token = "1";
                    n1.Enabled = false;
                    n1.Text = "XX\nXX";
                    AsignAp();

                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (nsaldo > 0 && ficha <= nsaldo)
            {
                if (check == false)
                {
                    MessageBox.Show("Elija una apuesta primero");
                }
                else
                {
                    color = "negro";
                    token = "2";
                    n2.Enabled = false;
                    n2.Text = "XX\nXX";
                    AsignAp();

                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }
    }
}
