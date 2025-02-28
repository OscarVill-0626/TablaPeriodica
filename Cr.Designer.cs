namespace TablaPeriodica
{
    partial class Cr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cr));
            this.Txt_nom = new System.Windows.Forms.Label();
            this.Txt_sbmQui = new System.Windows.Forms.Label();
            this.Txt_numAt = new System.Windows.Forms.Label();
            this.Txt_nimOx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nom
            // 
            this.Txt_nom.AutoSize = true;
            this.Txt_nom.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nom.Location = new System.Drawing.Point(108, 119);
            this.Txt_nom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(74, 23);
            this.Txt_nom.TabIndex = 0;
            this.Txt_nom.Text = "Cromo";
            // 
            // Txt_sbmQui
            // 
            this.Txt_sbmQui.AutoSize = true;
            this.Txt_sbmQui.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_sbmQui.Location = new System.Drawing.Point(67, 3);
            this.Txt_sbmQui.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Txt_sbmQui.Name = "Txt_sbmQui";
            this.Txt_sbmQui.Size = new System.Drawing.Size(160, 116);
            this.Txt_sbmQui.TabIndex = 1;
            this.Txt_sbmQui.Text = "Cr";
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numAt.Location = new System.Drawing.Point(241, 9);
            this.Txt_numAt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(35, 23);
            this.Txt_numAt.TabIndex = 2;
            this.Txt_numAt.Text = "24";
            // 
            // Txt_nimOx
            // 
            this.Txt_nimOx.AutoSize = true;
            this.Txt_nimOx.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nimOx.Location = new System.Drawing.Point(1, 147);
            this.Txt_nimOx.Name = "Txt_nimOx";
            this.Txt_nimOx.Size = new System.Drawing.Size(340, 112);
            this.Txt_nimOx.TabIndex = 5;
            this.Txt_nimOx.Text = resources.GetString("Txt_nimOx.Text");
            // 
            // Cr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(341, 279);
            this.Controls.Add(this.Txt_nimOx);
            this.Controls.Add(this.Txt_numAt);
            this.Controls.Add(this.Txt_sbmQui);
            this.Controls.Add(this.Txt_nom);
            this.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Cr";
            this.Text = "Cr";
            this.Load += new System.EventHandler(this.Cr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_nom;
        private System.Windows.Forms.Label Txt_sbmQui;
        private System.Windows.Forms.Label Txt_numAt;
        private System.Windows.Forms.Label Txt_nimOx;
    }
}