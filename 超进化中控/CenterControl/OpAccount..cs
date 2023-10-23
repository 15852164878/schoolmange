using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterControl
{
    public class Account
    {
        //public void SetAccountDetails(string account, string pwd, string state, string server, string level, string team)
        //{
        //    string sql = $"INSERT INTO AccountDetails ([Account],[Pwd],[State],[Server],[Level],[Team],[Take]) values ('{account}','{pwd}','{state}','{server}','{level}','{team}',0)";
        //    SqlHelp.ExecuteSql(sql);
        //}

        public void SetAccountDetails(string account, string pwd, string state, string server, int level, int take, string team = "0", string isLogin = "0", int diamond = 0)//SetAccountDetails
        {
            string sql = $"INSERT INTO AccountDetails ([Account],[AccountPwd],[GameState],[Server],[AccountLevel],[C2],[F1],[IsLogin],[C1]) values ('{account}','{pwd}','{state}','{server}',{level},{take},'{team}','{isLogin}',{diamond})";
            SqlHelp.ExecuteSql(sql);
        }

        public bool isExistAccount(string account)
        {
            string sql = "SELECT [AccountID] FROM AccountDetails WHERE Account = '" + account + "'";
            return SqlHelp.Exists(sql);
        }

        public int DelAccountInitialByAccount(string account)
        {
            string mySql = "DELETE FROM AccountDetails WHERE [Account]='" + account + "'";
            return SqlHelp.ExecuteSql(mySql);
        }

        public DataTable GetAccountDetails(int leveFrom, int levelTo, int takeFrom, int takeTo,int diamond,string accountType,string server)
        {
            string mySql = "";
            if (accountType == "全部账号")
            {
                mySql = "SELECT * FROM AccountDetails WHERE 1=1 ";
            }
            else
            {
                mySql = $"SELECT * FROM AccountDetails WHERE [Field1]='{accountType}' ";
            }
            mySql += $" AND [C1] >={diamond} AND ([AccountLevel]>={leveFrom} AND [AccountLevel]<={levelTo}) AND ([C2]>={takeFrom} AND [C2]<={takeTo})";

            if (!string.IsNullOrEmpty(server))
            {
                mySql += $" AND [Server]='{server}'";
            }

            return SqlHelp.Query(mySql).Tables[0];
        }

        public int DelAccountInitial(string accounts)
        {
            string mySql = "DELETE FROM AccountDetails WHERE [Account] IN (" + accounts + ")";
            return SqlHelp.ExecuteSql(mySql);
        }

        public int SetAccountNotLogin(string accounts)
        {
            string mySql = "UPDATE AccountDetails SET IsLogin = 0 WHERE [Account] IN (" + accounts + ")";
            return SqlHelp.ExecuteSql(mySql);
        }

        public int AccountCleanup(string accounts)
        {
            string mySql = "UPDATE AccountDetails SET [F2]='下机号' WHERE [Account] IN (" + accounts + ")";
            return SqlHelp.ExecuteSql(mySql);
        }
        public int AccountUse(string accounts)
        {
            string mySql = "UPDATE AccountDetails SET [F2]='正用号' WHERE [Account] IN (" + accounts + ")";
            return SqlHelp.ExecuteSql(mySql);
        }
    }
}
