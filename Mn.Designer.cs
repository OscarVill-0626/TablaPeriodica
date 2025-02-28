namespace TablaPeriodica
{
    partial class Mn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mn));
            this.Txt_nomb = new System.Windows.Forms.Label();
            this.Txt_numAto = new System.Windows.Forms.Label();
            this.Txt_sbmQui = new System.Windows.Forms.Label();
            this.Txt_numOx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nomb
            // 
            this.Txt_nomb.AutoSize = true;
            this.Txt_nomb.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nomb.Location = new System.Drawing.Point(109, 142);
            this.Txt_nomb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_nomb.Name = "Txt_nomb";
            this.Txt_nomb.Size = new System.Drawing.Size(124, 23);
            this.Txt_nomb.TabIndex = 0;
            this.Txt_nomb.Text = "Manganeso";
            // 
            // Txt_numAto
            // 
            this.Txt_numAto.AutoSize = true;
            this.Txt_numAto.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numAto.Location = new System.Drawing.Point(271, 9);
            this.Txt_numAto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_numAto.Name = "Txt_numAto";
            this.Txt_numAto.Size = new System.Drawing.Size(34, 23);
            this.Txt_numAto.TabIndex = 1;
            this.Txt_numAto.Text = "25";
            // 
            // Txt_sbmQui
            // 
            this.Txt_sbmQui.AutoSize = true;
            this.Txt_sbmQui.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_sbmQui.Location = new System.Drawing.Point(72, 9);
            this.Txt_sbmQui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt_sbmQui.Name = "Txt_sbmQui";
            this.Txt_sbmQui.Size = new System.Drawing.Size(191, 116);
            this.Txt_sbmQui.TabIndex = 2;
            this.Txt_sbmQui.Text = "Mg";
            // 
            // Txt_numOx
            // 
            this.Txt_numOx.AutoSize = true;
            this.Txt_numOx.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numOx.Location = new System.Drawing.Point(-4, 176);
            this.Txt_numOx.Name = "Txt_numOx";
            this.Txt_numOx.Size = new System.Drawing.Size(340, 112);
            this.Txt_numOx.TabIndex = 5;
            this.Txt_numOx.Text = resources.GetString("Txt_numOx.Text");
            // 
            // Mn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(338, 297);
            this.Controls.Add(this.Txt_numOx);
            this.Controls.Add(this.Txt_sbmQui);
            this.Controls.Add(this.Txt_numAto);
            this.Controls.Add(this.Txt_nomb);
            this.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Mn";
            this.Text = "Mn";
            this.Load += new System.EventHandler(this.Mn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_nomb;
        private System.Windows.Forms.Label Txt_numAto;
        private System.Windows.Forms.Label Txt_sbmQui;
        private System.Windows.Forms.Label Txt_numOx;
    }
}