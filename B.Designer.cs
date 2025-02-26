namespace TablaPeriodica
{
    partial class B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B));
            this.l5 = new System.Windows.Forms.Label();
            this.bo = new System.Windows.Forms.Label();
            this.bor = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.punto = new System.Windows.Forms.Label();
            this.punto2 = new System.Windows.Forms.Label();
            this.fase = new System.Windows.Forms.Label();
            this.confi = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l5.Location = new System.Drawing.Point(243, 12);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(21, 23);
            this.l5.TabIndex = 0;
            this.l5.Text = "5";
            // 
            // bo
            // 
            this.bo.AutoSize = true;
            this.bo.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bo.Location = new System.Drawing.Point(146, 39);
            this.bo.Name = "bo";
            this.bo.Size = new System.Drawing.Size(112, 116);
            this.bo.TabIndex = 0;
            this.bo.Text = "B";
            // 
            // bor
            // 
            this.bor.AutoSize = true;
            this.bor.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bor.Location = new System.Drawing.Point(172, 155);
            this.bor.Name = "bor";
            this.bor.Size = new System.Drawing.Size(56, 23);
            this.bor.TabIndex = 0;
            this.bor.Text = "Boro";
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Location = new System.Drawing.Point(12, 251);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(144, 16);
            this.peso.TabIndex = 0;
            this.peso.Text = "Peso atómico: 10.81";
            // 
            // punto
            // 
            this.punto.AutoSize = true;
            this.punto.Location = new System.Drawing.Point(12, 267);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(178, 16);
            this.punto.TabIndex = 0;
            this.punto.Text = "Punto de fusión: 2079°C";
            // 
            // punto2
            // 
            this.punto2.AutoSize = true;
            this.punto2.Location = new System.Drawing.Point(12, 283);
            this.punto2.Name = "punto2";
            this.punto2.Size = new System.Drawing.Size(202, 16);
            this.punto2.TabIndex = 0;
            this.punto2.Text = "Punto de ebullición: 2550°C";
            // 
            // fase
            // 
            this.fase.AutoSize = true;
            this.fase.Location = new System.Drawing.Point(12, 299);
            this.fase.Name = "fase";
            this.fase.Size = new System.Drawing.Size(340, 16);
            this.fase.TabIndex = 0;
            this.fase.Text = "Fase a temperatura y presión estándar: Solido";
            // 
            // confi
            // 
            this.confi.AutoSize = true;
            this.confi.Location = new System.Drawing.Point(12, 315);
            this.confi.Name = "confi";
            this.confi.Size = new System.Drawing.Size(282, 16);
            this.confi.TabIndex = 0;
            this.confi.Text = "Configuración electrónica: [He]2s22p1";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(12, 331);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(249, 16);
            this.estado.TabIndex = 0;
            this.estado.Text = "Estados de oxidación comunes: +3";
            this.estado.Click += new System.EventHandler(this.label9_Click);
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Location = new System.Drawing.Point(12, 347);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(266, 16);
            this.numero.TabIndex = 0;
            this.numero.Text = "Número de electrones de valencia: 3";
            // 
            // B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(395, 365);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.confi);
            this.Controls.Add(this.fase);
            this.Controls.Add(this.punto2);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.bor);
            this.Controls.Add(this.bo);
            this.Controls.Add(this.l5);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "B";
            this.Text = "B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Label bo;
        private System.Windows.Forms.Label bor;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label punto;
        private System.Windows.Forms.Label punto2;
        private System.Windows.Forms.Label fase;
        private System.Windows.Forms.Label confi;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label numero;
    }
}