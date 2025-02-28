namespace TablaPeriodica
{
    partial class Ho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ho));
            this.l67 = new System.Windows.Forms.Label();
            this.hoo = new System.Windows.Forms.Label();
            this.holmio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l67
            // 
            this.l67.AutoSize = true;
            this.l67.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l67.Location = new System.Drawing.Point(262, 9);
            this.l67.Name = "l67";
            this.l67.Size = new System.Drawing.Size(34, 23);
            this.l67.TabIndex = 0;
            this.l67.Text = "67";
            // 
            // hoo
            // 
            this.hoo.AutoSize = true;
            this.hoo.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoo.Location = new System.Drawing.Point(80, -15);
            this.hoo.Name = "hoo";
            this.hoo.Size = new System.Drawing.Size(176, 116);
            this.hoo.TabIndex = 0;
            this.hoo.Text = "Ho";
            // 
            // holmio
            // 
            this.holmio.AutoSize = true;
            this.holmio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holmio.Location = new System.Drawing.Point(110, 101);
            this.holmio.Name = "holmio";
            this.holmio.Size = new System.Drawing.Size(78, 23);
            this.holmio.TabIndex = 0;
            this.holmio.Text = "Holmio";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(0, 124);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            // 
            // Ho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(346, 239);
            this.Controls.Add(this.info);
            this.Controls.Add(this.holmio);
            this.Controls.Add(this.hoo);
            this.Controls.Add(this.l67);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ho";
            this.Text = "Ho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l67;
        private System.Windows.Forms.Label hoo;
        private System.Windows.Forms.Label holmio;
        private System.Windows.Forms.Label info;
    }
}