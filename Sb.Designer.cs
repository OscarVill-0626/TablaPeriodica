namespace TablaPeriodica
{
    partial class Sb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sb));
            this.l51 = new System.Windows.Forms.Label();
            this.an = new System.Windows.Forms.Label();
            this.Anti = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l51
            // 
            this.l51.AutoSize = true;
            this.l51.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l51.Location = new System.Drawing.Point(251, 9);
            this.l51.Name = "l51";
            this.l51.Size = new System.Drawing.Size(30, 23);
            this.l51.TabIndex = 0;
            this.l51.Text = "51";
            // 
            // an
            // 
            this.an.AutoSize = true;
            this.an.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.an.Location = new System.Drawing.Point(83, 13);
            this.an.Name = "an";
            this.an.Size = new System.Drawing.Size(164, 116);
            this.an.TabIndex = 0;
            this.an.Text = "Sb";
            // 
            // Anti
            // 
            this.Anti.AutoSize = true;
            this.Anti.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anti.Location = new System.Drawing.Point(99, 129);
            this.Anti.Name = "Anti";
            this.Anti.Size = new System.Drawing.Size(115, 23);
            this.Anti.TabIndex = 0;
            this.Anti.Text = "Antimonio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(1, 164);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Sb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(339, 282);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Anti);
            this.Controls.Add(this.an);
            this.Controls.Add(this.l51);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sb";
            this.Text = "Sb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l51;
        private System.Windows.Forms.Label an;
        private System.Windows.Forms.Label Anti;
        private System.Windows.Forms.Label info;
    }
}