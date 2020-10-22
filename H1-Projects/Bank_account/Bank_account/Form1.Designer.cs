namespace Bank_account
{
    partial class Bank_account_form
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
            this.Balance = new System.Windows.Forms.Label();
            this.Withdraw = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.WithdrawAmountAndDeposit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Balance
            // 
            this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.Location = new System.Drawing.Point(48, 48);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(322, 53);
            this.Balance.TabIndex = 0;
            this.Balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Balance.Click += new System.EventHandler(this.Balance_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw.Location = new System.Drawing.Point(55, 133);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(128, 51);
            this.Withdraw.TabIndex = 1;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // Deposit
            // 
            this.Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit.Location = new System.Drawing.Point(232, 133);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(129, 51);
            this.Deposit.TabIndex = 2;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(160, 252);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(94, 39);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // WithdrawAmountAndDeposit
            // 
            this.WithdrawAmountAndDeposit.Location = new System.Drawing.Point(144, 190);
            this.WithdrawAmountAndDeposit.Name = "WithdrawAmountAndDeposit";
            this.WithdrawAmountAndDeposit.Size = new System.Drawing.Size(128, 22);
            this.WithdrawAmountAndDeposit.TabIndex = 4;
            this.WithdrawAmountAndDeposit.TextChanged += new System.EventHandler(this.WithdrawAmountAndDeposit_TextChanged);
            // 
            // Bank_account_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 303);
            this.Controls.Add(this.WithdrawAmountAndDeposit);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.Withdraw);
            this.Controls.Add(this.Balance);
            this.Name = "Bank_account_form";
            this.Text = "Bank_account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox WithdrawAmountAndDeposit;
    }
}

