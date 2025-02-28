namespace TablaPeriodica
{
    partial class Sm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sm));
            this.l62 = new System.Windows.Forms.Label();
            this.smm = new System.Windows.Forms.Label();
            this.samario = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l62
            // 
            this.l62.AutoSize = true;
            this.l62.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l62.Location = new System.Drawing.Point(265, 9);
            this.l62.Name = "l62";
            this.l62.Size = new System.Drawing.Size(35, 23);
            this.l62.TabIndex = 0;
            this.l62.Text = "62";
            // 
            // smm
            // 
            this.smm.AutoSize = true;
            this.smm.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smm.Location = new System.Drawing.Point(70, -4);
            this.smm.Name = "smm";
            this.smm.Size = new System.Drawing.Size(189, 116);
            this.smm.TabIndex = 0;
            this.smm.Text = "Sm";
            // 
            // samario
            // 
            this.samario.AutoSize = true;
            this.samario.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samario.Location = new System.Drawing.Point(117, 112);
            this.samario.Name = "samario";
            this.samario.Size = new System.Drawing.Size(91, 23);
            this.samario.TabIndex = 0;
            this.samario.Text = "Samario";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(1, 135);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Sm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(342, 253);
            this.Controls.Add(this.info);
            this.Controls.Add(this.samario);
            this.Controls.Add(this.smm);
            this.Controls.Add(this.l62);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sm";
            this.Text = "Sm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l62;
        private System.Windows.Forms.Label smm;
        private System.Windows.Forms.Label samario;
        private System.Windows.Forms.Label info;
    }
}