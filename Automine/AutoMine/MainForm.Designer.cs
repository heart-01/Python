
namespace AutoMine
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alertLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionWAXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferWaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transferTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgTotal = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblWood = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.AssetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MsgGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeAsset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCPU = new System.Windows.Forms.Label();
            this.timeCPU = new System.Windows.Forms.Timer(this.components);
            this.bgCPU = new System.ComponentModel.BackgroundWorker();
            this.lblWAX = new System.Windows.Forms.Label();
            this.cbGold = new System.Windows.Forms.CheckBox();
            this.cbFood = new System.Windows.Forms.CheckBox();
            this.lblMarkX = new System.Windows.Forms.Label();
            this.lblTF = new System.Windows.Forms.Label();
            this.lblTW = new System.Windows.Forms.Label();
            this.lblTG = new System.Windows.Forms.Label();
            this.lblStake = new System.Windows.Forms.Label();
            this.bgTransfer = new System.ComponentModel.BackgroundWorker();
            this.bgSell = new System.ComponentModel.BackgroundWorker();
            this.bgDeposit = new System.ComponentModel.BackgroundWorker();
            this.timerHr = new System.Windows.Forms.Timer(this.components);
            this.bgHr = new System.ComponentModel.BackgroundWorker();
            this.lblbGold = new System.Windows.Forms.Label();
            this.lblbFood = new System.Windows.Forms.Label();
            this.lblbRepair = new System.Windows.Forms.Label();
            this.lblWGold = new System.Windows.Forms.Label();
            this.lblWFood = new System.Windows.Forms.Label();
            this.bgTransferToken = new System.ComponentModel.BackgroundWorker();
            this.lblFee = new System.Windows.Forms.Label();
            this.txtBuyGold = new System.Windows.Forms.NumericUpDown();
            this.txtBuyFood = new System.Windows.Forms.NumericUpDown();
            this.txtRepair = new System.Windows.Forms.NumericUpDown();
            this.txtWGold = new System.Windows.Forms.NumericUpDown();
            this.txtWFood = new System.Windows.Forms.NumericUpDown();
            this.txtEnergyFood = new System.Windows.Forms.NumericUpDown();
            this.lblEnergyFood = new System.Windows.Forms.Label();
            this.txtCovertWOOD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerCheckFee = new System.Windows.Forms.Timer(this.components);
            this.bgCheckFee = new System.ComponentModel.BackgroundWorker();
            this.txtCovertGOLD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCovertFOOD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pbVat = new System.Windows.Forms.PictureBox();
            this.pbFOOD = new System.Windows.Forms.PictureBox();
            this.pbWOOD = new System.Windows.Forms.PictureBox();
            this.pbGold = new System.Windows.Forms.PictureBox();
            this.btnWithdrawGOLD = new System.Windows.Forms.Button();
            this.btnWithdrawFOOD = new System.Windows.Forms.Button();
            this.btnDepositGold = new System.Windows.Forms.Button();
            this.btnDepositFOOD = new System.Windows.Forms.Button();
            this.btnDepositWood = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuyGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuyFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnergyFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCovertWOOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCovertGOLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCovertFOOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFOOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWOOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGold)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alertLineToolStripMenuItem,
            this.functionWAXToolStripMenuItem,
            this.userTransferToolStripMenuItem,
            this.functionTokenToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alertLineToolStripMenuItem
            // 
            this.alertLineToolStripMenuItem.Name = "alertLineToolStripMenuItem";
            this.alertLineToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.alertLineToolStripMenuItem.Text = "Line";
            this.alertLineToolStripMenuItem.Click += new System.EventHandler(this.LineNotifyToolStripMenuItem_Click);
            // 
            // functionWAXToolStripMenuItem
            // 
            this.functionWAXToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputAccountToolStripMenuItem,
            this.transferWaxToolStripMenuItem,
            this.configToolStripMenuItem,
            this.depositToolStripMenuItem});
            this.functionWAXToolStripMenuItem.Name = "functionWAXToolStripMenuItem";
            this.functionWAXToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.functionWAXToolStripMenuItem.Text = "FunctionWAX";
            // 
            // inputAccountToolStripMenuItem
            // 
            this.inputAccountToolStripMenuItem.Name = "inputAccountToolStripMenuItem";
            this.inputAccountToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.inputAccountToolStripMenuItem.Text = "Input account";
            this.inputAccountToolStripMenuItem.Click += new System.EventHandler(this.InputAccountToolStripMenuItem_Click);
            // 
            // transferWaxToolStripMenuItem
            // 
            this.transferWaxToolStripMenuItem.Name = "transferWaxToolStripMenuItem";
            this.transferWaxToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.transferWaxToolStripMenuItem.Text = "TransferWax";
            this.transferWaxToolStripMenuItem.Click += new System.EventHandler(this.TransferWaxToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configToolStripMenuItem.Text = "Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.ConfigToolStripMenuItem_Click);
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.DepositToolStripMenuItem_Click);
            // 
            // userTransferToolStripMenuItem
            // 
            this.userTransferToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userTransferToolStripMenuItem.Name = "userTransferToolStripMenuItem";
            this.userTransferToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.userTransferToolStripMenuItem.Text = "User Transfer";
            this.userTransferToolStripMenuItem.Click += new System.EventHandler(this.UserTransferToolStripMenuItem_Click);
            // 
            // functionTokenToolStripMenuItem
            // 
            this.functionTokenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputAccountToolStripMenuItem1,
            this.transferTokenToolStripMenuItem});
            this.functionTokenToolStripMenuItem.Name = "functionTokenToolStripMenuItem";
            this.functionTokenToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.functionTokenToolStripMenuItem.Text = "FunctionToken";
            // 
            // inputAccountToolStripMenuItem1
            // 
            this.inputAccountToolStripMenuItem1.Name = "inputAccountToolStripMenuItem1";
            this.inputAccountToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.inputAccountToolStripMenuItem1.Text = "InputAccount";
            this.inputAccountToolStripMenuItem1.Click += new System.EventHandler(this.InputAccountToolStripMenuItem1_Click);
            // 
            // transferTokenToolStripMenuItem
            // 
            this.transferTokenToolStripMenuItem.Name = "transferTokenToolStripMenuItem";
            this.transferTokenToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.transferTokenToolStripMenuItem.Text = "TransferToken";
            this.transferTokenToolStripMenuItem.Click += new System.EventHandler(this.TransferTokenToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.saveFileToolStripMenuItem.Text = "SaveFile";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // bgTotal
            // 
            this.bgTotal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgTotal_DoWork);
            // 
            // timer1
            // 
            this.timer1.Interval = 120000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(13, 29);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(56, 13);
            this.lblAccount.TabIndex = 2;
            this.lblAccount.Text = "Account : ";
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(109, 29);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(47, 13);
            this.lblToken.TabIndex = 3;
            this.lblToken.Text = "Token : ";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGold.Location = new System.Drawing.Point(44, 94);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(68, 17);
            this.lblGold.TabIndex = 4;
            this.lblGold.Text = "GOLD : 0";
            // 
            // lblWood
            // 
            this.lblWood.AutoSize = true;
            this.lblWood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWood.Location = new System.Drawing.Point(40, 138);
            this.lblWood.Name = "lblWood";
            this.lblWood.Size = new System.Drawing.Size(73, 17);
            this.lblWood.TabIndex = 5;
            this.lblWood.Text = "WOOD : 0";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.Location = new System.Drawing.Point(44, 181);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(68, 17);
            this.lblFood.TabIndex = 6;
            this.lblFood.Text = "FOOD : 0";
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Location = new System.Drawing.Point(13, 57);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(46, 13);
            this.lblEnergy.TabIndex = 7;
            this.lblEnergy.Text = "Energy :";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(110, 57);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(30, 13);
            this.lblMsg.TabIndex = 8;
            this.lblMsg.Text = "Msg.";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssetID,
            this.ItemName,
            this.NextTime,
            this.Action,
            this.MsgGrid,
            this.TypeAsset});
            this.dgvList.GridColor = System.Drawing.Color.White;
            this.dgvList.Location = new System.Drawing.Point(6, 300);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dgvList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Yellow;
            this.dgvList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Yellow;
            this.dgvList.RowTemplate.Height = 25;
            this.dgvList.Size = new System.Drawing.Size(1028, 303);
            this.dgvList.TabIndex = 6;
            // 
            // AssetID
            // 
            this.AssetID.HeaderText = "AssetID";
            this.AssetID.MinimumWidth = 6;
            this.AssetID.Name = "AssetID";
            this.AssetID.ReadOnly = true;
            this.AssetID.Width = 150;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 125;
            // 
            // NextTime
            // 
            this.NextTime.HeaderText = "NEXT TIME";
            this.NextTime.MinimumWidth = 6;
            this.NextTime.Name = "NextTime";
            this.NextTime.ReadOnly = true;
            this.NextTime.Width = 150;
            // 
            // Action
            // 
            this.Action.HeaderText = "ACTION";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 125;
            // 
            // MsgGrid
            // 
            this.MsgGrid.HeaderText = "MESSAGE";
            this.MsgGrid.MinimumWidth = 6;
            this.MsgGrid.Name = "MsgGrid";
            this.MsgGrid.ReadOnly = true;
            this.MsgGrid.Width = 310;
            // 
            // TypeAsset
            // 
            this.TypeAsset.HeaderText = "TYPE";
            this.TypeAsset.MinimumWidth = 6;
            this.TypeAsset.Name = "TypeAsset";
            this.TypeAsset.ReadOnly = true;
            this.TypeAsset.Width = 125;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.Location = new System.Drawing.Point(297, 138);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(44, 17);
            this.lblCPU.TabIndex = 10;
            this.lblCPU.Text = "CPU :";
            // 
            // timeCPU
            // 
            this.timeCPU.Interval = 30000;
            this.timeCPU.Tick += new System.EventHandler(this.TimeCPU_Tick);
            // 
            // bgCPU
            // 
            this.bgCPU.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgCPU_DoWork);
            // 
            // lblWAX
            // 
            this.lblWAX.AutoSize = true;
            this.lblWAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWAX.Location = new System.Drawing.Point(294, 94);
            this.lblWAX.Name = "lblWAX";
            this.lblWAX.Size = new System.Drawing.Size(47, 17);
            this.lblWAX.TabIndex = 11;
            this.lblWAX.Text = "WAX :";
            // 
            // cbGold
            // 
            this.cbGold.AutoSize = true;
            this.cbGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGold.Location = new System.Drawing.Point(177, 211);
            this.cbGold.Name = "cbGold";
            this.cbGold.Size = new System.Drawing.Size(91, 22);
            this.cbGold.TabIndex = 13;
            this.cbGold.Text = "ซื้อ GOLD";
            this.cbGold.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            this.cbFood.AutoSize = true;
            this.cbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFood.Location = new System.Drawing.Point(287, 211);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(92, 22);
            this.cbFood.TabIndex = 14;
            this.cbFood.Text = "ซื้อ FOOD";
            this.cbFood.UseVisualStyleBackColor = true;
            // 
            // lblMarkX
            // 
            this.lblMarkX.AutoSize = true;
            this.lblMarkX.Location = new System.Drawing.Point(110, 29);
            this.lblMarkX.Name = "lblMarkX";
            this.lblMarkX.Size = new System.Drawing.Size(287, 13);
            this.lblMarkX.TabIndex = 16;
            this.lblMarkX.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            this.lblMarkX.Visible = false;
            // 
            // lblTF
            // 
            this.lblTF.AutoSize = true;
            this.lblTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTF.Location = new System.Drawing.Point(179, 181);
            this.lblTF.Name = "lblTF";
            this.lblTF.Size = new System.Drawing.Size(85, 17);
            this.lblTF.TabIndex = 19;
            this.lblTF.Text = "0.0000 FWF";
            // 
            // lblTW
            // 
            this.lblTW.AutoSize = true;
            this.lblTW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTW.Location = new System.Drawing.Point(179, 138);
            this.lblTW.Name = "lblTW";
            this.lblTW.Size = new System.Drawing.Size(90, 17);
            this.lblTW.TabIndex = 18;
            this.lblTW.Text = "0.0000 FWW";
            // 
            // lblTG
            // 
            this.lblTG.AutoSize = true;
            this.lblTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTG.Location = new System.Drawing.Point(179, 94);
            this.lblTG.Name = "lblTG";
            this.lblTG.Size = new System.Drawing.Size(88, 17);
            this.lblTG.TabIndex = 17;
            this.lblTG.Text = "0.0000 FWG";
            // 
            // lblStake
            // 
            this.lblStake.AutoSize = true;
            this.lblStake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStake.Location = new System.Drawing.Point(280, 181);
            this.lblStake.Name = "lblStake";
            this.lblStake.Size = new System.Drawing.Size(61, 17);
            this.lblStake.TabIndex = 21;
            this.lblStake.Text = "STAKE :";
            // 
            // bgTransfer
            // 
            this.bgTransfer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgTransfer_DoWork);
            // 
            // bgSell
            // 
            this.bgSell.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgSell_DoWork);
            // 
            // bgDeposit
            // 
            this.bgDeposit.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgDeposit_DoWork);
            // 
            // timerHr
            // 
            this.timerHr.Interval = 3600000;
            this.timerHr.Tick += new System.EventHandler(this.TimerHr_Tick);
            // 
            // bgHr
            // 
            this.bgHr.WorkerSupportsCancellation = true;
            this.bgHr.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgHr_DoWork);
            // 
            // lblbGold
            // 
            this.lblbGold.AutoSize = true;
            this.lblbGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbGold.Location = new System.Drawing.Point(689, 48);
            this.lblbGold.Name = "lblbGold";
            this.lblbGold.Size = new System.Drawing.Size(131, 18);
            this.lblbGold.TabIndex = 24;
            this.lblbGold.Text = "เติมทองเมื่อทองต่ำกว่า";
            // 
            // lblbFood
            // 
            this.lblbFood.AutoSize = true;
            this.lblbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbFood.Location = new System.Drawing.Point(689, 117);
            this.lblbFood.Name = "lblbFood";
            this.lblbFood.Size = new System.Drawing.Size(157, 18);
            this.lblbFood.TabIndex = 26;
            this.lblbFood.Text = "เติมอาหารเมื่ออาหารต่ำกว่า";
            // 
            // lblbRepair
            // 
            this.lblbRepair.AutoSize = true;
            this.lblbRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbRepair.Location = new System.Drawing.Point(691, 180);
            this.lblbRepair.Name = "lblbRepair";
            this.lblbRepair.Size = new System.Drawing.Size(152, 18);
            this.lblbRepair.TabIndex = 28;
            this.lblbRepair.Text = "ซ่อมอุปกรณ์เมื่อเหลือกี่ %";
            // 
            // lblWGold
            // 
            this.lblWGold.AutoSize = true;
            this.lblWGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWGold.Location = new System.Drawing.Point(853, 48);
            this.lblWGold.Name = "lblWGold";
            this.lblWGold.Size = new System.Drawing.Size(128, 18);
            this.lblWGold.TabIndex = 30;
            this.lblWGold.Text = "ซื้อทองเท่าไหร่ WAX";
            // 
            // lblWFood
            // 
            this.lblWFood.AutoSize = true;
            this.lblWFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWFood.Location = new System.Drawing.Point(853, 117);
            this.lblWFood.Name = "lblWFood";
            this.lblWFood.Size = new System.Drawing.Size(141, 18);
            this.lblWFood.TabIndex = 32;
            this.lblWFood.Text = "ซื้ออาหารเท่าไหร่ WAX";
            // 
            // bgTransferToken
            // 
            this.bgTransferToken.WorkerSupportsCancellation = true;
            this.bgTransferToken.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgTransferToken_DoWork);
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFee.Location = new System.Drawing.Point(44, 213);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(42, 17);
            this.lblFee.TabIndex = 33;
            this.lblFee.Text = "FEE :";
            // 
            // txtBuyGold
            // 
            this.txtBuyGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyGold.Location = new System.Drawing.Point(692, 72);
            this.txtBuyGold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuyGold.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtBuyGold.Name = "txtBuyGold";
            this.txtBuyGold.Size = new System.Drawing.Size(139, 23);
            this.txtBuyGold.TabIndex = 36;
            // 
            // txtBuyFood
            // 
            this.txtBuyFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyFood.Location = new System.Drawing.Point(692, 141);
            this.txtBuyFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuyFood.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtBuyFood.Name = "txtBuyFood";
            this.txtBuyFood.Size = new System.Drawing.Size(139, 23);
            this.txtBuyFood.TabIndex = 37;
            // 
            // txtRepair
            // 
            this.txtRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepair.Location = new System.Drawing.Point(695, 204);
            this.txtRepair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRepair.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtRepair.Name = "txtRepair";
            this.txtRepair.Size = new System.Drawing.Size(136, 23);
            this.txtRepair.TabIndex = 38;
            // 
            // txtWGold
            // 
            this.txtWGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWGold.Location = new System.Drawing.Point(856, 72);
            this.txtWGold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWGold.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtWGold.Name = "txtWGold";
            this.txtWGold.Size = new System.Drawing.Size(158, 23);
            this.txtWGold.TabIndex = 39;
            // 
            // txtWFood
            // 
            this.txtWFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWFood.Location = new System.Drawing.Point(856, 141);
            this.txtWFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWFood.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtWFood.Name = "txtWFood";
            this.txtWFood.Size = new System.Drawing.Size(158, 23);
            this.txtWFood.TabIndex = 40;
            // 
            // txtEnergyFood
            // 
            this.txtEnergyFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnergyFood.Location = new System.Drawing.Point(856, 205);
            this.txtEnergyFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEnergyFood.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtEnergyFood.Name = "txtEnergyFood";
            this.txtEnergyFood.Size = new System.Drawing.Size(158, 23);
            this.txtEnergyFood.TabIndex = 47;
            this.txtEnergyFood.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // lblEnergyFood
            // 
            this.lblEnergyFood.AutoSize = true;
            this.lblEnergyFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergyFood.Location = new System.Drawing.Point(853, 181);
            this.lblEnergyFood.Name = "lblEnergyFood";
            this.lblEnergyFood.Size = new System.Drawing.Size(167, 18);
            this.lblEnergyFood.TabIndex = 46;
            this.lblEnergyFood.Text = "กินเนื้อเมื่อ Energy น้อยกว่า";
            // 
            // txtCovertWOOD
            // 
            this.txtCovertWOOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCovertWOOD.Location = new System.Drawing.Point(6, 272);
            this.txtCovertWOOD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCovertWOOD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtCovertWOOD.Name = "txtCovertWOOD";
            this.txtCovertWOOD.Size = new System.Drawing.Size(114, 23);
            this.txtCovertWOOD.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "แลกไม้เมื่อ FEE 5%";
            // 
            // TimerCheckFee
            // 
            this.TimerCheckFee.Interval = 120000;
            this.TimerCheckFee.Tick += new System.EventHandler(this.TimerCheckFee_Tick);
            // 
            // bgCheckFee
            // 
            this.bgCheckFee.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgCheckFee_DoWork);
            // 
            // txtCovertGOLD
            // 
            this.txtCovertGOLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCovertGOLD.Location = new System.Drawing.Point(142, 272);
            this.txtCovertGOLD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCovertGOLD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtCovertGOLD.Name = "txtCovertGOLD";
            this.txtCovertGOLD.Size = new System.Drawing.Size(130, 23);
            this.txtCovertGOLD.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "แลกทองเมื่อ FEE 5%";
            // 
            // txtCovertFOOD
            // 
            this.txtCovertFOOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCovertFOOD.Location = new System.Drawing.Point(302, 272);
            this.txtCovertFOOD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCovertFOOD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtCovertFOOD.Name = "txtCovertFOOD";
            this.txtCovertFOOD.Size = new System.Drawing.Size(133, 23);
            this.txtCovertFOOD.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "แลกอาหารเมื่อ FEE 5%";
            // 
            // pbVat
            // 
            this.pbVat.Image = global::AutoMine.Properties.Resources.Vat;
            this.pbVat.Location = new System.Drawing.Point(8, 207);
            this.pbVat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbVat.Name = "pbVat";
            this.pbVat.Size = new System.Drawing.Size(31, 28);
            this.pbVat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVat.TabIndex = 57;
            this.pbVat.TabStop = false;
            // 
            // pbFOOD
            // 
            this.pbFOOD.Image = global::AutoMine.Properties.Resources.FWF2;
            this.pbFOOD.Location = new System.Drawing.Point(8, 170);
            this.pbFOOD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbFOOD.Name = "pbFOOD";
            this.pbFOOD.Size = new System.Drawing.Size(31, 28);
            this.pbFOOD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFOOD.TabIndex = 45;
            this.pbFOOD.TabStop = false;
            // 
            // pbWOOD
            // 
            this.pbWOOD.Image = global::AutoMine.Properties.Resources.FWW2;
            this.pbWOOD.Location = new System.Drawing.Point(8, 127);
            this.pbWOOD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbWOOD.Name = "pbWOOD";
            this.pbWOOD.Size = new System.Drawing.Size(31, 28);
            this.pbWOOD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWOOD.TabIndex = 44;
            this.pbWOOD.TabStop = false;
            // 
            // pbGold
            // 
            this.pbGold.Image = global::AutoMine.Properties.Resources.FWG2;
            this.pbGold.Location = new System.Drawing.Point(8, 85);
            this.pbGold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbGold.Name = "pbGold";
            this.pbGold.Size = new System.Drawing.Size(31, 28);
            this.pbGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGold.TabIndex = 43;
            this.pbGold.TabStop = false;
            // 
            // btnWithdrawGOLD
            // 
            this.btnWithdrawGOLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnWithdrawGOLD.Image = global::AutoMine.Properties.Resources.FWG2;
            this.btnWithdrawGOLD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdrawGOLD.Location = new System.Drawing.Point(553, 155);
            this.btnWithdrawGOLD.Name = "btnWithdrawGOLD";
            this.btnWithdrawGOLD.Size = new System.Drawing.Size(130, 33);
            this.btnWithdrawGOLD.TabIndex = 42;
            this.btnWithdrawGOLD.Text = "ถอน GOLD";
            this.btnWithdrawGOLD.UseVisualStyleBackColor = true;
            this.btnWithdrawGOLD.Click += new System.EventHandler(this.btnWithdrawGOLD_Click);
            // 
            // btnWithdrawFOOD
            // 
            this.btnWithdrawFOOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnWithdrawFOOD.Image = global::AutoMine.Properties.Resources.FWF2;
            this.btnWithdrawFOOD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdrawFOOD.Location = new System.Drawing.Point(553, 98);
            this.btnWithdrawFOOD.Name = "btnWithdrawFOOD";
            this.btnWithdrawFOOD.Size = new System.Drawing.Size(130, 33);
            this.btnWithdrawFOOD.TabIndex = 41;
            this.btnWithdrawFOOD.Text = "ถอน FOOD";
            this.btnWithdrawFOOD.UseVisualStyleBackColor = true;
            this.btnWithdrawFOOD.Click += new System.EventHandler(this.btnWithdrawFOOD_Click);
            // 
            // btnDepositGold
            // 
            this.btnDepositGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDepositGold.Image = global::AutoMine.Properties.Resources.FWG2;
            this.btnDepositGold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepositGold.Location = new System.Drawing.Point(408, 155);
            this.btnDepositGold.Name = "btnDepositGold";
            this.btnDepositGold.Size = new System.Drawing.Size(130, 36);
            this.btnDepositGold.TabIndex = 16;
            this.btnDepositGold.Text = "ฝาก GOLD";
            this.btnDepositGold.UseVisualStyleBackColor = true;
            this.btnDepositGold.Click += new System.EventHandler(this.btnDepositGold_Click);
            // 
            // btnDepositFOOD
            // 
            this.btnDepositFOOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDepositFOOD.Image = global::AutoMine.Properties.Resources.FWF2;
            this.btnDepositFOOD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepositFOOD.Location = new System.Drawing.Point(408, 98);
            this.btnDepositFOOD.Name = "btnDepositFOOD";
            this.btnDepositFOOD.Size = new System.Drawing.Size(130, 36);
            this.btnDepositFOOD.TabIndex = 35;
            this.btnDepositFOOD.Text = "ฝาก FOOD";
            this.btnDepositFOOD.UseVisualStyleBackColor = true;
            this.btnDepositFOOD.Click += new System.EventHandler(this.btnDepositFOOD_Click);
            // 
            // btnDepositWood
            // 
            this.btnDepositWood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDepositWood.Image = global::AutoMine.Properties.Resources.FWW2;
            this.btnDepositWood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepositWood.Location = new System.Drawing.Point(408, 48);
            this.btnDepositWood.Name = "btnDepositWood";
            this.btnDepositWood.Size = new System.Drawing.Size(130, 36);
            this.btnDepositWood.TabIndex = 34;
            this.btnDepositWood.Text = "ฝาก WOOD";
            this.btnDepositWood.UseVisualStyleBackColor = true;
            this.btnDepositWood.Click += new System.EventHandler(this.btnDepositWood_Click);
            // 
            // btnSell
            // 
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSell.Image = global::AutoMine.Properties.Resources.FWW2;
            this.btnSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.Location = new System.Drawing.Point(408, 202);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(275, 33);
            this.btnSell.TabIndex = 22;
            this.btnSell.Text = "ขายไม้ราคาตลาด";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.BtnSell_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnWithdraw.Image = global::AutoMine.Properties.Resources.FWW2;
            this.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.Location = new System.Drawing.Point(553, 48);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(130, 33);
            this.btnWithdraw.TabIndex = 15;
            this.btnWithdraw.Text = "ถอน WOOD";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.BtnWithdraw_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 603);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pbVat);
            this.Controls.Add(this.txtCovertFOOD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCovertGOLD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCovertWOOD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnergyFood);
            this.Controls.Add(this.lblEnergyFood);
            this.Controls.Add(this.pbFOOD);
            this.Controls.Add(this.pbWOOD);
            this.Controls.Add(this.pbGold);
            this.Controls.Add(this.btnWithdrawGOLD);
            this.Controls.Add(this.btnWithdrawFOOD);
            this.Controls.Add(this.txtWFood);
            this.Controls.Add(this.txtWGold);
            this.Controls.Add(this.txtRepair);
            this.Controls.Add(this.txtBuyFood);
            this.Controls.Add(this.txtBuyGold);
            this.Controls.Add(this.btnDepositGold);
            this.Controls.Add(this.btnDepositFOOD);
            this.Controls.Add(this.btnDepositWood);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblWFood);
            this.Controls.Add(this.lblWGold);
            this.Controls.Add(this.lblbRepair);
            this.Controls.Add(this.lblbFood);
            this.Controls.Add(this.lblbGold);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.lblStake);
            this.Controls.Add(this.lblTF);
            this.Controls.Add(this.lblTW);
            this.Controls.Add(this.lblTG);
            this.Controls.Add(this.lblMarkX);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.cbFood);
            this.Controls.Add(this.cbGold);
            this.Controls.Add(this.lblWAX);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblEnergy);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lblWood);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmers World";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuyGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuyFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnergyFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCovertWOOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCovertGOLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCovertFOOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFOOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWOOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alertLineToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgTotal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblWood;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Timer timeCPU;
        private System.ComponentModel.BackgroundWorker bgCPU;
        private System.Windows.Forms.Label lblWAX;
        private System.Windows.Forms.CheckBox cbGold;
        private System.Windows.Forms.CheckBox cbFood;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblMarkX;
        private System.Windows.Forms.Label lblTF;
        private System.Windows.Forms.Label lblTW;
        private System.Windows.Forms.Label lblTG;
        private System.Windows.Forms.Label lblStake;
        private System.Windows.Forms.ToolStripMenuItem functionWAXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferWaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userTransferToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgTransfer;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.Button btnSell;
        private System.ComponentModel.BackgroundWorker bgSell;
        private System.ComponentModel.BackgroundWorker bgDeposit;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.Timer timerHr;
        private System.ComponentModel.BackgroundWorker bgHr;
        private System.Windows.Forms.Label lblbGold;
        private System.Windows.Forms.Label lblbFood;
        private System.Windows.Forms.Label lblbRepair;
        private System.Windows.Forms.Label lblWGold;
        private System.Windows.Forms.Label lblWFood;
        private System.Windows.Forms.ToolStripMenuItem functionTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputAccountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transferTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgTransferToken;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Button btnDepositWood;
        private System.Windows.Forms.Button btnDepositFOOD;
        private System.Windows.Forms.Button btnDepositGold;
        private System.Windows.Forms.NumericUpDown txtBuyGold;
        private System.Windows.Forms.NumericUpDown txtBuyFood;
        private System.Windows.Forms.NumericUpDown txtRepair;
        private System.Windows.Forms.NumericUpDown txtWGold;
        private System.Windows.Forms.NumericUpDown txtWFood;
        private System.Windows.Forms.Button btnWithdrawFOOD;
        private System.Windows.Forms.Button btnWithdrawGOLD;
        private System.Windows.Forms.PictureBox pbGold;
        private System.Windows.Forms.PictureBox pbWOOD;
        private System.Windows.Forms.PictureBox pbFOOD;
        private System.Windows.Forms.NumericUpDown txtEnergyFood;
        private System.Windows.Forms.Label lblEnergyFood;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeAsset;
        private System.Windows.Forms.NumericUpDown txtCovertWOOD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerCheckFee;
        private System.ComponentModel.BackgroundWorker bgCheckFee;
        private System.Windows.Forms.NumericUpDown txtCovertGOLD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtCovertFOOD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbVat;
    }
}

