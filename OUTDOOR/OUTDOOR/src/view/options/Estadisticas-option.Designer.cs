namespace OUTDOOR.src.view.options
{
    partial class Estadisticas_option
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_diparos = new System.Windows.Forms.Label();
            this.lbl_segundos = new System.Windows.Forms.Label();
            this.lbl_puntos = new System.Windows.Forms.Label();
            this.lbl_mejorPartida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estadisticas de jugador";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(27, 39);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Disparos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Segundos";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Puntaje";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(259, 177);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // lbl_diparos
            // 
            this.lbl_diparos.AutoSize = true;
            this.lbl_diparos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_diparos.ForeColor = System.Drawing.Color.White;
            this.lbl_diparos.Location = new System.Drawing.Point(4, 235);
            this.lbl_diparos.Name = "lbl_diparos";
            this.lbl_diparos.Size = new System.Drawing.Size(74, 19);
            this.lbl_diparos.TabIndex = 5;
            this.lbl_diparos.Text = "Disparos:";
            // 
            // lbl_segundos
            // 
            this.lbl_segundos.AutoSize = true;
            this.lbl_segundos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_segundos.ForeColor = System.Drawing.Color.White;
            this.lbl_segundos.Location = new System.Drawing.Point(3, 269);
            this.lbl_segundos.Name = "lbl_segundos";
            this.lbl_segundos.Size = new System.Drawing.Size(78, 19);
            this.lbl_segundos.TabIndex = 6;
            this.lbl_segundos.Text = "Segundos:";
            // 
            // lbl_puntos
            // 
            this.lbl_puntos.AutoSize = true;
            this.lbl_puntos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_puntos.ForeColor = System.Drawing.Color.White;
            this.lbl_puntos.Location = new System.Drawing.Point(23, 298);
            this.lbl_puntos.Name = "lbl_puntos";
            this.lbl_puntos.Size = new System.Drawing.Size(59, 19);
            this.lbl_puntos.TabIndex = 7;
            this.lbl_puntos.Text = "Puntos:";
            // 
            // lbl_mejorPartida
            // 
            this.lbl_mejorPartida.AutoSize = true;
            this.lbl_mejorPartida.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_mejorPartida.ForeColor = System.Drawing.Color.White;
            this.lbl_mejorPartida.Location = new System.Drawing.Point(15, 338);
            this.lbl_mejorPartida.Name = "lbl_mejorPartida";
            this.lbl_mejorPartida.Size = new System.Drawing.Size(59, 19);
            this.lbl_mejorPartida.TabIndex = 8;
            this.lbl_mejorPartida.Text = "Puntos:";
            // 
            // Estadisticas_option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lbl_mejorPartida);
            this.Controls.Add(this.lbl_puntos);
            this.Controls.Add(this.lbl_segundos);
            this.Controls.Add(this.lbl_diparos);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Name = "Estadisticas_option";
            this.Size = new System.Drawing.Size(426, 389);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_diparos;
        private System.Windows.Forms.Label lbl_segundos;
        private System.Windows.Forms.Label lbl_puntos;
        private System.Windows.Forms.Label lbl_mejorPartida;

    }
}
