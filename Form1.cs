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
                    check = false;
                    btnrojo.Text = "X";
                    AsignAp();
                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
            
            
        }

        private void Random()
        {

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
                    check = false;
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
                    check = false;
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
                    check = false;
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
                    check = false;
                    n2.Text = "XX\nXX";
                    AsignAp();

                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n3_Click(object sender, EventArgs e)
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
                    token = "3";
                    n3.Enabled = false;
                    check = false;
                    n3.Text = "XX\nXX";
                    AsignAp();

                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n4_Click(object sender, EventArgs e)
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
                    token = "4";
                    n4.Enabled = false;
                    check = false;
                    n4.Text = "XX\nXX";
                    AsignAp();

                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n5_Click(object sender, EventArgs e)
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
                    token = "5";
                    n5.Enabled = false;
                    check = false;
                    n5.Text = "XX\nXX";
                    AsignAp();

                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n6_Click(object sender, EventArgs e)
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
                    token = "6";
                    n6.Enabled = false;
                    check = false;
                    n6.Text = "XX\nXX";
                    AsignAp();

                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n7_Click(object sender, EventArgs e)
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
                    token = "7";
                    n7.Enabled = false;
                    check = false;
                    n7.Text = "XX\nXX";
                    AsignAp();

                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n8_Click(object sender, EventArgs e)
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
                    token = "8";
                    n8.Enabled = false;
                    check = false;
                    n8.Text = "XX\nXX";
                    AsignAp();

                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n9_Click(object sender, EventArgs e)
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
                    token = "9";
                    n9.Enabled = false;
                    check = false;
                    n9.Text = "XX\nXX";
                    AsignAp();

                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n10_Click(object sender, EventArgs e)
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
                    token = "10";
                    n10.Enabled = false;
                    check = false;
                    n10.Text = "XX\nXX";
                    AsignAp();

                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n11_Click(object sender, EventArgs e)
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
                    token = "11";
                    n11.Enabled = false;
                    check = false;
                    n11.Text = "XX\nXX";
                    AsignAp();

                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n12_Click(object sender, EventArgs e)
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
                    token = "12";
                    n12.Enabled = false;
                    check = false;
                    n12.Text = "XX\nXX";
                    AsignAp();

                }

            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n13_Click(object sender, EventArgs e)
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
                    token = "13";
                    n13.Enabled = false;
                    check = false;
                    n13.Text = "13\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n14_Click(object sender, EventArgs e)
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
                    token = "14";
                    n14.Enabled = false;
                    check = false;
                    n14.Text = "14\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n15_Click(object sender, EventArgs e)
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
                    token = "15";
                    n15.Enabled = false;
                    check = false;
                    n15.Text = "15\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n16_Click(object sender, EventArgs e)
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
                    token = "16";
                    n16.Enabled = false;
                    check = false;
                    n16.Text = "16\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n17_Click(object sender, EventArgs e)
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
                    token = "17";
                    n17.Enabled = false;
                    check = false;
                    n17.Text = "17\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n18_Click(object sender, EventArgs e)
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
                    token = "18";
                    n18.Enabled = false;
                    check = false;
                    n18.Text = "18\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n19_Click(object sender, EventArgs e)
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
                    token = "19";
                    n19.Enabled = false;
                    check = false;
                    n19.Text = "19\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n20_Click(object sender, EventArgs e)
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
                    token = "20";
                    n20.Enabled = false;
                    check = false;
                    n20.Text = "20\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n21_Click(object sender, EventArgs e)
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
                    token = "21";
                    n21.Enabled = false;
                    check = false;
                    n21.Text = "21\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n22_Click(object sender, EventArgs e)
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
                    token = "22";
                    n22.Enabled = false;
                    check = false;
                    n22.Text = "22\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n23_Click(object sender, EventArgs e)
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
                    token = "23";
                    n23.Enabled = false;
                    check = false;
                    n23.Text = "23\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n24_Click(object sender, EventArgs e)
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
                    token = "24";
                    n24.Enabled = false;
                    check = false;
                    n24.Text = "24\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n25_Click(object sender, EventArgs e)
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
                    token = "25";
                    n25.Enabled = false;
                    check = false;
                    n25.Text = "25\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n26_Click(object sender, EventArgs e)
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
                    token = "26";
                    n26.Enabled = false;
                    check = false;
                    n26.Text = "26\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n27_Click(object sender, EventArgs e)
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
                    token = "27";
                    n27.Enabled = false;
                    check = false;
                    n27.Text = "27\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n28_Click(object sender, EventArgs e)
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
                    token = "28";
                    n28.Enabled = false;
                    check = false;
                    n28.Text = "28\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n29_Click(object sender, EventArgs e)
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
                    token = "29";
                    n29.Enabled = false;
                    check = false;
                    n29.Text = "29\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n30_Click(object sender, EventArgs e)
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
                    token = "30";
                    n30.Enabled = false;
                    check = false;
                    n30.Text = "30\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n31_Click(object sender, EventArgs e)
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
                    token = "31";
                    n31.Enabled = false;
                    check = false;
                    n31.Text = "31\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n32_Click(object sender, EventArgs e)
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
                    token = "32";
                    n32.Enabled = false;
                    check = false;
                    n32.Text = "32\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n33_Click(object sender, EventArgs e)
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
                    token = "33";
                    n33.Enabled = false;
                    check = false;
                    n33.Text = "33\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n34_Click(object sender, EventArgs e)
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
                    token = "34";
                    n34.Enabled = false;
                    check = false;
                    n34.Text = "34\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n35_Click(object sender, EventArgs e)
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
                    token = "35";
                    n35.Enabled = false;
                    check = false;
                    n35.Text = "35\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void n36_Click(object sender, EventArgs e)
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
                    token = "36";
                    n36.Enabled = false;
                    check = false;
                    n36.Text = "36\nXX";
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
