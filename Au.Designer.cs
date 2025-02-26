namespace TablaPeriodica
{
    partial class Au
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Au));
            this.l79 = new System.Windows.Forms.Label();
            this.auro = new System.Windows.Forms.Label();
            this.oro = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.puntomodelo = new System.Windows.Forms.Label();
            this.punto = new System.Windows.Forms.Label();
            this.fase = new System.Windows.Forms.Label();
            this.confi = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l79
            // 
            this.l79.AutoSize = true;
            this.l79.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l79.Location = new System.Drawing.Point(215, 13);
            this.l79.Name = "l79";
            this.l79.Size = new System.Drawing.Size(34, 23);
            this.l79.TabIndex = 0;
            this.l79.Text = "79";
            // 
            // auro
            // 
            this.auro.AutoSize = true;
            this.auro.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auro.Location = new System.Drawing.Point(80, 36);
            this.auro.Name = "auro";
            this.auro.Size = new System.Drawing.Size(178, 116);
            this.auro.TabIndex = 1;
            this.auro.Text = "Au";
            // 
            // oro
            // 
            this.oro.AutoSize = true;
            this.oro.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oro.Location = new System.Drawing.Point(144, 165);
            this.oro.Name = "oro";
            this.oro.Size = new System.Drawing.Size(47, 23);
            this.oro.TabIndex = 2;
            this.oro.Text = "Oro";
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Location = new System.Drawing.Point(12, 227);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(154, 16);
            this.peso.TabIndex = 2;
            this.peso.Text = "Peso atómico: 197.00";
            // 
            // puntomodelo
            // 
            this.puntomodelo.AutoSize = true;
            this.puntomodelo.Location = new System.Drawing.Point(12, 243);
            this.puntomodelo.Name = "puntomodelo";
            this.puntomodelo.Size = new System.Drawing.Size(176, 16);
            this.puntomodelo.TabIndex = 2;
            this.puntomodelo.Text = "Punto de fusión: 1064°C";
            // 
            // punto
            // 
            this.punto.AutoSize = true;
            this.punto.Location = new System.Drawing.Point(12, 259);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(204, 16);
            this.punto.TabIndex = 2;
            this.punto.Text = "Punto de ebullición: 3080°C";
            // 
            // fase
            // 
            this.fase.AutoSize = true;
            this.fase.Location = new System.Drawing.Point(12, 275);
            this.fase.Name = "fase";
            this.fase.Size = new System.Drawing.Size(340, 16);
            this.fase.TabIndex = 2;
            this.fase.Text = "Fase a temperatura y presión estándar: Solido";
            // 
            // confi
            // 
            this.confi.AutoSize = true;
            this.confi.Location = new System.Drawing.Point(12, 291);
            this.confi.Name = "confi";
            this.confi.Size = new System.Drawing.Size(318, 16);
            this.confi.TabIndex = 2;
            this.confi.Text = "Configuración electrónica: [Xe]4f145d106s1";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(12, 307);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(259, 16);
            this.estado.TabIndex = 2;
            this.estado.Text = "Estados de oxidación comunes: +3,1";
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Location = new System.Drawing.Point(12, 323);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(263, 16);
            this.numero.TabIndex = 2;
            this.numero.Text = "Número de electrones de valencia: 1";
            // 
            // Au
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(365, 361);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.confi);
            this.Controls.Add(this.fase);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.puntomodelo);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.oro);
            this.Controls.Add(this.auro);
            this.Controls.Add(this.l79);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Au";
            this.Text = "Au";
            this.Load += new System.EventHandler(this.Au_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l79;
        private System.Windows.Forms.Label auro;
        private System.Windows.Forms.Label oro;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label puntomodelo;
        private System.Windows.Forms.Label punto;
        private System.Windows.Forms.Label fase;
        private System.Windows.Forms.Label confi;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label numero;
    }
}