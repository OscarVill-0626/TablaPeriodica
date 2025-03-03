namespace TablaPeriodica
{
    partial class Lv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lv));
            this.l116 = new System.Windows.Forms.Label();
            this.live = new System.Windows.Forms.Label();
            this.liver = new System.Windows.Forms.Label();
            this.informacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l116
            // 
            this.l116.AutoSize = true;
            this.l116.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l116.Location = new System.Drawing.Point(224, 9);
            this.l116.Name = "l116";
            this.l116.Size = new System.Drawing.Size(40, 23);
            this.l116.TabIndex = 0;
            this.l116.Text = "116";
            // 
            // live
            // 
            this.live.AutoSize = true;
            this.live.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.live.Location = new System.Drawing.Point(85, 32);
            this.live.Name = "live";
            this.live.Size = new System.Drawing.Size(156, 116);
            this.live.TabIndex = 0;
            this.live.Text = "Lv";
            // 
            // liver
            // 
            this.liver.AutoSize = true;
            this.liver.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liver.Location = new System.Drawing.Point(101, 155);
            this.liver.Name = "liver";
            this.liver.Size = new System.Drawing.Size(119, 23);
            this.liver.TabIndex = 0;
            this.liver.Text = "Livermorio";
            // 
            // informacion
            // 
            this.informacion.AutoSize = true;
            this.informacion.Location = new System.Drawing.Point(-1, 193);
            this.informacion.Name = "informacion";
            this.informacion.Size = new System.Drawing.Size(353, 112);
            this.informacion.TabIndex = 0;
            this.informacion.Text = resources.GetString("informacion.Text");
            // 
            // Lv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(350, 313);
            this.Controls.Add(this.informacion);
            this.Controls.Add(this.liver);
            this.Controls.Add(this.live);
            this.Controls.Add(this.l116);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lv";
            this.Text = "Lv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l116;
        private System.Windows.Forms.Label live;
        private System.Windows.Forms.Label liver;
        private System.Windows.Forms.Label informacion;
    }
}