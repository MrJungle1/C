using System;
using System.Data;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_AddFriend : Form
    {
        public Frm_AddFriend()
        {
            InitializeComponent();
        }
        DataOperator dataOper = new DataOperator();//创建数据操作类的对象
        private DataSet ds;//数据集对象

        //窗体加载事件
        private void Frm_AddFriend_Load(object sender, EventArgs e)
        {
            //获取并显示所有用户(除掉自己)
            string sql = "select ID, NickName, Age, Sex from tb_User where ID <> "+ PublicClass.loginID;
            ds = dataOper.GetDataSet(sql);
            //指定DataGridView的数据源
            dgvBasicResult.DataSource = ds.Tables[0];
            dgvAdvancedResult.DataSource = ds.Tables[0];
        }

        ///<summary>
        ///基本查找
        ///</summary>
        private void BasicSearch()
        {
            //查询语句的前半部分
            string sql = "select ID,NickName,Age,Sex from tb_User";
            //精确查找
            if (rbtnDetailSearch.Checked == true)
            {
                if (txtLoginId.Text.Trim() == "" && txtNickName.Text.Trim() == "")
                {
                    MessageBox.Show("请输入查询条件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //按帐号查找
                else if (txtLoginId.Text.Trim() != "")
                {
                    sql += string.Format(" where ID={0}", int.Parse(txtLoginId.Text.Trim()));
                }
                //按昵称查找
                else
                {
                    sql += string.Format(" where NickName like '%{0}%'", txtNickName.Text.Trim());
                }
            }
            dgvBasicResult.DataSource = dataOper.GetDataSet(sql).Tables[0];//填充DataSet
            //设置控件可见的属性
            //调整显示结果的Panel的位置，让其和显示条件的Panel的位置相同
            pnlBaseResult.Location = pnlBaseCondition.Location;
            pnlBaseResult.Visible = true;//使显示结果的Panel可见
            btnAdd.Visible = true;　　//“加为好友”按钮可见
            btnBack.Visible = true;   //“上一步”按钮可见
        }

        ///<summary>
        ///高级查找
        ///</summary>
        private void AdvancedSearch()
        {
            string sql = "select ID,NickName,Age,Sex from tb_User";//查询语句的前半部分
            string strAge = "";  //年龄条件
            string strSex = cboxSex.Text;  //性别条件
            switch (cboxAge.SelectedIndex)//确定年龄的范围
            {
                case 1:
                    strAge = " Age>=0 and Age<10";
                    break;
                case 2:
                    strAge = " Age>=10 and Age<20";
                    break;
                case 3:
                    strAge = " Age>=20 and Age<30";
                    break;
                case 4:
                    strAge = " Age>=30 and Age<40";
                    break;
                case 5:
                    strAge = " Age>=40 and Age<50";
                    break;
                case 6:
                    strAge = " Age>=50";
                    break;
                default:
                    strAge = "";
                    break;
            }
            if (strAge == "" && strSex == "")//判断是否选中了查询条件
            {
                MessageBox.Show("还没有选择查询条件呢！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else//组合查询条件
            {
                if (strAge != "" && strSex == "")
                {
                    sql += " where "+strAge;
                }
                else if (strAge == "" && strSex != "")
                {
                    sql += " where Sex='"+ strSex + "'";
                }
                else
                {
                    sql += string.Format(" where "+ strAge + " and Sex='" + strSex + "'");
                }
            }

            dgvAdvancedResult.DataSource = dataOper.GetDataSet(sql).Tables[0];//填充DataSet
            //设置控件的属性
            pnlAdvancedResult.Location = pnlAdvancedCondition.Location;
            pnlAdvancedResult.Visible = true;
            btnAdd.Visible = true;
            btnBack.Visible = true;
        }

        //查找按钮
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tabSearch.SelectedIndex == 0) //基本查找选显卡选中
            {
                BasicSearch();//基本查找
            }
            else  //高级查找选项卡选中
            {
                AdvancedSearch();//高级查找
            }
        }

        ///<summary>
        ///获得选中好友的ID
        ///</summary>        
        private int GetSelectedFriendID()
        {
            int friendID = -1;  //记录好友的号码
            if (tabSearch.SelectedIndex == 0)//基本查找
            {
                if (dgvBasicResult.SelectedRows.Count == 0)//没有选中任何一行
                {
                    MessageBox.Show("请选择一个好友！", "操作", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dgvBasicResult.SelectedRows[0].Cells[0] != null)//确保第一个单元格有值
                {
                    //获得DataGridView中选中的行的第一个单元格的值
                    friendID = int.Parse(dgvBasicResult.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            else if (tabSearch.SelectedIndex == 1)//高级查找
            {
                if (dgvAdvancedResult.SelectedRows.Count == 0)
                {
                    MessageBox.Show("请选择一个好友！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dgvAdvancedResult.SelectedRows[0].Cells[0] != null)
                {
                    friendID = int.Parse(dgvAdvancedResult.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            return friendID;//返回选中的好友ID
        }

        ///<summary>
        ///查找好友是否已被添加
        ///</summary>        
        private bool HasAdded(int friendID)
        {
            //定义SQL语句
            string sql = "select count(*) from tb_Friend where HostID=" + PublicClass.loginID + " and FriendID=" + friendID + "";
            int result = dataOper.ExecSQL(sql);//返回查询结果
            
            bool returnValue = result > 0 ? true : false;//判断好友是否已添加
            return returnValue;
        }

        //添加好友
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int friendID = GetSelectedFriendID();  //获得选中的好友的ID
            if (friendID == -1)//是否有可添加的好友
            {
                MessageBox.Show("请选择一个好友！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (HasAdded(friendID))  //判断好友是否已经被添加
            {
                MessageBox.Show("对方已经是您的好友，请重新选择！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //确认对方加为好友的安全限制
            string sql = "select FriendLimitID from tb_User where ID=" + friendID;
            int friendLimitID = dataOper.ExecSQL(sql);
            if (friendLimitID == 1) //允许任何人添加为好友
            {
                //执行添加操作
                sql = "insert into tb_Friend (HostID, FriendID) values (" + PublicClass.loginID + "," + friendID + ")";
                int result = dataOper.ExecSQLResult(sql); //操作结果
                if (result == 1)
                {
                    MessageBox.Show("添加成功，请刷新好友列表！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加失败，请稍候再试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (friendLimitID == 2) //需要身份验证
            {
                //发出添加好友请求
                sql = "insert into tb_Message (FromUserID, ToUserID, MessageTypeID, MessageState) values (" + PublicClass.loginID + "," + friendID + ",2,0)";
                int result = dataOper.ExecSQLResult(sql); //操作结果
                if (result == 1)
                {
                    MessageBox.Show("对方需要身份验证才可以被加为好友，已发出请求！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("添加失败，请稍候再试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (friendLimitID == 3) //不允许任何人添加
            {
                MessageBox.Show("对方不允许任何人加他为好友！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //隐藏与查找结果相关的控件
        private void tabSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlBaseResult.Visible = false;//隐藏基本查找容器
            pnlAdvancedResult.Visible = false;//隐藏高级查找容器
            btnAdd.Visible = false;//隐藏加为好友按钮
            btnBack.Visible = false;//隐藏上一步按钮
        }

        //精确查找单选按钮事件
        private void rbtnDetailSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDetailSearch.Checked == true)//如果精确查找单选按钮选中
            {
                gBaseCondition.Visible = true;//显示精确查找条件的容器
            }
            else
            {
                gBaseCondition.Visible = false;//隐藏精确查找条件的容器
            }
        }

        //上一步
        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlBaseResult.Visible = false;//隐藏基本查找结果容器
            pnlAdvancedResult.Visible = false;//隐藏高级查找结果容器
            pnlBaseCondition.Visible = true;//显示基本查找条件容器
            pnlAdvancedCondition.Visible = true;//显示高级查找条件容器
            btnBack.Visible = false;//隐藏上一步按钮
            btnAdd.Visible = false;//隐藏加为好友按钮
        }

        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }

        //最小化窗体
        private void pboxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//最小化窗体
        }

        //拖动窗体
        private void Frm_AddFriend_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture();//用来释放被当前线程中某个窗口捕获的光标
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);//向Windows发送拖动窗体的消息
        }

        private void txtLoginId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != "")//控制只能输入数字或删除键
            {
                e.Handled = true;
            }
        }
    }
}