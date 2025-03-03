namespace TablaPeriodica
{
    partial class N
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(N));
            this.l7 = new System.Windows.Forms.Label();
            this.ni = new System.Windows.Forms.Label();
            this.nitro = new System.Windows.Forms.Label();
            this.informacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l7
            // 
            this.l7.AutoSize = true;
            this.l7.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l7.Location = new System.Drawing.Point(223, 17);
            this.l7.Name = "l7";
            this.l7.Size = new System.Drawing.Size(22, 23);
            this.l7.TabIndex = 0;
            this.l7.Text = "7";
            // 
            // ni
            // 
            this.ni.AutoSize = true;
            this.ni.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ni.Location = new System.Drawing.Point(126, 40);
            this.ni.Name = "ni";
            this.ni.Size = new System.Drawing.Size(119, 116);
            this.ni.TabIndex = 0;
            this.ni.Text = "N";
            // 
            // nitro
            // 
            this.nitro.AutoSize = true;
            this.nitro.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nitro.Location = new System.Drawing.Point(123, 156);
            this.nitro.Name = "nitro";
            this.nitro.Size = new System.Drawing.Size(111, 23);
            this.nitro.TabIndex = 0;
            this.nitro.Text = "Nitrógeno";
            // 
            // informacion
            // 
            this.informacion.AutoSize = true;
            this.informacion.Location = new System.Drawing.Point(0, 182);
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(321, 112);
            this.informacion.TabIndex = 0;
            this.informacion.Text = resources.GetString("informacion.Text");
            this.informacion.Click += new System.EventHandler(this.label4_Click);
            // 
            // N
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(331, 297);
            this.Controls.Add(this.informacion);
            this.Controls.Add(this.nitro);
            this.Controls.Add(this.ni);
            this.Controls.Add(this.l7);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "N";
            this.Text = "N";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l7;
        private System.Windows.Forms.Label ni;
        private System.Windows.Forms.Label nitro;
        private System.Windows.Forms.Label informacion;
    }
}