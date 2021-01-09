using System;
using System.Data;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        
        DataOperator dataOper = new DataOperator();//创建数据操作类的对象

        //注册账号
        private void linklblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Register frmRegister = new Frm_Register();//创建申请账号窗体对象
            frmRegister.Show();//显示申请账号窗体
        }

        /// <summary>
        /// 验证用户输入
        /// </summary>
        /// <returns>验证成功，返回true，否则返回false</returns>
        private bool ValidateInput()
        {
            if (txtID.Text.Trim() == "")//登录账号
            {
                MessageBox.Show("请输入登录账号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();//使登录账号文本框获得鼠标焦点
                return false;
            }
            else if(int.Parse(txtID.Text.Trim())>65535)
            {
                MessageBox.Show("请输入正确的登录账号", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();//使登录账号文本框获得鼠标焦点
                return false;
            }
            else if (txtID.Text.Length>5 && txtPwd.Text.Trim() == "") //密码
            {
                MessageBox.Show("请输入密码", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();//使密码文本框获得鼠标焦点
                return false;
            }
            return true;
        }

        //是否忘记密码或者自动登录
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
            //根据号码查询其密码、记住密码和自动登录字段的值
            string sql = "select Pwd,Remember,AutoLogin from tb_User where ID=" + int.Parse(txtID.Text.Trim()) + "";
            DataSet ds = dataOper.GetDataSet(sql);//查询结果存储到数据集中
            if (ds.Tables[0].Rows.Count > 0)  //判断是否存在该用户
            {
                if (Convert.ToInt32(ds.Tables[0].Rows[0][1]) == 1)//判断是否记住密码
                {
                    cboxRemember.Checked = true;//记录密码复选框选中
                    txtPwd.Text = ds.Tables[0].Rows[0][0].ToString();//自动输入密码
                    if (Convert.ToInt32(ds.Tables[0].Rows[0][2]) == 1)//判断是否自动登录
                    {
                        cboxAutoLogin.Checked = true;//自动登录复选框选中
                        pboxLogin_Click(sender, e);//自动登录
                    }
                }
            }
        }

        //判断是否在用户账号文本框中按下回车键
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == '\r') || (e.KeyChar == '\b'))//判断是否为数字
                e.Handled = false;//在控件中显示该字符
            else
                e.Handled = true;//取消在控件中显示该字符
        }

        //判断是否在密码文本框中按下回车键
        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')//判断是否按下回车键
                pboxLogin_Click(sender, e);//使登录按钮获得鼠标焦点
        }

        //在记住密码的前提下才可以自动登录
        private void cboxRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (!cboxRemember.Checked)//判断忘记密码文本框是否为未选中状态
                cboxAutoLogin.Checked = false;//自动登录设置为未选中
        }

        //登录按钮
        private void pboxLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput()) //调用自定义方法验证用户输入
            {
                //定义查询SQL语句
                string sql = "select count(*) from tb_User where ID=" + int.Parse(txtID.Text.Trim()) + " and Pwd = '" + txtPwd.Text.Trim() + "'";
                int num = dataOper.ExecSQL(sql);
                if (num == 1)//验证通过
                {
                    PublicClass.loginID = int.Parse(txtID.Text.Trim());//设置登录的用户号码
                    if (cboxRemember.Checked)
                    {
                        //记住密码
                        dataOper.ExecSQLResult("update tb_User set Remember=1 where ID=" + int.Parse(txtID.Text.Trim()));
                        if (cboxAutoLogin.Checked)
                            //自动登录
                            dataOper.ExecSQLResult("update tb_User set AutoLogin=1 where ID=" + int.Parse(txtID.Text.Trim()));
                    }
                    else
                    {
                        dataOper.ExecSQLResult("update tb_User set Remember=0 where ID=" + int.Parse(txtID.Text.Trim()));
                        dataOper.ExecSQLResult("update tb_User set AutoLogin=0 where ID=" + int.Parse(txtID.Text.Trim()));
                    }
                    dataOper.ExecSQLResult("update tb_User set Flag=1 where ID=" + int.Parse(txtID.Text.Trim()));//设置在线状态
                    Frm_Main frmMain = new Frm_Main();//创建主窗体对象
                    frmMain.Show();  //显示主窗体
                    this.Visible = false;  //隐藏登录主窗体
                }
                else
                {
                    MessageBox.Show("输入的用户名或密码有误！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //最小化窗体
        private void pboxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//设置窗体最小化
        }

        //退出程序
        private void pboxClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();//退出当前应用程序
        }

        //拖动窗体
        private void Frm_Login_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture();//用来释放被当前线程中某个窗口捕获的光标
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);//向Windows发送拖动窗体的消息
        }
    }
}
