namespace CenterControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAccountUse = new System.Windows.Forms.Button();
            this.btnCleanUp = new System.Windows.Forms.Button();
            this.combAccount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiamond = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNotLogin = new System.Windows.Forms.Button();
            this.cbChoice = new System.Windows.Forms.CheckBox();
            this.btnTaoBao = new System.Windows.Forms.Button();
            this.txtTake2 = new System.Windows.Forms.TextBox();
            this.txtTake1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLevelTo = new System.Windows.Forms.TextBox();
            this.txtLevelFrom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbAccountNumber = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnAccountExport = new System.Windows.Forms.Button();
            this.btnAccountIn = new System.Windows.Forms.Button();
            this.dgvAccountDetails = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sChoice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Take = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.钻石 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 547);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRepeat);
            this.tabPage1.Controls.Add(this.txtServer);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnAccountUse);
            this.tabPage1.Controls.Add(this.btnCleanUp);
            this.tabPage1.Controls.Add(this.combAccount);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtDiamond);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnNotLogin);
            this.tabPage1.Controls.Add(this.cbChoice);
            this.tabPage1.Controls.Add(this.btnTaoBao);
            this.tabPage1.Controls.Add(this.txtTake2);
            this.tabPage1.Controls.Add(this.txtTake1);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtLevelTo);
            this.tabPage1.Controls.Add(this.txtLevelFrom);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnDel);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.lbAccountNumber);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.btnAccountExport);
            this.tabPage1.Controls.Add(this.btnAccountIn);
            this.tabPage1.Controls.Add(this.dgvAccountDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据统计";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.Location = new System.Drawing.Point(527, 424);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(75, 23);
            this.btnRepeat.TabIndex = 69;
            this.btnRepeat.Text = "去重复";
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(334, 419);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(82, 21);
            this.txtServer.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 67;
            this.label3.Text = "区服：";
            // 
            // btnAccountUse
            // 
            this.btnAccountUse.Location = new System.Drawing.Point(816, 479);
            this.btnAccountUse.Name = "btnAccountUse";
            this.btnAccountUse.Size = new System.Drawing.Size(75, 23);
            this.btnAccountUse.TabIndex = 66;
            this.btnAccountUse.Text = "账号上机";
            this.btnAccountUse.UseVisualStyleBackColor = true;
            this.btnAccountUse.Click += new System.EventHandler(this.btnAccountUse_Click);
            // 
            // btnCleanUp
            // 
            this.btnCleanUp.Location = new System.Drawing.Point(728, 479);
            this.btnCleanUp.Name = "btnCleanUp";
            this.btnCleanUp.Size = new System.Drawing.Size(75, 23);
            this.btnCleanUp.TabIndex = 65;
            this.btnCleanUp.Text = "账号下机";
            this.btnCleanUp.UseVisualStyleBackColor = true;
            this.btnCleanUp.Click += new System.EventHandler(this.btnCleanUp_Click);
            // 
            // combAccount
            // 
            this.combAccount.FormattingEnabled = true;
            this.combAccount.Location = new System.Drawing.Point(177, 419);
            this.combAccount.Name = "combAccount";
            this.combAccount.Size = new System.Drawing.Size(97, 20);
            this.combAccount.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 63;
            this.label2.Text = "账号类型：";
            // 
            // txtDiamond
            // 
            this.txtDiamond.Location = new System.Drawing.Point(439, 455);
            this.txtDiamond.Name = "txtDiamond";
            this.txtDiamond.Size = new System.Drawing.Size(73, 21);
            this.txtDiamond.TabIndex = 62;
            this.txtDiamond.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 61;
            this.label1.Text = "钻石大于：";
            // 
            // btnNotLogin
            // 
            this.btnNotLogin.Location = new System.Drawing.Point(646, 479);
            this.btnNotLogin.Name = "btnNotLogin";
            this.btnNotLogin.Size = new System.Drawing.Size(75, 23);
            this.btnNotLogin.TabIndex = 60;
            this.btnNotLogin.Text = "未登录";
            this.btnNotLogin.UseVisualStyleBackColor = true;
            this.btnNotLogin.Click += new System.EventHandler(this.btnNotLogin_Click);
            // 
            // cbChoice
            // 
            this.cbChoice.AutoSize = true;
            this.cbChoice.Location = new System.Drawing.Point(91, 26);
            this.cbChoice.Name = "cbChoice";
            this.cbChoice.Size = new System.Drawing.Size(15, 14);
            this.cbChoice.TabIndex = 59;
            this.cbChoice.UseVisualStyleBackColor = true;
            this.cbChoice.CheckedChanged += new System.EventHandler(this.cbChoice_CheckedChanged);
            // 
            // btnTaoBao
            // 
            this.btnTaoBao.Location = new System.Drawing.Point(891, 450);
            this.btnTaoBao.Name = "btnTaoBao";
            this.btnTaoBao.Size = new System.Drawing.Size(75, 23);
            this.btnTaoBao.TabIndex = 58;
            this.btnTaoBao.Text = "导淘宝";
            this.btnTaoBao.UseVisualStyleBackColor = true;
            this.btnTaoBao.Click += new System.EventHandler(this.btnTaoBao_Click);
            // 
            // txtTake2
            // 
            this.txtTake2.Location = new System.Drawing.Point(202, 453);
            this.txtTake2.Name = "txtTake2";
            this.txtTake2.Size = new System.Drawing.Size(36, 21);
            this.txtTake2.TabIndex = 57;
            this.txtTake2.Text = "100";
            // 
            // txtTake1
            // 
            this.txtTake1.Location = new System.Drawing.Point(151, 453);
            this.txtTake1.Name = "txtTake1";
            this.txtTake1.Size = new System.Drawing.Size(36, 21);
            this.txtTake1.TabIndex = 56;
            this.txtTake1.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(189, 458);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 55;
            this.label14.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(114, 456);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 54;
            this.label13.Text = "单抽：";
            // 
            // txtLevelTo
            // 
            this.txtLevelTo.Location = new System.Drawing.Point(336, 454);
            this.txtLevelTo.Name = "txtLevelTo";
            this.txtLevelTo.Size = new System.Drawing.Size(36, 21);
            this.txtLevelTo.TabIndex = 52;
            this.txtLevelTo.Text = "100";
            // 
            // txtLevelFrom
            // 
            this.txtLevelFrom.Location = new System.Drawing.Point(283, 454);
            this.txtLevelFrom.Name = "txtLevelFrom";
            this.txtLevelFrom.Size = new System.Drawing.Size(36, 21);
            this.txtLevelFrom.TabIndex = 53;
            this.txtLevelFrom.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 459);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 50;
            this.label12.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(246, 458);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 51;
            this.label11.Text = "级别：";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(646, 450);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 49;
            this.btnDel.Text = "删除账号";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(527, 454);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbAccountNumber
            // 
            this.lbAccountNumber.AutoSize = true;
            this.lbAccountNumber.Location = new System.Drawing.Point(67, 456);
            this.lbAccountNumber.Name = "lbAccountNumber";
            this.lbAccountNumber.Size = new System.Drawing.Size(11, 12);
            this.lbAccountNumber.TabIndex = 46;
            this.lbAccountNumber.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 455);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 12);
            this.label25.TabIndex = 47;
            this.label25.Text = "账号数量：";
            // 
            // btnAccountExport
            // 
            this.btnAccountExport.Location = new System.Drawing.Point(807, 450);
            this.btnAccountExport.Name = "btnAccountExport";
            this.btnAccountExport.Size = new System.Drawing.Size(75, 23);
            this.btnAccountExport.TabIndex = 45;
            this.btnAccountExport.Text = "账号导出";
            this.btnAccountExport.UseVisualStyleBackColor = true;
            this.btnAccountExport.Click += new System.EventHandler(this.btnAccountExport_Click);
            // 
            // btnAccountIn
            // 
            this.btnAccountIn.Location = new System.Drawing.Point(727, 450);
            this.btnAccountIn.Name = "btnAccountIn";
            this.btnAccountIn.Size = new System.Drawing.Size(75, 23);
            this.btnAccountIn.TabIndex = 44;
            this.btnAccountIn.Text = "账号导入";
            this.btnAccountIn.UseVisualStyleBackColor = true;
            this.btnAccountIn.Click += new System.EventHandler(this.btnAccountIn_Click);
            // 
            // dgvAccountDetails
            // 
            this.dgvAccountDetails.AllowUserToAddRows = false;
            this.dgvAccountDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sChoice,
            this.Column5,
            this.cAccount,
            this.Pwd,
            this.State,
            this.Server,
            this.Level,
            this.Take,
            this.钻石,
            this.StartTime,
            this.IsLogin});
            this.dgvAccountDetails.Location = new System.Drawing.Point(5, 21);
            this.dgvAccountDetails.Name = "dgvAccountDetails";
            this.dgvAccountDetails.RowTemplate.Height = 23;
            this.dgvAccountDetails.Size = new System.Drawing.Size(981, 384);
            this.dgvAccountDetails.TabIndex = 31;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "账号管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sChoice
            // 
            this.sChoice.HeaderText = "全选";
            this.sChoice.Name = "sChoice";
            this.sChoice.Width = 60;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "AccountID";
            this.Column5.HeaderText = "序号";
            this.Column5.Name = "Column5";
            this.Column5.Width = 60;
            // 
            // cAccount
            // 
            this.cAccount.DataPropertyName = "Account";
            this.cAccount.HeaderText = "账号";
            this.cAccount.Name = "cAccount";
            // 
            // Pwd
            // 
            this.Pwd.DataPropertyName = "AccountPwd";
            this.Pwd.HeaderText = "密码";
            this.Pwd.Name = "Pwd";
            // 
            // State
            // 
            this.State.DataPropertyName = "GameState";
            this.State.HeaderText = "关卡";
            this.State.Name = "State";
            this.State.Width = 60;
            // 
            // Server
            // 
            this.Server.DataPropertyName = "Server";
            this.Server.HeaderText = "区服";
            this.Server.Name = "Server";
            // 
            // Level
            // 
            this.Level.DataPropertyName = "AccountLevel";
            this.Level.HeaderText = "级别";
            this.Level.Name = "Level";
            this.Level.Width = 60;
            // 
            // Take
            // 
            this.Take.DataPropertyName = "C2";
            this.Take.HeaderText = "单抽";
            this.Take.Name = "Take";
            this.Take.Width = 60;
            // 
            // 钻石
            // 
            this.钻石.DataPropertyName = "C1";
            this.钻石.HeaderText = "钻石";
            this.钻石.Name = "钻石";
            this.钻石.Width = 80;
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "LoginTime";
            this.StartTime.HeaderText = "登录时间";
            this.StartTime.Name = "StartTime";
            this.StartTime.Width = 180;
            // 
            // IsLogin
            // 
            this.IsLogin.DataPropertyName = "IsLogin";
            this.IsLogin.HeaderText = "登录";
            this.IsLogin.Name = "IsLogin";
            this.IsLogin.Width = 60;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 571);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "超进化物语中控V1.0.2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnTaoBao;
        private System.Windows.Forms.TextBox txtTake2;
        private System.Windows.Forms.TextBox txtTake1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtLevelTo;
        private System.Windows.Forms.TextBox txtLevelFrom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbAccountNumber;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnAccountExport;
        private System.Windows.Forms.Button btnAccountIn;
        private System.Windows.Forms.DataGridView dgvAccountDetails;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbChoice;
        private System.Windows.Forms.Button btnNotLogin;
        private System.Windows.Forms.TextBox txtDiamond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCleanUp;
        private System.Windows.Forms.Button btnAccountUse;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sChoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Server;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Take;
        private System.Windows.Forms.DataGridViewTextBoxColumn 钻石;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsLogin;
    }
}