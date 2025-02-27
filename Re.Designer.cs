namespace TablaPeriodica
{
    partial class Re
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Re));
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_sbmQui = new System.Windows.Forms.Label();
            this.Txt_nom = new System.Windows.Forms.Label();
            this.Txt_edoOxi = new System.Windows.Forms.Label();
            this.Txt_edoOxiEs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "75";
            // 
            // Txt_sbmQui
            // 
            this.Txt_sbmQui.AutoSize = true;
            this.Txt_sbmQui.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_sbmQui.Location = new System.Drawing.Point(82, 60);
            this.Txt_sbmQui.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_sbmQui.Name = "Txt_sbmQui";
            this.Txt_sbmQui.Size = new System.Drawing.Size(213, 135);
            this.Txt_sbmQui.TabIndex = 1;
            this.Txt_sbmQui.Text = "Re";
            // 
            // Txt_nom
            // 
            this.Txt_nom.AutoSize = true;
            this.Txt_nom.Location = new System.Drawing.Point(149, 195);
            this.Txt_nom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_nom.Name = "Txt_nom";
            this.Txt_nom.Size = new System.Drawing.Size(67, 25);
            this.Txt_nom.TabIndex = 2;
            this.Txt_nom.Text = "Renio";
            // 
            // Txt_edoOxi
            // 
            this.Txt_edoOxi.AutoSize = true;
            this.Txt_edoOxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_edoOxi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Txt_edoOxi.Location = new System.Drawing.Point(226, 40);
            this.Txt_edoOxi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_edoOxi.Name = "Txt_edoOxi";
            this.Txt_edoOxi.Size = new System.Drawing.Size(165, 20);
            this.Txt_edoOxi.TabIndex = 3;
            this.Txt_edoOxi.Text = "+1+2+3     +5+6+7";
            // 
            // Txt_edoOxiEs
            // 
            this.Txt_edoOxiEs.AutoSize = true;
            this.Txt_edoOxiEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_edoOxiEs.Location = new System.Drawing.Point(293, 40);
            this.Txt_edoOxiEs.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Txt_edoOxiEs.Name = "Txt_edoOxiEs";
            this.Txt_edoOxiEs.Size = new System.Drawing.Size(30, 20);
            this.Txt_edoOxiEs.TabIndex = 4;
            this.Txt_edoOxiEs.Text = "+4";
            // 
            // Re
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(397, 270);
            this.Controls.Add(this.Txt_edoOxiEs);
            this.Controls.Add(this.Txt_edoOxi);
            this.Controls.Add(this.Txt_nom);
            this.Controls.Add(this.Txt_sbmQui);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Re";
            this.Text = "Re";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Txt_sbmQui;
        private System.Windows.Forms.Label Txt_nom;
        private System.Windows.Forms.Label Txt_edoOxi;
        private System.Windows.Forms.Label Txt_edoOxiEs;
    }
}