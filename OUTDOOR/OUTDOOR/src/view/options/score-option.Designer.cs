namespace OUTDOOR.src.view.options
{
    partial class score_option
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.disparosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadisticaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Score de jugador";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.disparosDataGridViewTextBoxColumn,
            this.segundosDataGridViewTextBoxColumn,
            this.puntajeDataGridViewTextBoxColumn,
            this.vidaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.estadisticaBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(34, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 279);
            this.dataGridView1.TabIndex = 5;
            // 
            // disparosDataGridViewTextBoxColumn
            // 
            this.disparosDataGridViewTextBoxColumn.DataPropertyName = "Disparos";
            this.disparosDataGridViewTextBoxColumn.HeaderText = "Disparos";
            this.disparosDataGridViewTextBoxColumn.Name = "disparosDataGridViewTextBoxColumn";
            this.disparosDataGridViewTextBoxColumn.Width = 75;
            // 
            // segundosDataGridViewTextBoxColumn
            // 
            this.segundosDataGridViewTextBoxColumn.DataPropertyName = "segundos";
            this.segundosDataGridViewTextBoxColumn.HeaderText = "segundos";
            this.segundosDataGridViewTextBoxColumn.Name = "segundosDataGridViewTextBoxColumn";
            this.segundosDataGridViewTextBoxColumn.Width = 75;
            // 
            // puntajeDataGridViewTextBoxColumn
            // 
            this.puntajeDataGridViewTextBoxColumn.DataPropertyName = "puntaje";
            this.puntajeDataGridViewTextBoxColumn.HeaderText = "puntaje";
            this.puntajeDataGridViewTextBoxColumn.Name = "puntajeDataGridViewTextBoxColumn";
            this.puntajeDataGridViewTextBoxColumn.Width = 75;
            // 
            // vidaDataGridViewTextBoxColumn
            // 
            this.vidaDataGridViewTextBoxColumn.DataPropertyName = "vida";
            this.vidaDataGridViewTextBoxColumn.HeaderText = "vida";
            this.vidaDataGridViewTextBoxColumn.Name = "vidaDataGridViewTextBoxColumn";
            this.vidaDataGridViewTextBoxColumn.Width = 75;
            // 
            // estadisticaBindingSource
            // 
            this.estadisticaBindingSource.DataSource = typeof(OUTDOOR.src.tools.objects.Estadistica);
            // 
            // score_option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "score_option";
            this.Size = new System.Drawing.Size(426, 389);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn disparosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntajeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource estadisticaBindingSource;
    }
}
