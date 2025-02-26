namespace TablaPeriodica
{
    partial class Tl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tl));
            this.l81 = new System.Windows.Forms.Label();
            this.tal = new System.Windows.Forms.Label();
            this.talio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l81
            // 
            this.l81.AutoSize = true;
            this.l81.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l81.Location = new System.Drawing.Point(235, 9);
            this.l81.Name = "l81";
            this.l81.Size = new System.Drawing.Size(31, 23);
            this.l81.TabIndex = 0;
            this.l81.Text = "81";
            // 
            // tal
            // 
            this.tal.AutoSize = true;
            this.tal.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tal.Location = new System.Drawing.Point(86, 9);
            this.tal.Name = "tal";
            this.tal.Size = new System.Drawing.Size(152, 116);
            this.tal.TabIndex = 0;
            this.tal.Text = "Tl";
            // 
            // talio
            // 
            this.talio.AutoSize = true;
            this.talio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.talio.Location = new System.Drawing.Point(122, 121);
            this.talio.Name = "talio";
            this.talio.Size = new System.Drawing.Size(60, 23);
            this.talio.TabIndex = 0;
            this.talio.Text = "Talio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(2, 142);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(344, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Tl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(347, 263);
            this.Controls.Add(this.info);
            this.Controls.Add(this.talio);
            this.Controls.Add(this.tal);
            this.Controls.Add(this.l81);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tl";
            this.Text = "Tl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l81;
        private System.Windows.Forms.Label tal;
        private System.Windows.Forms.Label talio;
        private System.Windows.Forms.Label info;
    }
}