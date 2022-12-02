namespace ATM_WindowsFormsApp
{
    partial class ATM_window
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
            this.label1 = new System.Windows.Forms.Label();
            this.Deposit_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Withdraw_btn = new System.Windows.Forms.Button();
            this.Balance_btn = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Select_Bank = new System.Windows.Forms.ComboBox();
            this.Select_ATM = new System.Windows.Forms.ComboBox();
            this.id_atm = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Х";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Deposit_btn
            // 
            this.Deposit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deposit_btn.Location = new System.Drawing.Point(22, 13);
            this.Deposit_btn.Name = "Deposit_btn";
            this.Deposit_btn.Size = new System.Drawing.Size(130, 47);
            this.Deposit_btn.TabIndex = 2;
            this.Deposit_btn.Text = "Поповнити";
            this.Deposit_btn.UseVisualStyleBackColor = true;
            this.Deposit_btn.Click += new System.EventHandler(this.Deposit_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(173, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Термінал";
            // 
            // Withdraw_btn
            // 
            this.Withdraw_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Withdraw_btn.Location = new System.Drawing.Point(338, 13);
            this.Withdraw_btn.Name = "Withdraw_btn";
            this.Withdraw_btn.Size = new System.Drawing.Size(130, 47);
            this.Withdraw_btn.TabIndex = 4;
            this.Withdraw_btn.Text = "Зняти";
            this.Withdraw_btn.UseVisualStyleBackColor = true;
            this.Withdraw_btn.Click += new System.EventHandler(this.Withdraw_btn_Click);
            // 
            // Balance_btn
            // 
            this.Balance_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Balance_btn.Location = new System.Drawing.Point(22, 76);
            this.Balance_btn.Name = "Balance_btn";
            this.Balance_btn.Size = new System.Drawing.Size(130, 47);
            this.Balance_btn.TabIndex = 5;
            this.Balance_btn.Text = "Баланс";
            this.Balance_btn.UseVisualStyleBackColor = true;
            this.Balance_btn.Click += new System.EventHandler(this.Balance_btn_Click);
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount.Location = new System.Drawing.Point(158, 44);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(174, 38);
            this.amount.TabIndex = 5;
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user.Location = new System.Drawing.Point(64, 64);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(0, 25);
            this.user.TabIndex = 6;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(338, 76);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(129, 47);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Вийти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Банк";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(366, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Термінал";
            // 
            // Select_Bank
            // 
            this.Select_Bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Select_Bank.FormattingEnabled = true;
            this.Select_Bank.Location = new System.Drawing.Point(15, 260);
            this.Select_Bank.Name = "Select_Bank";
            this.Select_Bank.Size = new System.Drawing.Size(127, 28);
            this.Select_Bank.TabIndex = 12;
            this.Select_Bank.SelectedIndexChanged += new System.EventHandler(this.Select_Bank_SelectedIndexChanged);
            // 
            // Select_ATM
            // 
            this.Select_ATM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Select_ATM.FormattingEnabled = true;
            this.Select_ATM.Location = new System.Drawing.Point(330, 260);
            this.Select_ATM.Name = "Select_ATM";
            this.Select_ATM.Size = new System.Drawing.Size(127, 28);
            this.Select_ATM.TabIndex = 13;
            this.Select_ATM.SelectedIndexChanged += new System.EventHandler(this.Select_ATM_SelectedIndexChanged);
            // 
            // id_atm
            // 
            this.id_atm.AutoSize = true;
            this.id_atm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_atm.Location = new System.Drawing.Point(64, 104);
            this.id_atm.Name = "id_atm";
            this.id_atm.Size = new System.Drawing.Size(0, 25);
            this.id_atm.TabIndex = 14;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address.Location = new System.Drawing.Point(64, 139);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(0, 25);
            this.address.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.Deposit_btn);
            this.panel1.Controls.Add(this.Withdraw_btn);
            this.panel1.Controls.Add(this.Balance_btn);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Location = new System.Drawing.Point(-9, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 137);
            this.panel1.TabIndex = 16;
            // 
            // ATM_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(470, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.id_atm);
            this.Controls.Add(this.Select_ATM);
            this.Controls.Add(this.Select_Bank);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ATM_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_window_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Withdraw_btn;
        private System.Windows.Forms.Button Balance_btn;
        private System.Windows.Forms.Button Deposit_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Select_Bank;
        private System.Windows.Forms.ComboBox Select_ATM;
        private System.Windows.Forms.Label id_atm;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Panel panel1;
    }
}