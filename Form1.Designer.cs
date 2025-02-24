namespace PracticaCasino
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inicio = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.fondo = new System.Windows.Forms.PictureBox();
            this.mesa = new System.Windows.Forms.Panel();
            this.btnayuda = new System.Windows.Forms.Button();
            this.a100 = new System.Windows.Forms.Button();
            this.a80 = new System.Windows.Forms.Button();
            this.a50 = new System.Windows.Forms.Button();
            this.a25 = new System.Windows.Forms.Button();
            this.a10 = new System.Windows.Forms.Button();
            this.saldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mesajuego = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ayuda = new System.Windows.Forms.Panel();
            this.btnvolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            this.mesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesajuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ayuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(898, 552);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // inicio
            // 
            this.inicio.Controls.Add(this.lblTitulo);
            this.inicio.Controls.Add(this.btnJugar);
            this.inicio.Controls.Add(this.pictureBox1);
            this.inicio.Controls.Add(this.fondo);
            this.inicio.Location = new System.Drawing.Point(0, 0);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(898, 552);
            this.inicio.TabIndex = 1;
            this.inicio.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Gray;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(231, 191);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(425, 42);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Bienvenido a la Ruleta!";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(340, 265);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(193, 49);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.button1_Click);
            // 
            // fondo
            // 
            this.fondo.Image = ((System.Drawing.Image)(resources.GetObject("fondo.Image")));
            this.fondo.Location = new System.Drawing.Point(-21, 34);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(898, 552);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondo.TabIndex = 0;
            this.fondo.TabStop = false;
            // 
            // mesa
            // 
            this.mesa.BackColor = System.Drawing.Color.Transparent;
            this.mesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mesa.Controls.Add(this.button32);
            this.mesa.Controls.Add(this.button33);
            this.mesa.Controls.Add(this.button34);
            this.mesa.Controls.Add(this.button35);
            this.mesa.Controls.Add(this.button36);
            this.mesa.Controls.Add(this.button37);
            this.mesa.Controls.Add(this.button17);
            this.mesa.Controls.Add(this.button18);
            this.mesa.Controls.Add(this.button19);
            this.mesa.Controls.Add(this.button20);
            this.mesa.Controls.Add(this.button21);
            this.mesa.Controls.Add(this.button22);
            this.mesa.Controls.Add(this.button23);
            this.mesa.Controls.Add(this.button24);
            this.mesa.Controls.Add(this.button25);
            this.mesa.Controls.Add(this.button26);
            this.mesa.Controls.Add(this.button27);
            this.mesa.Controls.Add(this.button28);
            this.mesa.Controls.Add(this.button29);
            this.mesa.Controls.Add(this.button30);
            this.mesa.Controls.Add(this.button31);
            this.mesa.Controls.Add(this.button14);
            this.mesa.Controls.Add(this.button15);
            this.mesa.Controls.Add(this.button16);
            this.mesa.Controls.Add(this.button11);
            this.mesa.Controls.Add(this.button12);
            this.mesa.Controls.Add(this.button13);
            this.mesa.Controls.Add(this.button8);
            this.mesa.Controls.Add(this.button9);
            this.mesa.Controls.Add(this.button10);
            this.mesa.Controls.Add(this.button5);
            this.mesa.Controls.Add(this.button6);
            this.mesa.Controls.Add(this.button7);
            this.mesa.Controls.Add(this.button4);
            this.mesa.Controls.Add(this.button3);
            this.mesa.Controls.Add(this.button2);
            this.mesa.Controls.Add(this.button1);
            this.mesa.Controls.Add(this.btnayuda);
            this.mesa.Controls.Add(this.a100);
            this.mesa.Controls.Add(this.a80);
            this.mesa.Controls.Add(this.a50);
            this.mesa.Controls.Add(this.a25);
            this.mesa.Controls.Add(this.a10);
            this.mesa.Controls.Add(this.saldo);
            this.mesa.Controls.Add(this.label1);
            this.mesa.Controls.Add(this.mesajuego);
            this.mesa.Controls.Add(this.pictureBox2);
            this.mesa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mesa.Location = new System.Drawing.Point(0, 0);
            this.mesa.Name = "mesa";
            this.mesa.Size = new System.Drawing.Size(898, 552);
            this.mesa.TabIndex = 3;
            // 
            // btnayuda
            // 
            this.btnayuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnayuda.Location = new System.Drawing.Point(802, 12);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Size = new System.Drawing.Size(75, 23);
            this.btnayuda.TabIndex = 9;
            this.btnayuda.Text = "Ayuda";
            this.btnayuda.UseVisualStyleBackColor = true;
            this.btnayuda.Click += new System.EventHandler(this.btnayuda_Click);
            // 
            // a100
            // 
            this.a100.Location = new System.Drawing.Point(647, 455);
            this.a100.Name = "a100";
            this.a100.Size = new System.Drawing.Size(75, 75);
            this.a100.TabIndex = 8;
            this.a100.Text = "$100";
            this.a100.UseVisualStyleBackColor = true;
            this.a100.Click += new System.EventHandler(this.a100_Click);
            // 
            // a80
            // 
            this.a80.Location = new System.Drawing.Point(545, 455);
            this.a80.Name = "a80";
            this.a80.Size = new System.Drawing.Size(75, 75);
            this.a80.TabIndex = 7;
            this.a80.Text = "$80";
            this.a80.UseVisualStyleBackColor = true;
            this.a80.Click += new System.EventHandler(this.a80_Click);
            // 
            // a50
            // 
            this.a50.Location = new System.Drawing.Point(440, 455);
            this.a50.Name = "a50";
            this.a50.Size = new System.Drawing.Size(75, 75);
            this.a50.TabIndex = 6;
            this.a50.Text = "$50";
            this.a50.UseVisualStyleBackColor = true;
            this.a50.Click += new System.EventHandler(this.a50_Click);
            // 
            // a25
            // 
            this.a25.Location = new System.Drawing.Point(335, 455);
            this.a25.Name = "a25";
            this.a25.Size = new System.Drawing.Size(75, 75);
            this.a25.TabIndex = 5;
            this.a25.Text = "$25";
            this.a25.UseVisualStyleBackColor = true;
            this.a25.Click += new System.EventHandler(this.a25_Click);
            // 
            // a10
            // 
            this.a10.Location = new System.Drawing.Point(233, 455);
            this.a10.Name = "a10";
            this.a10.Size = new System.Drawing.Size(75, 75);
            this.a10.TabIndex = 4;
            this.a10.Text = "$10";
            this.a10.UseVisualStyleBackColor = true;
            this.a10.Click += new System.EventHandler(this.a10_Click);
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saldo.Location = new System.Drawing.Point(469, 34);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(25, 25);
            this.saldo.TabIndex = 3;
            this.saldo.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(373, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saldo: $ ";
            // 
            // mesajuego
            // 
            this.mesajuego.BackColor = System.Drawing.Color.SaddleBrown;
            this.mesajuego.ImageLocation = "";
            this.mesajuego.Location = new System.Drawing.Point(133, 88);
            this.mesajuego.Name = "mesajuego";
            this.mesajuego.Size = new System.Drawing.Size(637, 336);
            this.mesajuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mesajuego.TabIndex = 1;
            this.mesajuego.TabStop = false;
            this.mesajuego.WaitOnLoad = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(895, 565);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // ayuda
            // 
            this.ayuda.Controls.Add(this.btnvolver);
            this.ayuda.Controls.Add(this.label3);
            this.ayuda.Controls.Add(this.label2);
            this.ayuda.Controls.Add(this.pictureBox4);
            this.ayuda.Location = new System.Drawing.Point(0, 0);
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(898, 552);
            this.ayuda.TabIndex = 10;
            // 
            // btnvolver
            // 
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Location = new System.Drawing.Point(340, 468);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(204, 49);
            this.btnvolver.TabIndex = 12;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(782, 320);
            this.label3.TabIndex = 11;
            this.label3.Text = resources.GetString("label3.Text");
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "¿Como Jugar?";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, -13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(906, 573);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(173, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 67);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(238, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 56);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(238, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 56);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 56);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(273, 159);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 56);
            this.button5.TabIndex = 16;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(273, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 56);
            this.button6.TabIndex = 15;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(273, 271);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 56);
            this.button7.TabIndex = 14;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(308, 159);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 56);
            this.button8.TabIndex = 19;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(308, 215);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 56);
            this.button9.TabIndex = 18;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(308, 271);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(35, 56);
            this.button10.TabIndex = 17;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(343, 159);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 56);
            this.button11.TabIndex = 22;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(343, 215);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(35, 56);
            this.button12.TabIndex = 21;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(343, 271);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(35, 56);
            this.button13.TabIndex = 20;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(378, 159);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(35, 56);
            this.button14.TabIndex = 25;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(378, 215);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(35, 56);
            this.button15.TabIndex = 24;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(378, 271);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(35, 56);
            this.button16.TabIndex = 23;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(553, 159);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(35, 56);
            this.button17.TabIndex = 40;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(553, 215);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(35, 56);
            this.button18.TabIndex = 39;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(553, 271);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(35, 56);
            this.button19.TabIndex = 38;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(518, 159);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(35, 56);
            this.button20.TabIndex = 37;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(518, 215);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(35, 56);
            this.button21.TabIndex = 36;
            this.button21.Text = "button21";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(518, 271);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(35, 56);
            this.button22.TabIndex = 35;
            this.button22.Text = "button22";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(483, 159);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(35, 56);
            this.button23.TabIndex = 34;
            this.button23.Text = "button23";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(483, 215);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(35, 56);
            this.button24.TabIndex = 33;
            this.button24.Text = "button24";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(483, 271);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(35, 56);
            this.button25.TabIndex = 32;
            this.button25.Text = "button25";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(448, 159);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(35, 56);
            this.button26.TabIndex = 31;
            this.button26.Text = "button26";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(448, 215);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(35, 56);
            this.button27.TabIndex = 30;
            this.button27.Text = "button27";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(448, 271);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(35, 56);
            this.button28.TabIndex = 29;
            this.button28.Text = "button28";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(413, 159);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(35, 56);
            this.button29.TabIndex = 28;
            this.button29.Text = "button29";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(413, 215);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(35, 56);
            this.button30.TabIndex = 27;
            this.button30.Text = "button30";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(413, 271);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(35, 56);
            this.button31.TabIndex = 26;
            this.button31.Text = "button31";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(623, 159);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(35, 56);
            this.button32.TabIndex = 46;
            this.button32.Text = "button32";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(623, 215);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(35, 56);
            this.button33.TabIndex = 45;
            this.button33.Text = "button33";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(623, 271);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(35, 56);
            this.button34.TabIndex = 44;
            this.button34.Text = "button34";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(588, 159);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(35, 56);
            this.button35.TabIndex = 43;
            this.button35.Text = "button35";
            this.button35.UseVisualStyleBackColor = true;
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(588, 215);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(35, 56);
            this.button36.TabIndex = 42;
            this.button36.Text = "button36";
            this.button36.UseVisualStyleBackColor = true;
            // 
            // button37
            // 
            this.button37.Location = new System.Drawing.Point(588, 271);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(35, 56);
            this.button37.TabIndex = 41;
            this.button37.Text = "button37";
            this.button37.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 542);
            this.Controls.Add(this.mesa);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.ayuda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.inicio.ResumeLayout(false);
            this.inicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            this.mesa.ResumeLayout(false);
            this.mesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mesajuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ayuda.ResumeLayout(false);
            this.ayuda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel inicio;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel mesa;
        private System.Windows.Forms.PictureBox mesajuego;
        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button a10;
        private System.Windows.Forms.Button a50;
        private System.Windows.Forms.Button a25;
        private System.Windows.Forms.Button a100;
        private System.Windows.Forms.Button a80;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel ayuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

