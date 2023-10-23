using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenterControl
{
    public partial class MainForm : Form
    {
        Account a = new Account();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            combAccount.Items.Insert(0, "全部账号");
            combAccount.Items.Insert(1, "正用号");
            combAccount.Items.Insert(2, "下机号");
            combAccount.SelectedIndex = combAccount.Items.IndexOf("全部账号");
        }


        private void btnAccountIn_Click(object sender, EventArgs e)
        {
            int num = 0;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "文本文档|*.txt";
            ofd.RestoreDirectory = true;
            //如果用户没有选择文件并确定则直接返回
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = ofd.FileName;
            
            //删除所有账号
            //a.DelTableAccountDetails();
            //a.SetTableStructure();

            using (StreamReader sr = new StreamReader(fileName, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string readStr = sr.ReadLine();//读取一行数据
                    if (readStr.Contains("----"))
                    {
                        string[] ss = Regex.Split(readStr, "----", RegexOptions.IgnoreCase);
                        string account = ss[0].ToString();
                        string pwd = ss[1].ToString();
                        string state = ss[2].ToString();
                        string server = ss[3].ToString();
                        string level = ss[4].ToString();
                        string take = ss[5].ToString();

                        int iLevel = 0;
                        int iTake = 0;

                        try
                        {
                            iLevel = Convert.ToInt16(level);
                            iTake = Convert.ToInt16(take);
                        }
                        finally
                        { }

                        if (!a.isExistAccount(account))
                        {
                            a.SetAccountDetails(account, pwd, state, server, iLevel, iTake);
                            num++;
                        }
                    }
                }
                MessageBox.Show($"账号导入 {num} 个成功！");
            }
            BindData();
        }

        private void BindData()
        {

            string takeFrom = txtTake1.Text.Trim();
            string takeTo = txtTake2.Text.Trim();
            string levelFrom = txtLevelFrom.Text.Trim();
            string levelTo = txtLevelTo.Text.Trim();
            string diamond = txtDiamond.Text.Trim();
            string accountType = combAccount.SelectedItem.ToString();
            string server = txtServer.Text.Trim();

            int iLevelFrom = 1;
            int iLevelTo = 100;
            int iTakeFrom = 10;
            int iTakeTo = 100;
            int iDiamond = 0;
            try
            {
                iLevelFrom = Convert.ToInt16(levelFrom);
                iLevelTo = Convert.ToInt16(levelTo);
                iTakeFrom = Convert.ToInt16(takeFrom);
                iTakeTo = Convert.ToInt16(takeTo);
                iDiamond = Convert.ToInt16(diamond);
            }
            catch { }

            dgvAccountDetails.AutoGenerateColumns = false;
            DataTable dt = a.GetAccountDetails(iLevelFrom, iLevelTo, iTakeFrom, iTakeTo, iDiamond, accountType,server);
            dgvAccountDetails.DataSource = dt;
            lbAccountNumber.Text = dt.Rows.Count.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindData();
        }


        private void txtSj1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAbort_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountExport_Click(object sender, EventArgs e)
        {
            int exportNum = 0;
            for (int i = 0; i < dgvAccountDetails.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvAccountDetails.Rows[i].Cells["sChoice"].Value))
                    exportNum++;
            }
            if (exportNum == 0)
            {
                MessageBox.Show("没有选中需要导出的账号！");
                return;
            }

            int num = 0;
            SaveFileDialog saveDlg = new SaveFileDialog();
            string path = string.Empty;  //文件路径
            saveDlg.Filter = "文本文件|*.txt";
            saveDlg.FileName = "账号信息";
            path = saveDlg.FileName;
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Open(saveDlg.FileName, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        List<string> accounts = new List<string>();
                        //List<string> machineNums = new List<string>();
                        for (int i = 0; i < dgvAccountDetails.Rows.Count; i++)
                        {
                            StringBuilder sbTemp = new StringBuilder();
                            if (Convert.ToBoolean(dgvAccountDetails.Rows[i].Cells["sChoice"].Value))
                            {
                                sbTemp.Append(dgvAccountDetails.Rows[i].Cells[2].Value.ToString() + "----");
                                sbTemp.Append(dgvAccountDetails.Rows[i].Cells[3].Value.ToString() + "----");
                                sbTemp.Append(dgvAccountDetails.Rows[i].Cells[4].Value.ToString() + "----");
                                sbTemp.Append(dgvAccountDetails.Rows[i].Cells[5].Value.ToString() + "----");
                                sbTemp.Append(dgvAccountDetails.Rows[i].Cells[6].Value.ToString() + "----");
                                sbTemp.Append(dgvAccountDetails.Rows[i].Cells[7].Value.ToString());
                            }
                            if (sbTemp.Length > 0)
                            {
                                sw.WriteLine(sbTemp.ToString());
                                sw.Write("\r\n");
                                num++;
                            }
                        }
                        MessageBox.Show($"账号导出 {num} 个成功！");
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"确定删除所选账号吗?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvAccountDetails.AutoGenerateColumns = false;
                StringBuilder sbAccount = new StringBuilder();
                for (int i = 0; i < dgvAccountDetails.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvAccountDetails.Rows[i].Cells["sChoice"].Value))
                        sbAccount.Append("'" + dgvAccountDetails.Rows[i].Cells["cAccount"].Value.ToString() + "',");
                }

                if (sbAccount.Length > 0)
                {
                    string accountss = sbAccount.ToString().TrimEnd(',');
                    if (a.DelAccountInitial(accountss) > 0)
                    {
                        MessageBox.Show("所选账号删除成功！");
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("所选账号删除失败！");
                    }
                }
                else
                { MessageBox.Show("没有账号被选中！"); }
            }
        }

        private void btnTaoBao_Click(object sender, EventArgs e)
        {
            int exportNum = 0;
            for (int i = 0; i < dgvAccountDetails.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvAccountDetails.Rows[i].Cells["sChoice"].Value))
                    exportNum++;
            }
            if (exportNum == 0)
            {
                MessageBox.Show("没有选中需要导出的账号！");
                return;
            }

            int num = 0;
            SaveFileDialog saveDlg = new SaveFileDialog();
            string path = string.Empty;  //文件路径
            saveDlg.Filter = "文本文件|*.txt";
            saveDlg.FileName = "账号信息";
            path = saveDlg.FileName;
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.Open(saveDlg.FileName, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        List<string> accounts = new List<string>();
                        //List<string> machineNums = new List<string>();
                        for (int i = 0; i < dgvAccountDetails.Rows.Count; i++)
                        {
                            StringBuilder sbTemp = new StringBuilder();
                            if (Convert.ToBoolean(dgvAccountDetails.Rows[i].Cells["sChoice"].Value))
                            {
                                sbTemp.Append(dgvAccountDetails.Rows[i].Cells[2].Value.ToString() + ",");
                                sbTemp.Append(dgvAccountDetails.Rows[i].Cells[3].Value.ToString() + "  ");
                                sbTemp.Append("区服:" + dgvAccountDetails.Rows[i].Cells[5].Value.ToString());
                            }
                            if (sbTemp.Length > 0)
                            {
                                sw.WriteLine(sbTemp.ToString());
                                //sw.Write("\r\n");
                                num++;
                            }
                        }
                        MessageBox.Show($"账号导出 {num} 个成功！");
                    }
                }
            }
        }

        private void cbChoice_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbChoice.Checked == true)
            {
                for (int i = 0; i < this.dgvAccountDetails.Rows.Count; i++)
                {
                    this.dgvAccountDetails.Rows[i].Cells["sChoice"].Value = true;
                }
            }

            else
            {
                for (int i = 0; i < dgvAccountDetails.Rows.Count; i++)
                {
                    this.dgvAccountDetails.Rows[i].Cells["sChoice"].Value = false;
                }
            }
        }

        private void btnNotLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"确定更新账号为未登录吗?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvAccountDetails.AutoGenerateColumns = false;
                StringBuilder sbAccount = new StringBuilder();
                for (int i = 0; i < dgvAccountDetails.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvAccountDetails.Rows[i].Cells["sChoice"].Value))
                        sbAccount.Append("'" + dgvAccountDetails.Rows[i].Cells["cAccount"].Value.ToString() + "',");
                }

                if (sbAccount.Length > 0)
                {
                    string accountss = sbAccount.ToString().TrimEnd(',');
                    if (a.SetAccountNotLogin(accountss) > 0)
                    {
                        MessageBox.Show("所选账号更新为未登录成功！");
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("所选账号更新为未登录失败！");
                    }
                }
                else
                { MessageBox.Show("没有账号被选中！"); }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnCleanUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"确定所选账号下机吗?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvAccountDetails.AutoGenerateColumns = false;
                StringBuilder sbAccount = new StringBuilder();
                for (int i = 0; i < dgvAccountDetails.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvAccountDetails.Rows[i].Cells["sChoice"].Value))
                        sbAccount.Append("'" + dgvAccountDetails.Rows[i].Cells["cAccount"].Value.ToString() + "',");
                }

                if (sbAccount.Length > 0)
                {
                    string accountss = sbAccount.ToString().TrimEnd(',');
                    if (a.AccountCleanup(accountss) > 0)
                    {
                        MessageBox.Show("所选账号下机成功！");
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("所选账号下机失败！");
                    }
                }
                else
                { MessageBox.Show("没有账号被选中！"); }
            }
        }

        private void btnAccountUse_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"确定所选账号上机吗?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvAccountDetails.AutoGenerateColumns = false;
                StringBuilder sbAccount = new StringBuilder();
                for (int i = 0; i < dgvAccountDetails.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvAccountDetails.Rows[i].Cells["sChoice"].Value))
                        sbAccount.Append("'" + dgvAccountDetails.Rows[i].Cells["cAccount"].Value.ToString() + "',");
                }

                if (sbAccount.Length > 0)
                {
                    string accountss = sbAccount.ToString().TrimEnd(',');
                    if (a.AccountUse(accountss) > 0)
                    {
                        MessageBox.Show("所选账号上机成功！");
                        BindData();
                    }
                    else
                    {
                        MessageBox.Show("所选账号上机失败！");
                    }
                }
                else
                { MessageBox.Show("没有账号被选中！"); }
            }
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "文本文档|*.txt";
            ofd.RestoreDirectory = true;

            //如果用户没有选择文件并确定则直接返回
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string fileName = ofd.FileName;
            //OpAccount op = new OpAccount();
            using (StreamReader sr = new StreamReader(fileName, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    string readStr = sr.ReadLine();//读取一行数据
                    if (readStr.Contains("----"))
                    {
                        string[] ss = Regex.Split(readStr, "----", RegexOptions.IgnoreCase);
                        string account = ss[0].ToString();
                        string pwd = ss[1].ToString();
                        if (a.isExistAccount(account))
                        {
                            using (FileStream fs = File.Open(@"d:\CjhRepeatAccount.txt", FileMode.Append, FileAccess.Write))
                            {
                                using (StreamWriter sw = new StreamWriter(fs))
                                {
                                    sw.WriteLine(account + "----" + pwd);
                                }
                            }
                            a.DelAccountInitialByAccount(account);
                        }
                    }
                }
            }

            MessageBox.Show("查重复完成！");
        }
    }
}
