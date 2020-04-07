namespace OUTDOOR.src.view.pages
{
    partial class Juego_page
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.inicio = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Label();
            this.fin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_objetivo = new OUTDOOR.src.view.components.component_objetivo();
            this.pb_jugador = new OUTDOOR.src.view.components.componet_jugador();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(626, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 389);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(131, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "En linea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "En linea";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::OUTDOOR.Properties.Resources.toolbar_En_linea;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(7)))), ((int)(((byte)(35)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 308);
            this.panel3.TabIndex = 0;
            // 
            // inicio
            // 
            this.inicio.AutoSize = true;
            this.inicio.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.inicio.ForeColor = System.Drawing.Color.White;
            this.inicio.Location = new System.Drawing.Point(137, 188);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(326, 29);
            this.inicio.TabIndex = 7;
            this.inicio.Text = "Presiona enter para iniciar";
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.tiempo.ForeColor = System.Drawing.Color.White;
            this.tiempo.Location = new System.Drawing.Point(2, 0);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(57, 16);
            this.tiempo.TabIndex = 10;
            this.tiempo.Text = "tiempo:";
            // 
            // fin
            // 
            this.fin.AutoSize = true;
            this.fin.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.fin.ForeColor = System.Drawing.Color.White;
            this.fin.Location = new System.Drawing.Point(322, 340);
            this.fin.Name = "fin";
            this.fin.Size = new System.Drawing.Size(303, 29);
            this.fin.TabIndex = 11;
            this.fin.Text = "Presiona enter para salir";
            this.fin.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(479, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Presiona esc para salir";
            // 
            // pb_objetivo
            // 
            this.pb_objetivo.BackColor = System.Drawing.Color.Transparent;
            this.pb_objetivo.Location = new System.Drawing.Point(269, 19);
            this.pb_objetivo.Name = "pb_objetivo";
            this.pb_objetivo.Size = new System.Drawing.Size(47, 64);
            this.pb_objetivo.TabIndex = 9;
            this.pb_objetivo.Vida = 100;
            this.pb_objetivo.Visible = false;
            // 
            // pb_jugador
            // 
            this.pb_jugador.BackColor = System.Drawing.Color.Transparent;
            this.pb_jugador.Location = new System.Drawing.Point(269, 319);
            this.pb_jugador.Name = "pb_jugador";
            this.pb_jugador.Size = new System.Drawing.Size(47, 70);
            this.pb_jugador.TabIndex = 8;
            this.pb_jugador.Vida = 100;
            this.pb_jugador.Visible = false;
            this.pb_jugador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Juego_page_KeyPress);
            // 
            // Juego_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(826, 389);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fin);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.pb_objetivo);
            this.Controls.Add(this.pb_jugador);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Juego_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego_page";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Juego_page_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private components.componet_jugador pb_jugador;
        private components.component_objetivo pb_objetivo;
        private System.Windows.Forms.Label inicio;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.Label fin;
        private System.Windows.Forms.Label label2;
    }
}