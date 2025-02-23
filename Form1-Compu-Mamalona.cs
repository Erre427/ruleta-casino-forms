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
        private int nsaldo = 100;
        Rectangle n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16, n17, n18, n19, n20, n21, n22, n23, n24, n25, n26, n27, n28, n29, n30, n31, n32, n33, n34,n35,n36;

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
        }

        private void mesajuego_Click(object sender, EventArgs e)
        {
            
        }

        private void mesajuego_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            

           

        }

        private void InicNums()
        {
            n1 = new Rectangle(88, 140, 42, 59);
            n2 = new Rectangle(88,82, 42, 59);
            n3 = new Rectangle(88, 24, 42, 59);
            n4 = new Rectangle(132, 140, 42, 59);
            n5 = new Rectangle(132, 82, 42, 59);
            n6 = new Rectangle(132, 24, 42, 59);
            n7 = new Rectangle(175, 140, 42, 59);
            n8 = new Rectangle(175, 82, 42, 59);
            n9 = new Rectangle(175, 24, 42, 59);
            n10 = new Rectangle(219, 140, 42, 59);
            n11 = new Rectangle(219, 82, 42, 59);
            n12 = new Rectangle(219, 24, 42, 59);
            n13= new Rectangle(262, 140, 42, 59);
            n14 = new Rectangle(262, 82, 42, 59);
            n15 = new Rectangle(262, 24, 42, 59);
            n16 = new Rectangle(305, 140, 42, 59);
            n17 = new Rectangle(305, 82, 42, 59);
            n18 = new Rectangle(305, 24, 42, 59);
            n19 = new Rectangle(348, 140, 42, 59);
            n20 = new Rectangle(348, 82, 42, 59);
            n21 = new Rectangle(348, 24, 42, 59);
            n22 = new Rectangle(391, 140, 42, 59);
            n23 = new Rectangle(391, 82, 42, 59);
            n24 = new Rectangle(391, 24, 42, 59);
            n25 = new Rectangle(435, 140, 42, 59);
            n26 = new Rectangle(435, 82, 42, 59);
            n27 = new Rectangle(435, 24, 42, 59);
            n28 = new Rectangle(479, 140, 42, 59);
            n29 = new Rectangle(479, 82, 42, 59);
            n30 = new Rectangle(479, 24, 42, 59);
            n31 = new Rectangle(521, 140, 42, 59);
            n32 = new Rectangle(521, 82, 42, 59);
            n33 = new Rectangle(521, 24, 42, 59);
            n34 = new Rectangle(564, 140, 42, 59);
            n35 = new Rectangle(564, 82, 42, 59);
            n36 = new Rectangle(564, 24, 42, 59);
        }
    }
}
