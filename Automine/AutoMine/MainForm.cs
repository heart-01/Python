using AutoMine.Atomic;
using AutoMine.FarmAccount;
using AutoMine.FarmTools;
using AutoMine.GetTableRow;
using AutoMine.GetToken;
using AutoMine.Models;
using AutoMine.Models.Assets;
using AutoMine.Models.Crops;
using EOS.Client;
using EOS.Client.Cryptography;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMine
{
    public partial class MainForm : Form
    {

        readonly string FolderFile = Directory.GetCurrentDirectory();
        List<BackgroundWorker> lstWorker = new List<BackgroundWorker>();
        Get_Table_Row Table_Row;
        Transaction.Tools Tools1;
        Transaction.Membership Membership;
        Transaction.Animals animals;
        Transaction.Crops crops;
        Transaction.Withdraw withdraw;
        Transaction.Deposit deposit;
        Transaction.AlcorExchange exchange;
        Transaction.TransferWallet transferWallet;
        public MainForm()
        {
            InitializeComponent();
            FormClosing += MainForm_FormClosing;
            this.Table_Row = new Get_Table_Row(this);
            this.Tools1 = new Transaction.Tools(this);
            this.Membership = new Transaction.Membership(this);
            this.animals = new Transaction.Animals(this);
            this.crops = new Transaction.Crops(this);
            this.withdraw = new Transaction.Withdraw(this);
            this.deposit = new Transaction.Deposit(this);
            this.exchange = new Transaction.AlcorExchange(this);
            this.transferWallet = new Transaction.TransferWallet(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            DirectoryInfo di = new DirectoryInfo(FolderFile);
            FileInfo[] files = di.GetFiles("*.txt");
            List<GetFileBot> getFiles = new List<GetFileBot>();
            foreach (FileInfo file in files)
            {
                GetFileBot tmp = new GetFileBot();
                tmp.FileName = file.Name;
                tmp.PathFile = file.FullName;
                getFiles.Add(tmp);
            }
            GetFile.FileBot = getFiles;
            FormStart start = new FormStart();
            start.ShowDialog();

            OpenBot();


        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        public async void OpenBot()
        {
            try
            {

                string[] filelines = File.ReadAllLines(Globals.PATH_FILE);

                if (filelines.Length > 0)
                {
                    dgvList.Rows.Clear();
                    LoginWax.EMAIL = filelines[0].Replace("Email=", "").ToString();
                    LoginWax.PASSWORD = filelines[1].Replace("Password=", "").ToString();
                    LoginWax.FAC_PASSWORD = filelines[2].Replace("2FA=", "").ToString();
                    LoginWax.TOKEN = filelines[3].Replace("TOKEN=", "").ToString();
                    LoginWax.ACCOUNT = filelines[4].Replace("ACCOUNT=", "").ToString();

                    if (filelines[5].Replace("BUYGOLD=", "").ToString() == "1")
                    {
                        cbGold.Checked = true;
                    }
                    if (filelines[6].Replace("BUYFOOD=", "").ToString() == "1")
                    {
                        cbFood.Checked = true;
                    }

                    txtBuyGold.Text = filelines[7].Replace("LESSGOLD=", "").ToString();
                    txtBuyFood.Text = filelines[8].Replace("LESSFOOD=", "").ToString();
                    txtRepair.Text = filelines[9].Replace("REPAIR=", "").ToString();
                    txtWGold.Text = filelines[10].Replace("WAXGOLD=", "").ToString();
                    txtWFood.Text = filelines[11].Replace("WAXFOOD=", "").ToString();
                    Globals.TOKEN_LINE = filelines[12].Replace("LINETOKEN=", "").ToString();

                }

                if (LoginWax.EMAIL != "")
                {
                    LoginWallet.Login login = new LoginWallet.Login("", "", "");

                Login: await login.LoginAccount();
                    if (LoginWax.TOKEN == "")
                    {
                        TimeSpan ts = TimeSpan.FromSeconds(60);
                        lblMsg.Text = "Login error.";
                        for (int i = 60; i >= 0; i--)
                        {
                            ts = ts.Subtract(TimeSpan.FromSeconds(1));
                            lblMsg.Text = "Waiting Login " + ts.ToString(@"hh\:mm\:ss");
                            await Task.Delay(1000);
                        }

                        goto Login;
                    }
                    else
                    {
                        lblAccount.Text = LoginWax.ACCOUNT;
                        lblToken.Text = LoginWax.TOKEN;
                        lblMarkX.Visible = true;
                        this.Text = LoginWax.EMAIL;
                        SaveTextFile();
                        await Table_Row.GetNFTAccount();
                        await Table_Row.GetWalletAccount();
                        await Table_Row.GetConfigGame();
                        await Table_Row.GetBagAccountToLine();
                        bgTotal.RunWorkerAsync();
                        timer1.Start();
                        timeCPU.Start();
                        timerHr.Start();
                        StartBot();
                    }
                }




            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                Application.ExitThread();
            }
        }

        public async void StartBot()
        {

            for (int f = 0; f <= dgvList.Rows.Count - 1; f++)
            {

                BackgroundWorker worker = new BackgroundWorker();
                worker = new BackgroundWorker();
                worker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
                worker.WorkerSupportsCancellation = true;
                worker.RunWorkerAsync(f);
                lstWorker.Add(worker);
                await DelayStart();
            }

        }

        public async Task MineWork(int IndexRow)
        {

            while (true)
            {
                try
                {

                    var AssetId = dgvList.Rows[IndexRow].Cells["AssetID"].Value.ToString();

                    if (dgvList.Rows[IndexRow].Cells["TypeAsset"].Value.ToString() == "Tools")
                    {

                        var _RemainTools = dgvList.Rows[IndexRow].Cells["Action"].Value.ToString().Split('/');
                        var Current = Convert.ToInt32(_RemainTools[0].ToString());
                        var Max = Convert.ToInt32(_RemainTools[1].ToString());
                        await Tools1.REPAIRTOOLS(IndexRow, Convert.ToInt32(txtRepair.Value), Current, Max, AssetId);

                        await Table_Row.GetNexToolstMine(IndexRow, AssetId);

                        await DelayTime(Convert.ToInt32(dgvList.Rows[IndexRow].Cells["NextTime"].Value.ToString()), IndexRow);

                        await Tools1.TransactionMine(IndexRow, AssetId);

                    }
                    else if (dgvList.Rows[IndexRow].Cells["TypeAsset"].Value.ToString() == "Member")
                    {
                        await Table_Row.GetNextMineMember(IndexRow, AssetId);

                        await DelayTime(Convert.ToInt32(dgvList.Rows[IndexRow].Cells["NextTime"].Value.ToString()), IndexRow);

                        await Membership.TransactionMineMember(IndexRow, AssetId);

                    }
                    else if (dgvList.Rows[IndexRow].Cells["TypeAsset"].Value.ToString() == "Animals")
                    {
                        await Table_Row.GetNextMineAnimals(IndexRow, AssetId);

                        await DelayTime(Convert.ToInt32(dgvList.Rows[IndexRow].Cells["NextTime"].Value.ToString()), IndexRow);

                        await Table_Row.GetCheckEatAnimal();

                        var sCurrentEnergy = lblEnergy.Text.Replace("Energy : ", "").ToString().Split('/');
                        var CurrentEnergy = Convert.ToInt32(sCurrentEnergy[0]);

                        if (CurrentEnergy > 250)
                        {
                            await animals.TransactionMineAnimals(IndexRow, AssetId);
                        }
                        else
                        {
                            dgvList.Rows[IndexRow].Cells["MsgGrid"].Value = "Energy not enough";
                        }


                    }

                    else if (dgvList.Rows[IndexRow].Cells["TypeAsset"].Value.ToString() == "Crops")
                    {

                        await Table_Row.GetNextMineCrops(IndexRow, AssetId);

                        await DelayTime(Convert.ToInt32(dgvList.Rows[IndexRow].Cells["NextTime"].Value.ToString()), IndexRow);

                        await Table_Row.GetCheckEatFarm(AssetId);

                        if (Globals.CropsClaim == false)
                        {
                            var sCurrentEnergy = lblEnergy.Text.Replace("Energy : ", "").ToString().Split('/');
                            var CurrentEnergy = Convert.ToInt32(sCurrentEnergy[0]);

                            if (CurrentEnergy > 250)
                            {
                                await crops.TransactionMineCrops(IndexRow, AssetId);
                            }
                            else
                            {
                                dgvList.Rows[IndexRow].Cells["MsgGrid"].Value = "Energy not enough";
                            }

                        }
                        else
                        {
                            dgvList.Rows[IndexRow].Cells["MsgGrid"].Value = "Wating Queue Crop Cliam";
                            await DelayTime(10, IndexRow);
                        }


                    }

                    else
                    {
                        await DelayTime(86400, IndexRow);
                    }

                    await Table_Row.GetWalletAccount();
                }
                catch (Exception)
                {


                }


            }

        }

        private async void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var rows = e.Argument;
            await MineWork((int)rows);
        }

        public async Task DelayTime(int Delay, int IndexRow)
        {

            TimeSpan ts = TimeSpan.FromSeconds(Delay);


            if (Delay <= 2)
            {
                for (int i = Delay; i >= 0; i--)
                {
                    ts = ts.Subtract(TimeSpan.FromSeconds(1));
                    dgvList.Rows[IndexRow].Cells["NextTime"].Value = ts.ToString(@"hh\:mm\:ss");
                    await Task.Delay(1000);
                }
            }
            else
            {
                dgvList.Rows[IndexRow].Cells["NextTime"].Value = "Waiting : " + ts.ToString(@"hh\:mm\:ss") + " s."; ;
                for (int i = Delay; i >= 0; i--)
                {
                    ts = ts.Subtract(TimeSpan.FromSeconds(1));
                    dgvList.Rows[IndexRow].Cells["NextTime"].Value = ts.ToString(@"hh\:mm\:ss");
                    await Task.Delay(1000);
                }

            }


        }

        private async Task DelayStart()
        {

            for (int i = 1; i >= 0; i--)
            {
                await Task.Delay(1000);
            }
        }

        public void SaveTextFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            try
            {

                string dirLocationString = Globals.PATH_FILE;

                StreamWriter sW = new StreamWriter(dirLocationString);

                var linetxt = "Email=" + LoginWax.EMAIL;
                sW.WriteLine(linetxt);
                linetxt = "Password=" + LoginWax.PASSWORD;
                sW.WriteLine(linetxt);
                linetxt = "2FA=" + LoginWax.FAC_PASSWORD;
                sW.WriteLine(linetxt);
                linetxt = "TOKEN=" + LoginWax.TOKEN;
                sW.WriteLine(linetxt);
                linetxt = "ACCOUNT=" + LoginWax.ACCOUNT;
                sW.WriteLine(linetxt);
                if (cbGold.Checked)
                {
                    linetxt = "BUYGOLD=1";
                    sW.WriteLine(linetxt);
                }
                else
                {
                    linetxt = "BUYGOLD=0";
                    sW.WriteLine(linetxt);
                }

                if (cbFood.Checked)
                {
                    linetxt = "BUYFOOD=1";
                    sW.WriteLine(linetxt);
                }
                else
                {
                    linetxt = "BUYFOOD=0";
                    sW.WriteLine(linetxt);
                }

                linetxt = "LESSGOLD=" + txtBuyGold.Text;
                sW.WriteLine(linetxt);
                linetxt = "LESSFOOD=" + txtBuyFood.Text;
                sW.WriteLine(linetxt);
                linetxt = "REPAIR=" + txtRepair.Text;
                sW.WriteLine(linetxt);
                linetxt = "WAXGOLD=" + txtWGold.Text;
                sW.WriteLine(linetxt);
                linetxt = "WAXFOOD=" + txtWFood.Text;
                sW.WriteLine(linetxt);
                linetxt = "LINETOKEN=" + Globals.TOKEN_LINE;
                sW.WriteLine(linetxt);

                sW.Close();
                lblMsg.Text = "SaveTextFile Successfully!";

            }
            catch (Exception ex)
            {


            }

        }

        private void LineNotifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLine formLine = new FormLine();
            formLine.ShowDialog();
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvList.Columns[e.ColumnIndex].HeaderText == "Config")
            {
                Globals.TOKEN_ID = dgvList.Rows[e.RowIndex].Cells[8].Value == null ? string.Empty : dgvList.Rows[e.RowIndex].Cells[8].Value.ToString();
                Globals.ACCOUNT_ID = dgvList.Rows[e.RowIndex].Cells["NextTime"].Value == null ? string.Empty : dgvList.Rows[e.RowIndex].Cells["NextTime"].Value.ToString();
                FormConfig formConfig = new FormConfig();
                formConfig.ShowDialog();
            }
        }

        private void bgClose_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void bgTotal_DoWork(object sender, DoWorkEventArgs e)
        {
            await Table_Row.GetCheckEatFood(Convert.ToInt32(txtEnergyFood.Value));
            var Chkbuy = false;
            if (cbGold.Checked)
            {
                var sGold = Math.Floor(Convert.ToDouble(lblGold.Text.Replace("GOLD : ", "").ToString().Trim()));
                var sWax = Math.Floor(Convert.ToDouble(lblWAX.Text.Replace("WAX : ", "").ToString().Trim()));
                if (sGold <= Convert.ToInt32(txtBuyGold.Text) && sWax >= Convert.ToInt32(txtWGold.Text))
                {
                    await exchange.BuyGold(txtWGold.Text);
                    Chkbuy = true;
                    await Table_Row.GetConfigGame();
                    await Task.Delay(5000);
                    await deposit.DepositGold();
                }

            }

            if (cbFood.Checked)
            {
                var sFood = Math.Floor(Convert.ToDouble(lblFood.Text.Replace("FOOD : ", "").ToString().Trim()));
                var sWax = Math.Floor(Convert.ToDouble(lblWAX.Text.Replace("WAX : ", "").ToString().Trim()));

                if (sFood <= Convert.ToInt32(txtBuyFood.Text) && sWax >= Convert.ToInt32(txtWFood.Text))
                {
                    await exchange.BuyFood(txtWFood.Text);
                    Chkbuy = true;
                    await Table_Row.GetConfigGame();
                    await Task.Delay(5000);
                    await deposit.DepositFood();

                }
            }

            if (Chkbuy)
            {
                await Table_Row.GetConfigGame();
                await Table_Row.GetCheckEatFood(Convert.ToInt32(txtEnergyFood.Value));
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bgTotal.RunWorkerAsync();
        }

        private void TimeCPU_Tick(object sender, EventArgs e)
        {
            bgCPU.RunWorkerAsync();
        }

        private async void BgCPU_DoWork(object sender, DoWorkEventArgs e)
        {
            await Table_Row.GetConfigGame();
        }

        private async void BtnWithdraw_Click(object sender, EventArgs e)
        {
            await withdraw.WithdrawWOOD(lblWood.Text);
            await Table_Row.GetConfigGame();
            await Table_Row.GetCheckEatFood(Convert.ToInt32(txtEnergyFood.Value));
        }

        private void InputAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransfer formTransfer = new FormTransfer();
            formTransfer.ShowDialog();
            userTransferToolStripMenuItem.Text = Globals.ACCOUNT_TRANSFER;

        }

        private void TransferWaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bgTransfer.RunWorkerAsync();
        }

        private void UserTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void BgTransfer_DoWork(object sender, DoWorkEventArgs e)
        {
            await transferWallet.TransferWAX();
            await Table_Row.GetConfigGame();
            await Table_Row.GetCheckEatFood(Convert.ToInt32(txtEnergyFood.Value));
        }

        private void ConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.ACCOUNT_ID = lblAccount.Text;
            Globals.TOKEN_ID = lblToken.Text;
            FormConfig formConfig = new FormConfig();
            formConfig.ShowDialog();

        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            bgSell.RunWorkerAsync();
        }

        private async void BgSell_DoWork(object sender, DoWorkEventArgs e)
        {
            await exchange.SellWOOD();
            await Table_Row.GetConfigGame();
            await Table_Row.GetCheckEatFood(Convert.ToInt32(txtEnergyFood.Value));
        }

        private void DepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bgDeposit.RunWorkerAsync();
        }

        private async void BgDeposit_DoWork(object sender, DoWorkEventArgs e)
        {
            await Table_Row.GetConfigGame();
            await Table_Row.GetCheckEatFood(Convert.ToInt32(txtEnergyFood.Value));
        }

        private async void BgHr_DoWork(object sender, DoWorkEventArgs e)
        {
            await Table_Row.GetBagAccountToLine();
        }

        private void TimerHr_Tick(object sender, EventArgs e)
        {
            bgHr.RunWorkerAsync();
        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTextFile();
        }

        private void InputAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTransfer formTransfer = new FormTransfer();
            formTransfer.ShowDialog();


            userTransferToolStripMenuItem.Text = Globals.ACCOUNT_TRANSFER;
        }

        private void TransferTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bgTransferToken.RunWorkerAsync();
        }

        private async void BgTransferToken_DoWork(object sender, DoWorkEventArgs e)
        {
            await transferWallet.TransferToken();
        }

        private async void btnDepositWood_Click(object sender, EventArgs e)
        {
            await deposit.DepositWood();
            await Table_Row.GetConfigGame();
            await Table_Row.GetCheckEatFood(Convert.ToInt32(txtEnergyFood.Value));
        }

        private async void btnDepositFOOD_Click(object sender, EventArgs e)
        {
            await deposit.DepositFood();
            await Table_Row.GetConfigGame();
            await Table_Row.GetCheckEatFood(Convert.ToInt32(txtEnergyFood.Value));
        }

        private async void btnDepositGold_Click(object sender, EventArgs e)
        {
            await deposit.DepositGold();
            await Table_Row.GetConfigGame();
            await Table_Row.GetCheckEatFood(Convert.ToInt32(txtEnergyFood.Value));
        }

        private async void btnWithdrawFOOD_Click(object sender, EventArgs e)
        {
            await withdraw.WithdrawFOOD(lblFood.Text);
            await Table_Row.GetConfigGame();
            await Table_Row.GetCheckEatFood(Convert.ToInt32(txtEnergyFood.Value));
        }

        private async void btnWithdrawGOLD_Click(object sender, EventArgs e)
        {
            await withdraw.WithdrawGOLD(lblGold.Text);
            await Table_Row.GetConfigGame();
            await Table_Row.GetCheckEatFood(Convert.ToInt32(txtEnergyFood.Value));
        }

        public void Info(string msg, int IndexRow)
        {
            dgvList.Rows[IndexRow].Cells["MsgGrid"].Value = msg;
        }

        public void addGrid(string Column1, string Column2, string Column3, string Column4, string Column5, string Column6)
        {
            dgvList.Rows.Add(Column1, Column2, Column3, Column4, Column5, Column6);
        }

        public void UpdateGrid(string Column1, string Column2, string Column3, string Column4, string Column5, string Column6, int IndexRow)
        {
            if (Column1 != "")
            {
                dgvList.Rows[IndexRow].Cells["AssetID"].Value = Column1;
            }
            if (Column2 != "")
            {
                dgvList.Rows[IndexRow].Cells["ItemName"].Value = Column2;
            }
            if (Column3 != "")
            {
                dgvList.Rows[IndexRow].Cells["NextTime"].Value = Column3;
            }
            if (Column4 != "")
            {
                dgvList.Rows[IndexRow].Cells["Action"].Value = Column4;

            }
            if (Column5 != "")
            {
                dgvList.Rows[IndexRow].Cells["MsgGrid"].Value = Column5;
            }
            if (Column6 != "")
            {
                dgvList.Rows[IndexRow].Cells["TypeAsset"].Value = Column6;
            }


        }

        public void ConfigWallet(string Energy, string Gold, string Food, string Wood)
        {
            lblEnergy.Text = Energy;

            lblGold.Text = Gold;
            lblWood.Text = Wood;
            lblFood.Text = Food;
        }

        public void CPUWAXSTAKE(string CPU, string WAX, string Stake)
        {
            lblCPU.Text = CPU;
            lblWAX.Text = WAX;
            lblStake.Text = Stake;
        }

        public void TokenWallet(string Gold, string Food, string Wood)
        {
            lblTG.Text = Gold;
            lblTF.Text = Food;
            lblTW.Text = Wood;
        }

        public void Vat(string Fee)
        {
            lblFee.Text = Fee + " %";
        }

        public void Message(string Msg)
        {
            lblMsg.Text = Msg;
        }

        private async void bgCheckFee_DoWork(object sender, DoWorkEventArgs e)
        {
            var _Wood = lblWood.Text.Replace("WOOD : ", "").ToString();
            if (Convert.ToDecimal(_Wood) > txtCovertWOOD.Value)
            {
                if (txtCovertWOOD.Value > 0)
                {
                    await withdraw.WithdrawWOODFEE5(txtCovertWOOD.Value.ToString("0.0000"), "WOOD");
                }

            }

            var _Food = lblFood.Text.Replace("FOOD : ", "").ToString();
            if (Convert.ToDecimal(_Wood) > txtCovertFOOD.Value)
            {
                if (txtCovertFOOD.Value > 0)
                {
                    await withdraw.WithdrawWOODFEE5(txtCovertFOOD.Value.ToString("0.0000"), "FOOD");
                }

            }

            var _Gold = lblGold.Text.Replace("GOLD : ", "").ToString();
            if (Convert.ToDecimal(_Wood) > txtCovertGOLD.Value)
            {
                if (txtCovertGOLD.Value > 0)
                {
                    await withdraw.WithdrawWOODFEE5(txtCovertGOLD.Value.ToString("0.0000"), "GOLD");
                }

            }

        }

        private void TimerCheckFee_Tick(object sender, EventArgs e)
        {
            bgCheckFee.RunWorkerAsync();
        }
    }
}
