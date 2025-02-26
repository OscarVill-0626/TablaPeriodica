﻿namespace TablaPeriodica
{
    partial class Ar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ar));
            this.arg = new System.Windows.Forms.Label();
            this.l18 = new System.Windows.Forms.Label();
            this.argon = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.punto = new System.Windows.Forms.Label();
            this.puntomodelo = new System.Windows.Forms.Label();
            this.fase = new System.Windows.Forms.Label();
            this.confi = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // arg
            // 
            this.arg.AutoSize = true;
            this.arg.Font = new System.Drawing.Font("Microsoft Sans Serif", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.arg.Location = new System.Drawing.Point(135, 35);
            this.arg.Name = "arg";
            this.arg.Size = new System.Drawing.Size(179, 135);
            this.arg.TabIndex = 0;
            this.arg.Text = "Ar";
            // 
            // l18
            // 
            this.l18.AutoSize = true;
            this.l18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l18.Location = new System.Drawing.Point(256, 20);
            this.l18.Name = "l18";
            this.l18.Size = new System.Drawing.Size(36, 25);
            this.l18.TabIndex = 1;
            this.l18.Text = "18";
            // 
            // argon
            // 
            this.argon.AutoSize = true;
            this.argon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.argon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.argon.Location = new System.Drawing.Point(181, 161);
            this.argon.Name = "argon";
            this.argon.Size = new System.Drawing.Size(70, 25);
            this.argon.TabIndex = 2;
            this.argon.Text = "Argón";
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.peso.Location = new System.Drawing.Point(12, 217);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(180, 20);
            this.peso.TabIndex = 2;
            this.peso.Text = "Peso atómico: 39.95";
            // 
            // punto
            // 
            this.punto.AutoSize = true;
            this.punto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.punto.Location = new System.Drawing.Point(12, 233);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(225, 20);
            this.punto.TabIndex = 2;
            this.punto.Text = "Punto de fusión: -189.2°C";
            // 
            // puntomodelo
            // 
            this.puntomodelo.AutoSize = true;
            this.puntomodelo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.puntomodelo.Location = new System.Drawing.Point(12, 249);
            this.puntomodelo.Name = "puntomodelo";
            this.puntomodelo.Size = new System.Drawing.Size(254, 20);
            this.puntomodelo.TabIndex = 2;
            this.puntomodelo.Text = "Punto de ebullición: -185.7°C";
            // 
            // fase
            // 
            this.fase.AutoSize = true;
            this.fase.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fase.Location = new System.Drawing.Point(12, 265);
            this.fase.Name = "fase";
            this.fase.Size = new System.Drawing.Size(381, 20);
            this.fase.TabIndex = 2;
            this.fase.Text = "Fase a temperatura y presión estándar: Gas";
            this.fase.Click += new System.EventHandler(this.label7_Click);
            // 
            // confi
            // 
            this.confi.AutoSize = true;
            this.confi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confi.Location = new System.Drawing.Point(12, 281);
            this.confi.Name = "confi";
            this.confi.Size = new System.Drawing.Size(331, 20);
            this.confi.TabIndex = 2;
            this.confi.Text = "Configuración electrónica: [Ne]3s23p6";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.estado.Location = new System.Drawing.Point(12, 297);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(291, 20);
            this.estado.TabIndex = 2;
            this.estado.Text = "Estados de oxidación comunes: 0";
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.numero.Location = new System.Drawing.Point(12, 313);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(317, 20);
            this.numero.TabIndex = 2;
            this.numero.Text = "Número de electrones de valencia: 8";
            // 
            // Ar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(420, 364);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.confi);
            this.Controls.Add(this.fase);
            this.Controls.Add(this.puntomodelo);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.argon);
            this.Controls.Add(this.l18);
            this.Controls.Add(this.arg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ar";
            this.Text = "Ar";
            this.Load += new System.EventHandler(this.Ar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label arg;
        private System.Windows.Forms.Label l18;
        private System.Windows.Forms.Label argon;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label punto;
        private System.Windows.Forms.Label puntomodelo;
        private System.Windows.Forms.Label fase;
        private System.Windows.Forms.Label confi;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label numero;
    }
}