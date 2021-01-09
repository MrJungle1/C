using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyQQ
{
    public partial class Frm_EditInfo : Form
    {
        public Frm_Main frmMain;//创建主窗体对象

        public Frm_EditInfo()
        {
            InitializeComponent();
        }
        DataOperator dataOper = new DataOperator();//创建数据操作类的对象

        /// <summary>
        /// 显示指定头像
        /// </summary>
        /// <param name="headID">头像ID</param>
        public void ShowHead(int headID)
        {
            pboxHead.Image = imglistHead.Images[headID];//显示头像
            pboxHead.Tag = headID;//设置Tag属性，在拼接更新SQL语句时使用
        }

        //窗体加载事件
        private void Frm_EditInfo_Load(object sender, EventArgs e)
        {
            int headID = 0;//头像ID
            int friendLimitID = 0;//好友安全限制ID
            //查询指定用户信息的SQL语句
            string sql = "select * from tb_User where ID=" + PublicClass.loginID + "";
            SqlDataReader datareader = dataOper.GetDataReader(sql);//执行查询操作
            if (datareader.Read())//将查出的数据显示在窗体上
            {
                txtID.Text = datareader["ID"].ToString();//账号
                txtNickName.Text = datareader["NickName"].ToString(); //昵称
                cboxSex.Text = datareader["Sex"].ToString(); //性别
                if (!(datareader["Name"] is DBNull))//判断真实姓名为不空
                {
                    txtName.Text = datareader["Name"].ToString();//真实姓名
                }
                txtAge.Text = datareader["Age"].ToString();//年龄
                txtOldPwd.Text = datareader["Pwd"].ToString();//密码
                if (!(datareader["Star"] is DBNull))
                {
                    cboxStar.Text = datareader["Star"].ToString();//星座
                }
                if (!(datareader["BloodType"] is DBNull))
                {
                    cboxBloodType.Text = datareader["BloodType"].ToString();//血型
                }
                headID = Convert.ToInt32(datareader["HeadID"])+1;//头像ID
                friendLimitID = Convert.ToInt32(datareader["FriendLimitID"]); //好友安全限制ID
            }
            DataOperator.connection.Close();//关闭数据库连接
            ShowHead(headID);//显示头像
            switch (friendLimitID)//好友安全限制条件
            {
                case 1:
                    rbtnAnybody.Checked = true;//允许任何人
                    break;
                case 2:
                    rbtnValidation.Checked = true;//需要身份验证
                    break;
                case 3:
                    rbtnNobody.Checked = true;//不允许任何人
                    break;
                default:
                    rbtnAnybody.Checked = true;//允许任何人
                    break;
            }
        }

        //选择头像
        private void btnShowHead_Click(object sender, EventArgs e)
        {
            Frm_Head frmHead = new Frm_Head();//创建头像窗体对象
            frmHead.frmEditInfo = this;//设置头像窗体中的个人信息窗体对象为当前窗体
            frmHead.Show();//显示头像窗体对象
        }

        ///<summary>
        ///验证用户输入
        ///</summary>
        ///<returns>bool类型，表示验证结果</returns>
        private bool ValidateInput()
        {
            if (txtNickName.Text.Trim() == "" || txtNickName.Text.Length > 20)//判断昵称是否为空
            {
                MessageBox.Show("昵称输入有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNickName.Focus();
                return false;
            }
            if (txtAge.Text.Trim() == "")//判断年龄是否为空
            {
                MessageBox.Show("请输入年龄！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAge.Focus();
                return false;
            }
            if (cboxSex.Text.Trim() == "")//判断性别是否为空
            {
                MessageBox.Show("请输入选择性别！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboxSex.Focus();
                return false;
            }
            if (txtNewPwd.Text.Trim() != txtNewPwdAgain.Text.Trim())  //两次输入的密码是否一致
            {
                MessageBox.Show("两次输入的密码不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPwdAgain.Focus();
                return false;
            }
            return true;
        }

        ///<summary>
        ///获得更新数据库的SQL语句
        ///</summary>
        ///<returns>更新个人信息的SQL语句</returns>
        private string GetUpdateSQL()
        {
            //更新用的sql语句，分成段拼凑
            string sql = string.Format("update tb_User set NickName='{0}', HeadID={1},Sex='{2}',Age={3}",
                txtNickName.Text.Trim(), Convert.ToInt32(pboxHead.Tag)-1, cboxSex.Text, Convert.ToInt32(txtAge.Text.Trim()));
            if (txtNewPwd.Text.Trim() != "")//判断是否修改了密码
            {
                sql = string.Format("{0} ,Pwd='{1}',Remember=0,AutoLogin=0 ", sql, txtNewPwd.Text.Trim());
            }
            //设置好友安全限制
            int friendLimitID = 0;
            if (rbtnAnybody.Checked)//允许任何人
            {
                friendLimitID = Convert.ToInt32(rbtnAnybody.Tag);
            }
            else if (rbtnValidation.Checked)//需要身份验证
            {
                friendLimitID = Convert.ToInt32(rbtnValidation.Tag);
            }
            else if (rbtnNobody.Checked)//不允许任何人
            {
                friendLimitID = Convert.ToInt32(rbtnNobody.Tag);
            }
            //拼接更新个人信息的SQL语句
            sql = string.Format("{0},FriendLimitID={1},Name='{2}',Star='{3}',BloodType='{4}' where ID={5}",
                sql, friendLimitID, txtName.Text.Trim(), cboxStar.Text, cboxBloodType.Text, PublicClass.loginID);
            return sql;
        }

        //确定按钮，更新数据库
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateInput())//调用自定义方法进行输入验证
            {
                string sql = GetUpdateSQL();//获取更新SQL语句 
                int result = dataOper.ExecSQLResult(sql);//执行更新操作
                if (result == 1)//根据返回值判断执行是否成功
                {
                    MessageBox.Show("数据保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("数据保存失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                frmMain.ShowInfo();//更新主窗体中的个人信息
                this.Close(); //关闭窗体
            }
        }

        //关闭窗体
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }

        private void txtNickName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}