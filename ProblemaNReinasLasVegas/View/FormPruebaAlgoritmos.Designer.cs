namespace ProblemaNReinasLasVegas
{
    partial class FormPruebaAlgoritmos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.EjecutarAlgoritmoBtn = new System.Windows.Forms.Button();
            this.GridViewResultadosData = new System.Windows.Forms.DataGridView();
            this.spinBoxNReinas = new System.Windows.Forms.NumericUpDown();
            this.Algoritmo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewResultadosData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxNReinas)).BeginInit();
            this.SuspendLayout();
            // 
            // EjecutarAlgoritmoBtn
            // 
            this.EjecutarAlgoritmoBtn.Location = new System.Drawing.Point(393, 201);
            this.EjecutarAlgoritmoBtn.Name = "EjecutarAlgoritmoBtn";
            this.EjecutarAlgoritmoBtn.Size = new System.Drawing.Size(75, 23);
            this.EjecutarAlgoritmoBtn.TabIndex = 0;
            this.EjecutarAlgoritmoBtn.Text = "Ejecutar";
            this.EjecutarAlgoritmoBtn.UseVisualStyleBackColor = true;
            this.EjecutarAlgoritmoBtn.Click += new System.EventHandler(this.EjecutarAlgoritmoBtn_Click);
            // 
            // GridViewResultadosData
            // 
            this.GridViewResultadosData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewResultadosData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Algoritmo,
            this.Solucion,
            this.Tiempo});
            this.GridViewResultadosData.Location = new System.Drawing.Point(13, 12);
            this.GridViewResultadosData.Name = "GridViewResultadosData";
            this.GridViewResultadosData.Size = new System.Drawing.Size(469, 150);
            this.GridViewResultadosData.TabIndex = 1;
            // 
            // spinBoxNReinas
            // 
            this.spinBoxNReinas.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinBoxNReinas.Location = new System.Drawing.Point(296, 204);
            this.spinBoxNReinas.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spinBoxNReinas.Name = "spinBoxNReinas";
            this.spinBoxNReinas.Size = new System.Drawing.Size(50, 20);
            this.spinBoxNReinas.TabIndex = 2;
            this.spinBoxNReinas.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Algoritmo
            // 
            this.Algoritmo.HeaderText = "Algoritmo";
            this.Algoritmo.Name = "Algoritmo";
            this.Algoritmo.Width = 125;
            // 
            // Solucion
            // 
            this.Solucion.HeaderText = "Solucion";
            this.Solucion.Name = "Solucion";
            this.Solucion.Width = 150;
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Width = 150;
            // 
            // FormPruebaAlgoritmos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 250);
            this.Controls.Add(this.spinBoxNReinas);
            this.Controls.Add(this.GridViewResultadosData);
            this.Controls.Add(this.EjecutarAlgoritmoBtn);
            this.Name = "FormPruebaAlgoritmos";
            this.Text = "Prueba Algoritmo N Queens";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewResultadosData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxNReinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EjecutarAlgoritmoBtn;
        private System.Windows.Forms.DataGridView GridViewResultadosData;
        private System.Windows.Forms.NumericUpDown spinBoxNReinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Algoritmo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
    }
}

