namespace ValidacionExpedientes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            nudCantidad = new NumericUpDown();
            btnIniciar = new Button();
            btnCancelar = new Button();
            prgProceso = new ProgressBar();
            lblEstado = new Label();
            lstResultados = new ListBox();
            lblPorcentaje = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(23, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(258, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Validación de expedientes";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(23, 67);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(137, 27);
            nudCantidad.TabIndex = 1;
            nudCantidad.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(183, 67);
            btnIniciar.Margin = new Padding(3, 4, 3, 4);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(137, 33);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar validación";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(331, 67);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 33);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // prgProceso
            // 
            prgProceso.Location = new Point(23, 120);
            prgProceso.Margin = new Padding(3, 4, 3, 4);
            prgProceso.Name = "prgProceso";
            prgProceso.Size = new Size(617, 31);
            prgProceso.TabIndex = 4;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(23, 167);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(78, 20);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Preparado";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Location = new Point(590, 167);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(33, 20);
            lblPorcentaje.TabIndex = 7;
            lblPorcentaje.Text = "0 %";
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(23, 200);
            lstResultados.Margin = new Padding(3, 4, 3, 4);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(617, 324);
            lstResultados.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 548);
            Controls.Add(lstResultados);
            Controls.Add(lblPorcentaje);
            Controls.Add(lblEstado);
            Controls.Add(prgProceso);
            Controls.Add(btnCancelar);
            Controls.Add(btnIniciar);
            Controls.Add(nudCantidad);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ProgressBar prgProceso;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.ListBox lstResultados;
    }
}
