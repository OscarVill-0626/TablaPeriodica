namespace TablaPeriodica
{
    partial class In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(In));
            this.l49 = new System.Windows.Forms.Label();
            this.ind = new System.Windows.Forms.Label();
            this.indio = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l49
            // 
            this.l49.AutoSize = true;
            this.l49.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l49.Location = new System.Drawing.Point(211, -1);
            this.l49.Name = "l49";
            this.l49.Size = new System.Drawing.Size(34, 23);
            this.l49.TabIndex = 0;
            this.l49.Text = "49";
            // 
            // ind
            // 
            this.ind.AutoSize = true;
            this.ind.Font = new System.Drawing.Font("Fredoka One", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ind.Location = new System.Drawing.Point(96, 22);
            this.ind.Name = "ind";
            this.ind.Size = new System.Drawing.Size(134, 116);
            this.ind.TabIndex = 0;
            this.ind.Text = "In";
            // 
            // indio
            // 
            this.indio.AutoSize = true;
            this.indio.Font = new System.Drawing.Font("Fredoka One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indio.Location = new System.Drawing.Point(132, 148);
            this.indio.Name = "indio";
            this.indio.Size = new System.Drawing.Size(59, 23);
            this.indio.TabIndex = 0;
            this.indio.Text = "Indio";
            this.indio.Click += new System.EventHandler(this.label3_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(-1, 171);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(340, 112);
            this.info.TabIndex = 0;
            this.info.Text = resources.GetString("info.Text");
            this.info.Click += new System.EventHandler(this.label3_Click);
            // 
            // In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(340, 284);
            this.Controls.Add(this.info);
            this.Controls.Add(this.indio);
            this.Controls.Add(this.ind);
            this.Controls.Add(this.l49);
            this.Font = new System.Drawing.Font("Fredoka One", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "In";
            this.Text = "In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l49;
        private System.Windows.Forms.Label ind;
        private System.Windows.Forms.Label indio;
        private System.Windows.Forms.Label info;
    }
}