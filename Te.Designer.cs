namespace TablaPeriodica
{
    partial class Te
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Te));
            this.l52 = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.telurio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l52
            // 
            this.l52.AutoSize = true;
            this.l52.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l52.Location = new System.Drawing.Point(275, 23);
            this.l52.Name = "l52";
            this.l52.Size = new System.Drawing.Size(34, 23);
            this.l52.TabIndex = 0;
            this.l52.Text = "52";
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel.Location = new System.Drawing.Point(105, 23);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(164, 116);
            this.tel.TabIndex = 0;
            this.tel.Text = "Te";
            // 
            // telurio
            // 
            this.telurio.AutoSize = true;
            this.telurio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telurio.Location = new System.Drawing.Point(139, 139);
            this.telurio.Name = "telurio";
            this.telurio.Size = new System.Drawing.Size(83, 23);
            this.telurio.TabIndex = 0;
            this.telurio.Text = "Telurio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-1, 171);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Te
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(335, 289);
            this.Controls.Add(this.info);
            this.Controls.Add(this.telurio);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.l52);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Te";
            this.Text = "Te";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l52;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label telurio;
        private System.Windows.Forms.Label info;
    }
}