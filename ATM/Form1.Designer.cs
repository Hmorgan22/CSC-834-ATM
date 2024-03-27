
namespace ATM
{
    partial class Form1
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.depositBtn = new System.Windows.Forms.Button();
            this.checkBalanceBtn = new System.Windows.Forms.Button();
            this.transferBtn = new System.Windows.Forms.Button();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.withdrawAccountSelectionPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.WithdrawAccountList = new System.Windows.Forms.ListBox();
            this.limitErrorPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.errorReturnBtn = new System.Windows.Forms.Button();
            this.mainMenuPanel.SuspendLayout();
            this.withdrawAccountSelectionPanel.SuspendLayout();
            this.limitErrorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(709, 286);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(197, 139);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.Location = new System.Drawing.Point(54, 38);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(197, 139);
            this.WithdrawBtn.TabIndex = 1;
            this.WithdrawBtn.Text = "Withdraw Money";
            this.WithdrawBtn.UseVisualStyleBackColor = true;
            this.WithdrawBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(395, 47);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(197, 139);
            this.depositBtn.TabIndex = 2;
            this.depositBtn.Text = "Deposit Money";
            this.depositBtn.UseVisualStyleBackColor = true;
            // 
            // checkBalanceBtn
            // 
            this.checkBalanceBtn.Location = new System.Drawing.Point(395, 286);
            this.checkBalanceBtn.Name = "checkBalanceBtn";
            this.checkBalanceBtn.Size = new System.Drawing.Size(197, 139);
            this.checkBalanceBtn.TabIndex = 3;
            this.checkBalanceBtn.Text = "Check Account Balance";
            this.checkBalanceBtn.UseVisualStyleBackColor = true;
            this.checkBalanceBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(54, 286);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(197, 139);
            this.transferBtn.TabIndex = 4;
            this.transferBtn.Text = "Transfer Money";
            this.transferBtn.UseVisualStyleBackColor = true;
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Controls.Add(this.WithdrawBtn);
            this.mainMenuPanel.Controls.Add(this.logoutBtn);
            this.mainMenuPanel.Controls.Add(this.checkBalanceBtn);
            this.mainMenuPanel.Controls.Add(this.transferBtn);
            this.mainMenuPanel.Controls.Add(this.depositBtn);
            this.mainMenuPanel.Location = new System.Drawing.Point(1094, 12);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(937, 494);
            this.mainMenuPanel.TabIndex = 5;
            // 
            // withdrawAccountSelectionPanel
            // 
            this.withdrawAccountSelectionPanel.Controls.Add(this.WithdrawAccountList);
            this.withdrawAccountSelectionPanel.Controls.Add(this.label1);
            this.withdrawAccountSelectionPanel.Location = new System.Drawing.Point(688, 12);
            this.withdrawAccountSelectionPanel.Name = "withdrawAccountSelectionPanel";
            this.withdrawAccountSelectionPanel.Size = new System.Drawing.Size(400, 359);
            this.withdrawAccountSelectionPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Account";
            // 
            // WithdrawAccountList
            // 
            this.WithdrawAccountList.FormattingEnabled = true;
            this.WithdrawAccountList.Location = new System.Drawing.Point(103, 81);
            this.WithdrawAccountList.Name = "WithdrawAccountList";
            this.WithdrawAccountList.Size = new System.Drawing.Size(192, 199);
            this.WithdrawAccountList.TabIndex = 1;
            // 
            // limitErrorPanel
            // 
            this.limitErrorPanel.Controls.Add(this.errorReturnBtn);
            this.limitErrorPanel.Controls.Add(this.label2);
            this.limitErrorPanel.Location = new System.Drawing.Point(433, 12);
            this.limitErrorPanel.Name = "limitErrorPanel";
            this.limitErrorPanel.Size = new System.Drawing.Size(249, 158);
            this.limitErrorPanel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "You have exceeded the daily transaction limit";
            // 
            // errorReturnBtn
            // 
            this.errorReturnBtn.Location = new System.Drawing.Point(87, 81);
            this.errorReturnBtn.Name = "errorReturnBtn";
            this.errorReturnBtn.Size = new System.Drawing.Size(75, 23);
            this.errorReturnBtn.TabIndex = 1;
            this.errorReturnBtn.Text = "return";
            this.errorReturnBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2043, 1071);
            this.Controls.Add(this.limitErrorPanel);
            this.Controls.Add(this.withdrawAccountSelectionPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainMenuPanel.ResumeLayout(false);
            this.withdrawAccountSelectionPanel.ResumeLayout(false);
            this.withdrawAccountSelectionPanel.PerformLayout();
            this.limitErrorPanel.ResumeLayout(false);
            this.limitErrorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button WithdrawBtn;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button checkBalanceBtn;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Panel withdrawAccountSelectionPanel;
        private System.Windows.Forms.ListBox WithdrawAccountList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel limitErrorPanel;
        private System.Windows.Forms.Button errorReturnBtn;
        private System.Windows.Forms.Label label2;
    }
}

