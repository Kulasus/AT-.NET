namespace ATNET_DESKTOP_KON0355_STOCKMETALPRICES
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbCurrency = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbCurrency = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPrice.Location = new System.Drawing.Point(367, 129);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(420, 75);
            this.tbPrice.TabIndex = 0;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(367, 51);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(291, 20);
            this.tbDate.TabIndex = 1;
            // 
            // tbCurrency
            // 
            this.tbCurrency.Location = new System.Drawing.Point(367, 88);
            this.tbCurrency.Name = "tbCurrency";
            this.tbCurrency.ReadOnly = true;
            this.tbCurrency.Size = new System.Drawing.Size(196, 20);
            this.tbCurrency.TabIndex = 2;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(328, 51);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(33, 13);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Date:";
            // 
            // lbCurrency
            // 
            this.lbCurrency.AutoSize = true;
            this.lbCurrency.Location = new System.Drawing.Point(309, 88);
            this.lbCurrency.Name = "lbCurrency";
            this.lbCurrency.Size = new System.Drawing.Size(52, 13);
            this.lbCurrency.TabIndex = 4;
            this.lbCurrency.Text = "Currency:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(289, 129);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(72, 13);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Price per unit:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 319);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbCurrency);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.tbCurrency);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbPrice);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbCurrency;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbCurrency;
        private System.Windows.Forms.Label lbPrice;
    }
}

