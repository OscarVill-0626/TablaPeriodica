namespace TablaPeriodica
{
    partial class Pu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pu));
            this.l94 = new System.Windows.Forms.Label();
            this.puu = new System.Windows.Forms.Label();
            this.plutonio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l94
            // 
            this.l94.AutoSize = true;
            this.l94.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l94.Location = new System.Drawing.Point(259, 10);
            this.l94.Name = "l94";
            this.l94.Size = new System.Drawing.Size(34, 23);
            this.l94.TabIndex = 0;
            this.l94.Text = "94";
            // 
            // puu
            // 
            this.puu.AutoSize = true;
            this.puu.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puu.Location = new System.Drawing.Point(92, -9);
            this.puu.Name = "puu";
            this.puu.Size = new System.Drawing.Size(170, 116);
            this.puu.TabIndex = 0;
            this.puu.Text = "Pu";
            // 
            // plutonio
            // 
            this.plutonio.AutoSize = true;
            this.plutonio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plutonio.Location = new System.Drawing.Point(130, 107);
            this.plutonio.Name = "plutonio";
            this.plutonio.Size = new System.Drawing.Size(96, 23);
            this.plutonio.TabIndex = 0;
            this.plutonio.Text = "Plutonio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(1, 130);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Pu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(342, 246);
            this.Controls.Add(this.info);
            this.Controls.Add(this.plutonio);
            this.Controls.Add(this.puu);
            this.Controls.Add(this.l94);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pu";
            this.Text = "Pu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l94;
        private System.Windows.Forms.Label puu;
        private System.Windows.Forms.Label plutonio;
        private System.Windows.Forms.Label info;
    }
}