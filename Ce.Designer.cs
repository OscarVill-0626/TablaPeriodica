namespace TablaPeriodica
{
    partial class Ce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ce));
            this.cerio = new System.Windows.Forms.Label();
            this.cee = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.l58 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cerio
            // 
            this.cerio.AutoSize = true;
            this.cerio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerio.Location = new System.Drawing.Point(141, 111);
            this.cerio.Name = "cerio";
            this.cerio.Size = new System.Drawing.Size(63, 23);
            this.cerio.TabIndex = 0;
            this.cerio.Text = "Cerio";
            // 
            // cee
            // 
            this.cee.AutoSize = true;
            this.cee.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cee.Location = new System.Drawing.Point(87, -5);
            this.cee.Name = "cee";
            this.cee.Size = new System.Drawing.Size(168, 116);
            this.cee.TabIndex = 1;
            this.cee.Text = "Ce";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(1, 134);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 2;
            this.info.Text = resources.GetString("info.Text");
            // 
            // l58
            // 
            this.l58.AutoSize = true;
            this.l58.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l58.Location = new System.Drawing.Point(238, 8);
            this.l58.Name = "l58";
            this.l58.Size = new System.Drawing.Size(33, 23);
            this.l58.TabIndex = 4;
            this.l58.Text = "58";
            // 
            // Ce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(337, 248);
            this.Controls.Add(this.l58);
            this.Controls.Add(this.info);
            this.Controls.Add(this.cee);
            this.Controls.Add(this.cerio);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ce";
            this.Text = "Ce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cerio;
        private System.Windows.Forms.Label cee;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label l58;
    }
}