namespace TablaPeriodica
{
    partial class P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P));
            this.l15 = new System.Windows.Forms.Label();
            this.fos = new System.Windows.Forms.Label();
            this.fosforo = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l15
            // 
            this.l15.AutoSize = true;
            this.l15.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l15.Location = new System.Drawing.Point(205, 9);
            this.l15.Name = "l15";
            this.l15.Size = new System.Drawing.Size(30, 23);
            this.l15.TabIndex = 0;
            this.l15.Text = "15";
            // 
            // fos
            // 
            this.fos.AutoSize = true;
            this.fos.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fos.Location = new System.Drawing.Point(124, 32);
            this.fos.Name = "fos";
            this.fos.Size = new System.Drawing.Size(111, 116);
            this.fos.TabIndex = 0;
            this.fos.Text = "P";
            // 
            // fosforo
            // 
            this.fosforo.AutoSize = true;
            this.fosforo.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fosforo.Location = new System.Drawing.Point(130, 148);
            this.fosforo.Name = "fosforo";
            this.fosforo.Size = new System.Drawing.Size(86, 23);
            this.fosforo.TabIndex = 0;
            this.fosforo.Text = "Fósforo";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(1, 188);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(337, 306);
            this.Controls.Add(this.info);
            this.Controls.Add(this.fosforo);
            this.Controls.Add(this.fos);
            this.Controls.Add(this.l15);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "P";
            this.Text = "P";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l15;
        private System.Windows.Forms.Label fos;
        private System.Windows.Forms.Label fosforo;
        private System.Windows.Forms.Label info;
    }
}