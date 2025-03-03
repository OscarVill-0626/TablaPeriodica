namespace TablaPeriodica
{
    partial class Yb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yb));
            this.l70 = new System.Windows.Forms.Label();
            this.ybb = new System.Windows.Forms.Label();
            this.iterbio = new System.Windows.Forms.Label();
            this.informacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l70
            // 
            this.l70.AutoSize = true;
            this.l70.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l70.Location = new System.Drawing.Point(243, 9);
            this.l70.Name = "l70";
            this.l70.Size = new System.Drawing.Size(35, 23);
            this.l70.TabIndex = 0;
            this.l70.Text = "70";
            this.l70.Click += new System.EventHandler(this.label1_Click);
            // 
            // ybb
            // 
            this.ybb.AutoSize = true;
            this.ybb.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ybb.Location = new System.Drawing.Point(63, -6);
            this.ybb.Name = "ybb";
            this.ybb.Size = new System.Drawing.Size(174, 116);
            this.ybb.TabIndex = 0;
            this.ybb.Text = "Yb";
            // 
            // iterbio
            // 
            this.iterbio.AutoSize = true;
            this.iterbio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterbio.Location = new System.Drawing.Point(113, 87);
            this.iterbio.Name = "iterbio";
            this.iterbio.Size = new System.Drawing.Size(78, 23);
            this.iterbio.TabIndex = 0;
            this.iterbio.Text = "Iterbio";
            // 
            // informacion
            // 
            this.informacion.AutoSize = true;
            this.informacion.Location = new System.Drawing.Point(1, 110);
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(340, 112);
            this.informacion.TabIndex = 0;
            this.informacion.Text = resources.GetString("informacion.Text");
            // 
            // Yb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(339, 222);
            this.Controls.Add(this.informacion);
            this.Controls.Add(this.iterbio);
            this.Controls.Add(this.ybb);
            this.Controls.Add(this.l70);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Yb";
            this.Text = "Yb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l70;
        private System.Windows.Forms.Label ybb;
        private System.Windows.Forms.Label iterbio;
        private System.Windows.Forms.Label informacion;
    }
}