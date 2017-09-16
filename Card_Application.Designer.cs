namespace Edison_Properties_Payment
{
    partial class Card_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card_Application));
            this.labelprompt = new System.Windows.Forms.Label();
            this.labelValidation = new System.Windows.Forms.Label();
            this.labelCCNum = new System.Windows.Forms.Label();
            this.labelExpiration = new System.Windows.Forms.Label();
            this.labelCVV = new System.Windows.Forms.Label();
            this.textBoxCCNum = new System.Windows.Forms.TextBox();
            this.textBoxExpiration = new System.Windows.Forms.TextBox();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelprompt
            // 
            this.labelprompt.AutoEllipsis = true;
            this.labelprompt.AutoSize = true;
            this.labelprompt.Location = new System.Drawing.Point(12, 18);
            this.labelprompt.MaximumSize = new System.Drawing.Size(375, 0);
            this.labelprompt.Name = "labelprompt";
            this.labelprompt.Size = new System.Drawing.Size(356, 65);
            this.labelprompt.TabIndex = 0;
            this.labelprompt.Text = resources.GetString("labelprompt.Text");
            // 
            // labelValidation
            // 
            this.labelValidation.AutoSize = true;
            this.labelValidation.ForeColor = System.Drawing.Color.Red;
            this.labelValidation.Location = new System.Drawing.Point(12, 83);
            this.labelValidation.Name = "labelValidation";
            this.labelValidation.Size = new System.Drawing.Size(74, 13);
            this.labelValidation.TabIndex = 1;
            this.labelValidation.Text = "labelvalidation";
            this.labelValidation.Visible = false;
            // 
            // labelCCNum
            // 
            this.labelCCNum.AutoSize = true;
            this.labelCCNum.Location = new System.Drawing.Point(52, 152);
            this.labelCCNum.Name = "labelCCNum";
            this.labelCCNum.Size = new System.Drawing.Size(102, 13);
            this.labelCCNum.TabIndex = 2;
            this.labelCCNum.Text = "Credit/Debit Card #:";
            // 
            // labelExpiration
            // 
            this.labelExpiration.AutoSize = true;
            this.labelExpiration.Location = new System.Drawing.Point(72, 178);
            this.labelExpiration.Name = "labelExpiration";
            this.labelExpiration.Size = new System.Drawing.Size(82, 13);
            this.labelExpiration.TabIndex = 3;
            this.labelExpiration.Text = "Expiration Date:";
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.Location = new System.Drawing.Point(123, 204);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(31, 13);
            this.labelCVV.TabIndex = 4;
            this.labelCVV.Text = "CVV:";
            // 
            // textBoxCCNum
            // 
            this.textBoxCCNum.Location = new System.Drawing.Point(160, 152);
            this.textBoxCCNum.Name = "textBoxCCNum";
            this.textBoxCCNum.Size = new System.Drawing.Size(128, 20);
            this.textBoxCCNum.TabIndex = 5;
            // 
            // textBoxExpiration
            // 
            this.textBoxExpiration.Location = new System.Drawing.Point(160, 178);
            this.textBoxExpiration.Name = "textBoxExpiration";
            this.textBoxExpiration.Size = new System.Drawing.Size(128, 20);
            this.textBoxExpiration.TabIndex = 6;
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Location = new System.Drawing.Point(160, 204);
            this.textBoxCVV.MaxLength = 3;
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(128, 20);
            this.textBoxCVV.TabIndex = 7;
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(289, 264);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(75, 23);
            this.buttonPay.TabIndex = 8;
            this.buttonPay.Text = "Submit";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 299);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.textBoxCVV);
            this.Controls.Add(this.textBoxExpiration);
            this.Controls.Add(this.textBoxCCNum);
            this.Controls.Add(this.labelCVV);
            this.Controls.Add(this.labelExpiration);
            this.Controls.Add(this.labelCCNum);
            this.Controls.Add(this.labelValidation);
            this.Controls.Add(this.labelprompt);
            this.Name = "Card";
            this.Text = "Edison Properties Pay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelprompt;
        private System.Windows.Forms.Label labelValidation;
        private System.Windows.Forms.Label labelCCNum;
        private System.Windows.Forms.Label labelExpiration;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.TextBox textBoxCCNum;
        private System.Windows.Forms.TextBox textBoxExpiration;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.Button buttonPay;
    }
}

