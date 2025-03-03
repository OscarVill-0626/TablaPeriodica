namespace TablaPeriodica
{
    partial class Pm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pm));
            this.prometio = new System.Windows.Forms.Label();
            this.pmm = new System.Windows.Forms.Label();
            this.l61 = new System.Windows.Forms.Label();
            this.informacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prometio
            // 
            this.prometio.AutoSize = true;
            this.prometio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prometio.Location = new System.Drawing.Point(127, 102);
            this.prometio.Name = "prometio";
            this.prometio.Size = new System.Drawing.Size(101, 23);
            this.prometio.TabIndex = 0;
            this.prometio.Text = "Prometio";
            // 
            // pmm
            // 
            this.pmm.AutoSize = true;
            this.pmm.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pmm.Location = new System.Drawing.Point(77, -14);
            this.pmm.Name = "pmm";
            this.pmm.Size = new System.Drawing.Size(194, 116);
            this.pmm.TabIndex = 1;
            this.pmm.Text = "Pm";
            this.pmm.Click += new System.EventHandler(this.label2_Click);
            // 
            // l61
            // 
            this.l61.AutoSize = true;
            this.l61.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l61.Location = new System.Drawing.Point(267, 9);
            this.l61.Name = "l61";
            this.l61.Size = new System.Drawing.Size(31, 23);
            this.l61.TabIndex = 2;
            this.l61.Text = "61";
            // 
            // informacion
            // 
            this.informacion.AutoSize = true;
            this.informacion.Location = new System.Drawing.Point(-2, 125);
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(340, 112);
            this.informacion.TabIndex = 3;
            this.informacion.Text = resources.GetString("informacion.Text");
            // 
            // Pm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(335, 241);
            this.Controls.Add(this.informacion);
            this.Controls.Add(this.l61);
            this.Controls.Add(this.pmm);
            this.Controls.Add(this.prometio);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pm";
            this.Text = "Pm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prometio;
        private System.Windows.Forms.Label pmm;
        private System.Windows.Forms.Label l61;
        private System.Windows.Forms.Label informacion;
    }
}