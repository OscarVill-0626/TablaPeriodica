namespace TablaPeriodica
{
    partial class Th
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Th));
            this.l90 = new System.Windows.Forms.Label();
            this.thh = new System.Windows.Forms.Label();
            this.torio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l90
            // 
            this.l90.AutoSize = true;
            this.l90.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l90.Location = new System.Drawing.Point(256, 9);
            this.l90.Name = "l90";
            this.l90.Size = new System.Drawing.Size(35, 23);
            this.l90.TabIndex = 0;
            this.l90.Text = "90";
            // 
            // thh
            // 
            this.thh.AutoSize = true;
            this.thh.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thh.Location = new System.Drawing.Point(71, -10);
            this.thh.Name = "thh";
            this.thh.Size = new System.Drawing.Size(179, 116);
            this.thh.TabIndex = 1;
            this.thh.Text = "Th";
            // 
            // torio
            // 
            this.torio.AutoSize = true;
            this.torio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.torio.Location = new System.Drawing.Point(137, 106);
            this.torio.Name = "torio";
            this.torio.Size = new System.Drawing.Size(63, 23);
            this.torio.TabIndex = 1;
            this.torio.Text = "Torio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(0, 129);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 1;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Th
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(340, 247);
            this.Controls.Add(this.info);
            this.Controls.Add(this.torio);
            this.Controls.Add(this.thh);
            this.Controls.Add(this.l90);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Th";
            this.Text = "Th";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l90;
        private System.Windows.Forms.Label thh;
        private System.Windows.Forms.Label torio;
        private System.Windows.Forms.Label info;
    }
}