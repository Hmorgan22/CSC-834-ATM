
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
            this.withdrawAmountPanel = new System.Windows.Forms.Panel();
            this.withdrawAmountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.withdrawEnterBtn = new System.Windows.Forms.Button();
            this.mainMenuPanel.SuspendLayout();
            this.withdrawAccountSelectionPanel.SuspendLayout();
            this.limitErrorPanel.SuspendLayout();
            this.withdrawAmountPanel.SuspendLayout();
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
            // withdrawAmountPanel
            // 
            this.withdrawAmountPanel.Controls.Add(this.withdrawEnterBtn);
            this.withdrawAmountPanel.Controls.Add(this.button12);
            this.withdrawAmountPanel.Controls.Add(this.button11);
            this.withdrawAmountPanel.Controls.Add(this.button10);
            this.withdrawAmountPanel.Controls.Add(this.button9);
            this.withdrawAmountPanel.Controls.Add(this.button8);
            this.withdrawAmountPanel.Controls.Add(this.button7);
            this.withdrawAmountPanel.Controls.Add(this.button6);
            this.withdrawAmountPanel.Controls.Add(this.button5);
            this.withdrawAmountPanel.Controls.Add(this.button4);
            this.withdrawAmountPanel.Controls.Add(this.button3);
            this.withdrawAmountPanel.Controls.Add(this.button2);
            this.withdrawAmountPanel.Controls.Add(this.button1);
            this.withdrawAmountPanel.Controls.Add(this.label3);
            this.withdrawAmountPanel.Controls.Add(this.withdrawAmountTextBox);
            this.withdrawAmountPanel.Location = new System.Drawing.Point(136, 12);
            this.withdrawAmountPanel.Name = "withdrawAmountPanel";
            this.withdrawAmountPanel.Size = new System.Drawing.Size(291, 241);
            this.withdrawAmountPanel.TabIndex = 7;
            // 
            // withdrawAmountTextBox
            // 
            this.withdrawAmountTextBox.Location = new System.Drawing.Point(77, 50);
            this.withdrawAmountTextBox.Name = "withdrawAmountTextBox";
            this.withdrawAmountTextBox.Size = new System.Drawing.Size(134, 20);
            this.withdrawAmountTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter amout to withdraw";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(108, 105);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(189, 105);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 134);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(108, 134);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(189, 134);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(27, 163);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 17;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(108, 163);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 18;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(189, 163);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 19;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // withdrawEnterBtn
            // 
            this.withdrawEnterBtn.Location = new System.Drawing.Point(99, 203);
            this.withdrawEnterBtn.Name = "withdrawEnterBtn";
            this.withdrawEnterBtn.Size = new System.Drawing.Size(103, 23);
            this.withdrawEnterBtn.TabIndex = 20;
            this.withdrawEnterBtn.Text = "Enter";
            this.withdrawEnterBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2043, 1071);
            this.Controls.Add(this.withdrawAmountPanel);
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
            this.withdrawAmountPanel.ResumeLayout(false);
            this.withdrawAmountPanel.PerformLayout();
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
        private System.Windows.Forms.Panel withdrawAmountPanel;
        private System.Windows.Forms.Button withdrawEnterBtn;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox withdrawAmountTextBox;
    }
}

