namespace Pizza
{
    partial class Form2
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
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTheTilte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("NSimSun", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Teal;
            this.lbDate.Location = new System.Drawing.Point(265, 153);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 27);
            this.lbDate.TabIndex = 0;
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTheTilte
            // 
            this.lbTheTilte.AutoSize = true;
            this.lbTheTilte.Font = new System.Drawing.Font("Niagara Engraved", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheTilte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTheTilte.Location = new System.Drawing.Point(240, 53);
            this.lbTheTilte.Name = "lbTheTilte";
            this.lbTheTilte.Size = new System.Drawing.Size(309, 68);
            this.lbTheTilte.TabIndex = 1;
            this.lbTheTilte.Text = "The Time Of Order";
            this.lbTheTilte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTheTilte);
            this.Controls.Add(this.lbDate);
            this.Name = "Form2";
            this.Text = "Order Time";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTheTilte;
    }
}