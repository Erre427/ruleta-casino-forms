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
            this.mesajuego.Image = ((System.Drawing.Image)(resources.GetObject("mesajuego.Image")));
            this.mesajuego.ImageLocation = "";
            this.mesajuego.Location = new System.Drawing.Point(115, 82);
            this.mesajuego.Name = "mesajuego";
            this.mesajuego.Size = new System.Drawing.Size(679, 336);
            this.mesajuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mesajuego.TabIndex = 1;
            this.mesajuego.TabStop = false;
            this.mesajuego.WaitOnLoad = true;
            this.mesajuego.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mesajuego_MouseClick);
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
    }
}

