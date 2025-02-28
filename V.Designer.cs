namespace TablaPeriodica
{
    partial class V
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V));
            this.Txt_nom = new System.Windows.Forms.Label();
            this.Txt_numAt = new System.Windows.Forms.Label();
            this.Txt_smbQui = new System.Windows.Forms.Label();
            this.Txt_numOxi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_nom
            // 
            this.Txt_nom.AutoSize = true;
            this.Txt_nom.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nom.Location = new System.Drawing.Point(140, 125);
            this.Txt_nom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(91, 23);
            this.Txt_nom.TabIndex = 0;
            this.Txt_nom.Text = "Vanadio";
            // 
            // Txt_numAt
            // 
            this.Txt_numAt.AutoSize = true;
            this.Txt_numAt.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numAt.Location = new System.Drawing.Point(256, 9);
            this.Txt_numAt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Txt_numAt.Name = "Txt_numAt";
            this.Txt_numAt.Size = new System.Drawing.Size(36, 23);
            this.Txt_numAt.TabIndex = 1;
            this.Txt_numAt.Text = "23";
            this.Txt_numAt.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_smbQui
            // 
            this.Txt_smbQui.AutoSize = true;
            this.Txt_smbQui.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_smbQui.Location = new System.Drawing.Point(124, 0);
            this.Txt_smbQui.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Txt_smbQui.Name = "Txt_smbQui";
            this.Txt_smbQui.Size = new System.Drawing.Size(125, 116);
            this.Txt_smbQui.TabIndex = 2;
            this.Txt_smbQui.Text = "V";
            // 
            // Txt_numOxi
            // 
            this.Txt_numOxi.AutoSize = true;
            this.Txt_numOxi.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_numOxi.Location = new System.Drawing.Point(-2, 148);
            this.Txt_numOxi.Name = "Txt_numOxi";
            this.Txt_numOxi.Size = new System.Drawing.Size(340, 112);
            this.Txt_numOxi.TabIndex = 4;
            this.Txt_numOxi.Text = resources.GetString("Txt_numOxi.Text");
            // 
            // V
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(341, 267);
            this.Controls.Add(this.Txt_numOxi);
            this.Controls.Add(this.Txt_smbQui);
            this.Controls.Add(this.Txt_numAt);
            this.Controls.Add(this.Txt_nom);
            this.Font = new System.Drawing.Font("Fredoka One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "V";
            this.Text = "V";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_nom;
        private System.Windows.Forms.Label Txt_numAt;
        private System.Windows.Forms.Label Txt_smbQui;
        private System.Windows.Forms.Label Txt_numOxi;
    }
}