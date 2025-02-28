namespace TablaPeriodica
{
    partial class Cm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cm));
            this.l96 = new System.Windows.Forms.Label();
            this.cmm = new System.Windows.Forms.Label();
            this.curio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l96
            // 
            this.l96.AutoSize = true;
            this.l96.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l96.Location = new System.Drawing.Point(247, 9);
            this.l96.Name = "l96";
            this.l96.Size = new System.Drawing.Size(34, 23);
            this.l96.TabIndex = 0;
            this.l96.Text = "96";
            // 
            // cmm
            // 
            this.cmm.AutoSize = true;
            this.cmm.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmm.Location = new System.Drawing.Point(43, -5);
            this.cmm.Name = "cmm";
            this.cmm.Size = new System.Drawing.Size(198, 116);
            this.cmm.TabIndex = 0;
            this.cmm.Text = "Cm";
            // 
            // curio
            // 
            this.curio.AutoSize = true;
            this.curio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curio.Location = new System.Drawing.Point(127, 111);
            this.curio.Name = "curio";
            this.curio.Size = new System.Drawing.Size(65, 23);
            this.curio.TabIndex = 0;
            this.curio.Text = "Curio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(12, 134);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Cm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(355, 253);
            this.Controls.Add(this.info);
            this.Controls.Add(this.curio);
            this.Controls.Add(this.cmm);
            this.Controls.Add(this.l96);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cm";
            this.Text = "Cm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l96;
        private System.Windows.Forms.Label cmm;
        private System.Windows.Forms.Label curio;
        private System.Windows.Forms.Label info;
    }
}