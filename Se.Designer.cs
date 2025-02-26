namespace TablaPeriodica
{
    partial class Se
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Se));
            this.l34 = new System.Windows.Forms.Label();
            this.sel = new System.Windows.Forms.Label();
            this.selenio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l34
            // 
            this.l34.AutoSize = true;
            this.l34.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l34.Location = new System.Drawing.Point(282, 28);
            this.l34.Name = "l34";
            this.l34.Size = new System.Drawing.Size(35, 23);
            this.l34.TabIndex = 0;
            this.l34.Text = "34";
            // 
            // sel
            // 
            this.sel.AutoSize = true;
            this.sel.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sel.Location = new System.Drawing.Point(114, 13);
            this.sel.Name = "sel";
            this.sel.Size = new System.Drawing.Size(162, 116);
            this.sel.TabIndex = 0;
            this.sel.Text = "Se";
            // 
            // selenio
            // 
            this.selenio.AutoSize = true;
            this.selenio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selenio.Location = new System.Drawing.Point(141, 121);
            this.selenio.Name = "selenio";
            this.selenio.Size = new System.Drawing.Size(84, 23);
            this.selenio.TabIndex = 0;
            this.selenio.Text = "Selenio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-1, 157);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Se
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(335, 270);
            this.Controls.Add(this.info);
            this.Controls.Add(this.selenio);
            this.Controls.Add(this.sel);
            this.Controls.Add(this.l34);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Se";
            this.Text = "Se";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l34;
        private System.Windows.Forms.Label sel;
        private System.Windows.Forms.Label selenio;
        private System.Windows.Forms.Label info;
    }
}