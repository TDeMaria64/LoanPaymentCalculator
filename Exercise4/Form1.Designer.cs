
namespace Exercise4
{
    partial class monthlyPaymentCalcForm
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
            this.purchasePriceBox = new System.Windows.Forms.TextBox();
            this.purchasePriceLabel = new System.Windows.Forms.Label();
            this.downPayLabel = new System.Windows.Forms.Label();
            this.downPaymentBox = new System.Windows.Forms.TextBox();
            this.loanTermLabel = new System.Windows.Forms.Label();
            this.loanTermBox = new System.Windows.Forms.TextBox();
            this.interestLabel = new System.Windows.Forms.Label();
            this.interestRateBox = new System.Windows.Forms.TextBox();
            this.monthlyPayLabel = new System.Windows.Forms.Label();
            this.monthlyAmountBox = new System.Windows.Forms.TextBox();
            this.financeAmountLabel = new System.Windows.Forms.Label();
            this.financeAmountBox = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // purchasePriceBox
            // 
            this.purchasePriceBox.BackColor = System.Drawing.SystemColors.Window;
            this.purchasePriceBox.Location = new System.Drawing.Point(169, 44);
            this.purchasePriceBox.Name = "purchasePriceBox";
            this.purchasePriceBox.Size = new System.Drawing.Size(100, 20);
            this.purchasePriceBox.TabIndex = 0;
            this.purchasePriceBox.Tag = "";
            this.purchasePriceBox.Validated += new System.EventHandler(this.CalcBtn_Click);
            // 
            // purchasePriceLabel
            // 
            this.purchasePriceLabel.AutoSize = true;
            this.purchasePriceLabel.Location = new System.Drawing.Point(75, 47);
            this.purchasePriceLabel.Name = "purchasePriceLabel";
            this.purchasePriceLabel.Size = new System.Drawing.Size(85, 13);
            this.purchasePriceLabel.TabIndex = 1;
            this.purchasePriceLabel.Text = "Purchase Price :";
            // 
            // downPayLabel
            // 
            this.downPayLabel.AutoSize = true;
            this.downPayLabel.Location = new System.Drawing.Point(39, 87);
            this.downPayLabel.Name = "downPayLabel";
            this.downPayLabel.Size = new System.Drawing.Size(124, 13);
            this.downPayLabel.TabIndex = 3;
            this.downPayLabel.Text = "Down Payment Amount :";
            // 
            // downPaymentBox
            // 
            this.downPaymentBox.Location = new System.Drawing.Point(169, 84);
            this.downPaymentBox.Name = "downPaymentBox";
            this.downPaymentBox.Size = new System.Drawing.Size(100, 20);
            this.downPaymentBox.TabIndex = 2;
            this.downPaymentBox.Tag = "";
            this.downPaymentBox.Validated += new System.EventHandler(this.CalcBtn_Click);
            // 
            // loanTermLabel
            // 
            this.loanTermLabel.AutoSize = true;
            this.loanTermLabel.Location = new System.Drawing.Point(55, 166);
            this.loanTermLabel.Name = "loanTermLabel";
            this.loanTermLabel.Size = new System.Drawing.Size(108, 13);
            this.loanTermLabel.TabIndex = 7;
            this.loanTermLabel.Text = "Loan Term (Months) :";
            // 
            // loanTermBox
            // 
            this.loanTermBox.Location = new System.Drawing.Point(169, 163);
            this.loanTermBox.Name = "loanTermBox";
            this.loanTermBox.Size = new System.Drawing.Size(100, 20);
            this.loanTermBox.TabIndex = 6;
            this.loanTermBox.Tag = "";
            this.loanTermBox.Validated += new System.EventHandler(this.CalcBtn_Click);
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(53, 126);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(110, 13);
            this.interestLabel.TabIndex = 5;
            this.interestLabel.Text = "Annual Interest Rate :";
            // 
            // interestRateBox
            // 
            this.interestRateBox.Location = new System.Drawing.Point(169, 123);
            this.interestRateBox.Name = "interestRateBox";
            this.interestRateBox.Size = new System.Drawing.Size(100, 20);
            this.interestRateBox.TabIndex = 4;
            this.interestRateBox.Tag = "";
            this.interestRateBox.Validated += new System.EventHandler(this.CalcBtn_Click);
            // 
            // monthlyPayLabel
            // 
            this.monthlyPayLabel.AutoSize = true;
            this.monthlyPayLabel.Location = new System.Drawing.Point(331, 87);
            this.monthlyPayLabel.Name = "monthlyPayLabel";
            this.monthlyPayLabel.Size = new System.Drawing.Size(94, 13);
            this.monthlyPayLabel.TabIndex = 11;
            this.monthlyPayLabel.Text = "Monthly Payment :";
            // 
            // monthlyAmountBox
            // 
            this.monthlyAmountBox.BackColor = System.Drawing.Color.PeachPuff;
            this.monthlyAmountBox.Location = new System.Drawing.Point(431, 84);
            this.monthlyAmountBox.Name = "monthlyAmountBox";
            this.monthlyAmountBox.ReadOnly = true;
            this.monthlyAmountBox.Size = new System.Drawing.Size(100, 20);
            this.monthlyAmountBox.TabIndex = 10;
            this.monthlyAmountBox.Tag = "";
            // 
            // financeAmountLabel
            // 
            this.financeAmountLabel.AutoSize = true;
            this.financeAmountLabel.Location = new System.Drawing.Point(323, 47);
            this.financeAmountLabel.Name = "financeAmountLabel";
            this.financeAmountLabel.Size = new System.Drawing.Size(102, 13);
            this.financeAmountLabel.TabIndex = 9;
            this.financeAmountLabel.Text = "Amount to Finance :";
            // 
            // financeAmountBox
            // 
            this.financeAmountBox.BackColor = System.Drawing.Color.PeachPuff;
            this.financeAmountBox.Location = new System.Drawing.Point(431, 44);
            this.financeAmountBox.Name = "financeAmountBox";
            this.financeAmountBox.ReadOnly = true;
            this.financeAmountBox.Size = new System.Drawing.Size(100, 20);
            this.financeAmountBox.TabIndex = 8;
            this.financeAmountBox.Tag = "";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(182, 200);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(75, 23);
            this.CalcBtn.TabIndex = 12;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(446, 200);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 13;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "%";
            // 
            // monthlyPaymentCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(575, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.monthlyPayLabel);
            this.Controls.Add(this.monthlyAmountBox);
            this.Controls.Add(this.financeAmountLabel);
            this.Controls.Add(this.financeAmountBox);
            this.Controls.Add(this.loanTermLabel);
            this.Controls.Add(this.loanTermBox);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.interestRateBox);
            this.Controls.Add(this.downPayLabel);
            this.Controls.Add(this.downPaymentBox);
            this.Controls.Add(this.purchasePriceLabel);
            this.Controls.Add(this.purchasePriceBox);
            this.Name = "monthlyPaymentCalcForm";
            this.Text = "Monthly Payment Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox purchasePriceBox;
        private System.Windows.Forms.Label purchasePriceLabel;
        private System.Windows.Forms.Label downPayLabel;
        private System.Windows.Forms.TextBox downPaymentBox;
        private System.Windows.Forms.Label loanTermLabel;
        private System.Windows.Forms.TextBox loanTermBox;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.TextBox interestRateBox;
        private System.Windows.Forms.Label monthlyPayLabel;
        private System.Windows.Forms.TextBox monthlyAmountBox;
        private System.Windows.Forms.Label financeAmountLabel;
        private System.Windows.Forms.TextBox financeAmountBox;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label1;
    }
}

