
namespace AutoMine
{
    partial class FormConfig
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtAmountUn = new System.Windows.Forms.TextBox();
            this.lblLand = new System.Windows.Forms.Label();
            this.btnUnstake = new System.Windows.Forms.Button();
            this.btnStake = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.btnStake);
            this.panel1.Controls.Add(this.lblAccount);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 108);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnUnstake);
            this.panel2.Controls.Add(this.txtAmountUn);
            this.panel2.Controls.Add(this.lblLand);
            this.panel2.Location = new System.Drawing.Point(282, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 108);
            this.panel2.TabIndex = 7;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(85, 14);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(128, 20);
            this.txtAmount.TabIndex = 10;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(12, 17);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(43, 13);
            this.lblAccount.TabIndex = 8;
            this.lblAccount.Text = "Amount";
            // 
            // txtAmountUn
            // 
            this.txtAmountUn.Location = new System.Drawing.Point(100, 10);
            this.txtAmountUn.Name = "txtAmountUn";
            this.txtAmountUn.Size = new System.Drawing.Size(117, 20);
            this.txtAmountUn.TabIndex = 7;
            // 
            // lblLand
            // 
            this.lblLand.AutoSize = true;
            this.lblLand.Location = new System.Drawing.Point(27, 13);
            this.lblLand.Name = "lblLand";
            this.lblLand.Size = new System.Drawing.Size(43, 13);
            this.lblLand.TabIndex = 0;
            this.lblLand.Text = "Amount";
            // 
            // btnUnstake
            // 
            this.btnUnstake.Location = new System.Drawing.Point(100, 53);
            this.btnUnstake.Name = "btnUnstake";
            this.btnUnstake.Size = new System.Drawing.Size(117, 28);
            this.btnUnstake.TabIndex = 10;
            this.btnUnstake.Text = "Unstake CPU";
            this.btnUnstake.UseVisualStyleBackColor = true;
            this.btnUnstake.Click += new System.EventHandler(this.BtnUnstake_Click);
            // 
            // btnStake
            // 
            this.btnStake.Location = new System.Drawing.Point(85, 53);
            this.btnStake.Name = "btnStake";
            this.btnStake.Size = new System.Drawing.Size(128, 28);
            this.btnStake.TabIndex = 11;
            this.btnStake.Text = "Stake CPU";
            this.btnStake.UseVisualStyleBackColor = true;
            this.btnStake.Click += new System.EventHandler(this.BtnStake_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 141);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.FromConfig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLand;
        private System.Windows.Forms.TextBox txtAmountUn;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnStake;
        private System.Windows.Forms.Button btnUnstake;
    }
}