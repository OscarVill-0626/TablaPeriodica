﻿namespace TablaPeriodica
{
    partial class Cd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cd));
            this.l48 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cadmio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l48
            // 
            this.l48.AutoSize = true;
            this.l48.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l48.Location = new System.Drawing.Point(190, 5);
            this.l48.Name = "l48";
            this.l48.Size = new System.Drawing.Size(34, 23);
            this.l48.TabIndex = 0;
            this.l48.Text = "48";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 116);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cd";
            // 
            // cadmio
            // 
            this.cadmio.AutoSize = true;
            this.cadmio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadmio.Location = new System.Drawing.Point(131, 148);
            this.cadmio.Name = "cadmio";
            this.cadmio.Size = new System.Drawing.Size(83, 23);
            this.cadmio.TabIndex = 0;
            this.cadmio.Text = "Cadmio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Peso atómico: 112.4";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(12, 241);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 96);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Cd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(349, 349);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cadmio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l48);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cd";
            this.Text = "Cd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l48;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cadmio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label info;
    }
}