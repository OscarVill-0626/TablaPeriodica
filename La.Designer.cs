namespace TablaPeriodica
{
    partial class La
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(La));
            this.lantino = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.laa = new System.Windows.Forms.Label();
            this.l57 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lantino
            // 
            this.lantino.AutoSize = true;
            this.lantino.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lantino.Location = new System.Drawing.Point(113, 115);
            this.lantino.Name = "lantino";
            this.lantino.Size = new System.Drawing.Size(94, 23);
            this.lantino.TabIndex = 0;
            this.lantino.Text = "Lantano";
            this.lantino.Click += new System.EventHandler(this.label1_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(0, 138);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 1;
            this.info.Text = resources.GetString("info.Text");
            // 
            // laa
            // 
            this.laa.AutoSize = true;
            this.laa.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laa.Location = new System.Drawing.Point(80, -1);
            this.laa.Name = "laa";
            this.laa.Size = new System.Drawing.Size(164, 116);
            this.laa.TabIndex = 2;
            this.laa.Text = "La";
            // 
            // l57
            // 
            this.l57.AutoSize = true;
            this.l57.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l57.Location = new System.Drawing.Point(238, 10);
            this.l57.Name = "l57";
            this.l57.Size = new System.Drawing.Size(33, 23);
            this.l57.TabIndex = 3;
            this.l57.Text = "57";
            // 
            // La
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(341, 252);
            this.Controls.Add(this.l57);
            this.Controls.Add(this.laa);
            this.Controls.Add(this.info);
            this.Controls.Add(this.lantino);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "La";
            this.Text = "La";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lantino;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label laa;
        private System.Windows.Forms.Label l57;
    }
}