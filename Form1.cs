using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCasino
{
    public partial class Form1 : Form
    {
        
        Dictionary<int, string> apuesta = new Dictionary<int, string>();
        Random rnd = new Random();
        private int nsaldo = 100;
        private int ficha;
        private string color;
        private bool check = false;
        private bool finalcheck = false;
        private string token;
        private int nresultado;
        private int multiplicador;
        private int casa;
        int id;

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            anim.Visible = false;
            CalcApuesta();
            timer2.Stop();

        }

        private void CalcApuesta()
        {
            // Generar un número aleatorio entre 0 y 36 (resultado de la ruleta)
            nresultado = rnd.Next(0, 37);

            // Revisar si el número es rojo o negro
            bool esRojo = (nresultado != 0) && (nresultado % 2 != 0);
            bool esNegro = (nresultado != 0) && (nresultado % 2 == 0);

            

            int saldoInicial = nsaldo; // Guardar saldo antes de modificarlo

            // Revisar las apuestas realizadas y calcular ganancias
            if (apuesta.ContainsKey(nresultado))
            {
                ganador.Visible = true;
                multiplicador = (nresultado == 0) ? 35 : 36;
                nsaldo += casa * multiplicador;
                nganancia1.Text = nsaldo.ToString();
                nganador1.Text = nresultado.ToString();
            }
            else if ((apuesta.ContainsValue("btnrojo") && esRojo) || (apuesta.ContainsValue("btnnegro") && esNegro))
            {
                ganador.Visible = true;
                multiplicador = 2;
                nsaldo += casa * multiplicador;
                nganancia1.Text = nsaldo.ToString();
                nganador1.Text = nresultado.ToString();
            }
            else
            {
                nganador2.Text = nresultado.ToString();
                perdedor.Visible = true;
            }

           
            saldo.Text = nsaldo.ToString();

            // Reset de apuestas
            apuesta.Clear();
            finalcheck = false;

            // Habilitar los botones de apuesta nuevamente
            ResetApuestas();
        }

        private void ResetApuestas()
        {
            btnrojo.Enabled = true;
            btnnegro.Enabled = true;
            btncero.Enabled = true;

            for (int i = 1; i <= 36; i++)
            {
                Control btn = this.Controls.Find($"n{i}", true).FirstOrDefault();
                if (btn != null) btn.Enabled = true;
            }
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            if (finalcheck == false)
            {
                MessageBox.Show("Apueste antes de girar la ruleta!");
            }
            else
            {
                ruleta.Visible = true;
                timer2.Start();
            }

        }

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
            ganador.Visible = false;
            perdedor.Visible = false;
            
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
            casa += ficha;
            nsaldo = nsaldo - ficha;
        }
        

        private void AsignAp()
        {
            
            apuesta.Add(id, color);
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

                    color = "btnrojo";
                    token = "rojo";
                    id = -2;
                    btnrojo.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    color = "btnnegro";
                    token = "negro";
                    id = -1;
                    btnnegro.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 0;
                    btncero.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 1;
                    n1.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 2;
                    n2.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 3;
                    n3.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 4;
                    n4.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 5;
                    finalcheck = true;
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
                    id = 6;
                    n6.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 7;
                    finalcheck = true;
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
                    id = 8;
                    n8.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 9;
                    n9.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 10;
                    n10.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 11;
                    n11.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 12;
                    n12.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 13;
                    n13.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 14;
                    n14.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 15;
                    n15.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 16;
                    n16.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 17;
                    n17.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 18;
                    n18.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 19;
                    n19.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 20;
                    n20.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 21;
                    n21.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 22;
                    n22.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 23;
                    n23.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 24;
                    n24.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 25;
                    n25.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 26;
                    n26.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 27;
                    n27.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 28;
                    n28.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 29;
                    n29.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 30;
                    n30.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 31;
                    n31.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 32;
                    n32.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 33;
                    n33.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 34;
                    n34.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 35;
                    n35.Enabled = false;
                    check = false;
                    finalcheck = true;
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
                    id = 36;
                    n36.Enabled = false;
                    check = false;
                    finalcheck = true;
                    n36.Text = "36\nXX";
                    AsignAp();
                }
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ruleta.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ruleta.Visible = false;
        }
    }
}
