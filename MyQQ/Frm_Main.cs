using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;

namespace MyQQ
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();

            //控制ListVIew的行距和列距
            PublicClass.SendMessage(this.lvFriend.Handle, PublicClass.LVM_SETICONAPACING, 0, 0x10000 * 70 + 130);//70为行距，120为列距（跟图片大小有关）
        }
        int fromUserID;//消息发送者
        int friendHeadID;  //发消息好友的头像ID  
        int messageImageIndex = 0; //工具栏中的消息图标的索引
        public static string nickName = "";//自己的昵称
        public static string strFlag = "[离线]";
        DataOperator dataOper = new DataOperator();//创建数据操作类的对象

        ///<summary>
        ///显示个人信息
        ///</summary>
        public void ShowInfo()
        {
            int headID = 0;//头像索引
            //获取当前用户的昵称、头像
            string sql = "select NickName, HeadID,Sign from tb_User where ID=" + PublicClass.loginID + "";
            SqlDataReader dataReader = dataOper.GetDataReader(sql); //执行查询操作
            if (dataReader.Read())//读取查询结果
            {
                if (!(dataReader["NickName"] is DBNull))//判断NickName不为空
                {
                    nickName = dataReader["NickName"].ToString();//记录自己的昵称
                }
                headID = Convert.ToInt32(dataReader["HeadID"]);//记录自己的头像ID
                txtSign.Text = dataReader["Sign"].ToString();//显示个性签名
            }
            dataReader.Close();//关闭读取器
            DataOperator.connection.Close();//关闭数据库连接
            this.Text = PublicClass.loginID.ToString();//设置窗体标题为当前用户账号
            pboxHead.Image = imglistHead.Images[headID];//显示用户头像
            lblName.Text = nickName + "(" + PublicClass.loginID + ")";//显示昵称及账号
        }

        ///<summary>
        ///显示我的好友列表
        ///</summary>
        private void ShowFriendList()
        {
            lvFriend.Items.Clear();//清空原来的列表
            //定义查找好友的SQL语句
            string sql = "select FriendID,NickName,HeadID,Flag from tb_User,tb_Friend where tb_Friend.HostID=" + PublicClass.loginID + " and tb_User.ID=tb_Friend.FriendID";
            SqlDataReader dataReader = dataOper.GetDataReader(sql);//执行查询
            int i = lvFriend.Items.Count;//定义变量，用来记录添加到ListView中的项索引
            while (dataReader.Read())//循环添加好友列表
            {
                if(dataReader["Flag"].ToString()=="0")
                    strFlag = "[离线]";
                else
                    strFlag = "[在线]";
                string strTemp = dataReader["NickName"].ToString();//记录好友昵称
                //对好友昵称进行处理
                string strFriendName=strTemp;
                if (strTemp.Length < 9)
                    strFriendName = strTemp.PadLeft(9, ' ');
                else
                    strFriendName = (strTemp.Substring(0, 2) + "...").PadLeft(9, ' ');
                //向ListView中添加项，Name:好友ID，值：昵称，要显示的头像
                lvFriend.Items.Add(dataReader["FriendID"].ToString(), strFriendName + strFlag, (int)dataReader["HeadID"]);
                lvFriend.Items[i].Group = lvFriend.Groups[0];//设置项的分组为我的好友
                i++;//临时变量加1
            }
            dataReader.Close();//关闭读取器
            DataOperator.connection.Close();//关闭数据库连接
        }

        //窗体加载事件
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            tsbtnMessageReading.Image = imglistMessage.Images[0];//工具栏的消息图标
            ShowInfo();//显示个人信息
            ShowFriendList();//显示好友列表
        }

        //显示个人信息窗体
        private void tsbtnInfo_Click(object sender, EventArgs e)
        {
            Frm_EditInfo frmInfo = new Frm_EditInfo();//创建个人信息窗体对象
            frmInfo.frmMain = this;  //将当前窗体对象传给个人信息窗体
            frmInfo.Show();//显示个人信息窗体
        }

        //显示查找好友窗体
        private void tsbtnSearchFriend_Click(object sender, EventArgs e)
        {
            Frm_AddFriend frmAddFriend = new Frm_AddFriend();//创建查找好友窗体对象
            frmAddFriend.Show();//显示查找好友窗体
        }

        //刷新好友列表
        private void tsbtnUpdateFriendList_Click(object sender, EventArgs e)
        {
            ShowFriendList();//显示好友列表
        }

        /// <summary>
        /// 显示陌生人列表
        /// </summary>
        /// <param name="ID">指定用户的ID</param>
        private void UpdateStranger(int ID)
        {
            lvFriend.Items.Clear();//清空原来的列表
            //获取指定用户的昵称及头像ID
            string sql = "select NickName, HeadID from tb_User where ID=" + ID;
            SqlDataReader dataReader = dataOper.GetDataReader(sql);//执行查询
            int i = lvFriend.Items.Count;//定义变量，用来记录添加到ListView中的项索引
            //循环添加陌生人列表
            while (dataReader.Read())
            {
                string strTemp = dataReader["NickName"].ToString();//记录好友昵称
                //对好友昵称进行处理
                string strName = strTemp;
                if (strTemp.Length < 9)
                    strName = strTemp.PadLeft(9, ' ');
                else
                    strName = (strTemp.Substring(0, 2) + "...").PadLeft(9, ' ');
                //向ListView中添加项，Name:用户ID，值：昵称，要显示的头像
                lvFriend.Items.Add(fromUserID.ToString(), strName, (int)dataReader["HeadID"]);
                lvFriend.Items[i].Group = lvFriend.Groups[1];//设置项的分组为陌生人
                i++;//临时变量加1
            }
            dataReader.Close();//关闭读取器
            DataOperator.connection.Close();//关闭数据库连接
        }

        /// <summary>
        /// 判断发消息的用户是否在列表中
        /// </summary>
        /// <param name="ID">指定用户的ID</param>
        /// <returns>在列表中，返回true，否则为false</returns>
        private bool HasShowUser(int ID)
        {
            bool find = false;  //是否在当前显示出的用户列表中找到了该用户
            //循环lvFriend中的2个组，寻找发消息的人是否在列表中
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < lvFriend.Groups[i].Items.Count; j++)
                {
                    if (Convert.ToInt32(lvFriend.Groups[i].Items[j].Name) == ID)
                    {
                        find = true;
                    }
                }
            }
            return find;
        }

        //实时获取未读消息的定时器
        private void tmMessage_Tick(object sender, EventArgs e)
        {
            Point pp = new Point(Cursor.Position.X, Cursor.Position.Y);//获取鼠标在屏幕的坐标点
            Rectangle Rects = new Rectangle(this.Left, this.Top, this.Left + this.Width, this.Top + this.Height);//存储当前窗体在屏幕的所在区域
            if ((this.Top < 0) && PublicClass.PtInRect(ref Rects, pp))//当鼠标在当前窗体内，并且窗体的Top属性小于0
                this.Top = 0;//设置窗体的Top属性为0
            else
                //当窗体的上边框与屏幕的顶端的距离小于5时
                if (this.Top > -5 && this.Top < 5 && !(PublicClass.PtInRect(ref Rects, pp)))
                this.Top = 5 - this.Height;//将QQ窗体隐藏到屏幕的顶端
            if (lvFriend.SelectedItems.Count > 0)//判断好友列表中有选中项
            {
                if (lvFriend.SelectedItems[0].Group == lvFriend.Groups[0]) //如果选中项属于第1组
                {
                    tsMenuDel.Visible = true;//显示删除菜单
                    tsMenuAdd.Visible = false;//隐藏添加好友菜单
                }
                else if (lvFriend.SelectedItems[0].Group == lvFriend.Groups[1]) //如果选中项属于第2组
                {
                    tsMenuDel.Visible = false;//隐藏删除菜单
                    tsMenuAdd.Visible = true;//显示添加好友菜单
                }
            }
            int messageTypeID = 1;//消息类型
            int messageState = 1;//消息状态
            //查找未读消息对应的好友ID
            string sql = "select top 1 FromUserID, MessageTypeID, MessageState from tb_Message where ToUserID=" + PublicClass.loginID + " and MessageState=0";
            SqlDataReader dataReader = dataOper.GetDataReader(sql);//执行查询
            if (dataReader.Read())//读取未读消息
            {
                fromUserID = (int)dataReader["FromUserID"];//记录消息发送者
                messageTypeID = (int)dataReader["MessageTypeID"]; //记录消息类型
                messageState = (int)dataReader["MessageState"]; //记录消息状态
            }
            dataReader.Close();//关闭读取器
            DataOperator.connection.Close();//关闭数据库连接
            //消息有两种类型：聊天消息、添加好友消息
            //判断消息类型，如果是添加好友消息，启动消息提醒定时器
            if (messageTypeID == 2 && messageState == 0)
            {
                SoundPlayer player = new SoundPlayer("system.wav");//系统消息提示
                player.Play();//播放指定声音文件
                tmAddFriend.Start();//启动消息提醒定时器
            }
            //如果是聊天消息，启动聊天定时器，使好友头像闪烁
            else if (messageTypeID == 1 && messageState == 0)
            {
                //获取消息发送者的ID
                sql = "select HeadID from tb_User where ID=" + fromUserID;
                friendHeadID = dataOper.ExecSQL(sql);//设置发消息好友的头像ID
                //如果发消息的人不在好友列表中，将其添加到陌生人列表中
                if (!HasShowUser(fromUserID))
                {
                    UpdateStranger(fromUserID);//显示陌生人列表
                }
                SoundPlayer player = new SoundPlayer("msg.wav");//聊天消息提示
                player.Play();//播放指定声音文件
                tmChat.Start();//启动聊天定时器
            }
        }

        //消息提醒定时器
        private void tmAddFriend_Tick(object sender, EventArgs e)
        {
            messageImageIndex = messageImageIndex == 0 ? 1:0;//实时获取系统消息图像索引
            tsbtnMessageReading.Image = imglistMessage.Images[messageImageIndex];//工具栏中显示消息读取状态图像
        }

        //聊天定时器
        private void tmChat_Tick(object sender, EventArgs e)
        {
            //循环好友列表两个组中的每项，找到消息发送者，使其头像闪烁
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < lvFriend.Groups[i].Items.Count; j++)
                {
                    if (Convert.ToInt32(lvFriend.Groups[i].Items[j].Name) == fromUserID)//判断是否为消息发送者
                    {
                        if (frmChat != null && frmChat.friendID != 0)
                        {
                            lvFriend.SelectedItems[0].ImageIndex = friendHeadID;//直接显示头像，避免闪烁效果
                        }
                        else
                        {
                            if (lvFriend.Groups[i].Items[j].ImageIndex < 100)
                            {
                                //索引为100的图片是一个空白图片，为了实现闪烁效果
                                lvFriend.Groups[i].Items[j].ImageIndex = 100;
                            }
                            else
                            {
                                lvFriend.Groups[i].Items[j].ImageIndex = friendHeadID;//要显示的消息发送者头像索引
                            }
                        }
                    }
                }
            }
        }

        //显示请求好友消息窗体
        private void tsbtnMessageReading_Click(object sender, EventArgs e)
        {
            tmAddFriend.Stop();//停止消息提醒定时器
            messageImageIndex = 0;//头像恢复正常
            //显示正常的系统消息提醒图标
            tsbtnMessageReading.Image = imglistMessage.Images[messageImageIndex];
            Frm_Remind frmRemind = new Frm_Remind();//创建系统消息窗体对象
            frmRemind.Show();//显示系统消息窗体
        }

        //大、小头像视图切换
        private void tsMenuView_Click(object sender, EventArgs e)
        {
            if (lvFriend.View == View.LargeIcon)//如果当前为大头像状态
            {
                for (int i = 0; i < lvFriend.Items.Count; i++)
                    lvFriend.Items[i].Text = "  "+lvFriend.Items[i].Text.TrimStart();
                lvFriend.View = View.SmallIcon;//切换为小头像状态
                tsMenuView.Text = "大头像";//设置快捷菜单文本
            }
            else if (lvFriend.View == View.SmallIcon)//如果当前为小头像状态
            {
                for (int i = 0; i < lvFriend.Items.Count; i++)
                    lvFriend.Items[i].Text = lvFriend.Items[i].Text.PadLeft(9,' ');
                lvFriend.View = View.LargeIcon;//切换为大头像状态
                tsMenuView.Text = "小头像";
            }
        }

        //添加好友              
        private void tsMenuAdd_Click(object sender, EventArgs e)
        {
            if (lvFriend.SelectedItems.Count > 0)//判断是否有选中项
            {
                //定义为指定用户添加指定好友的SQL语句
                string sql = "insert into tb_Friend (HostID, FriendID) values(" + PublicClass.loginID + "," + Convert.ToInt32(lvFriend.SelectedItems[0].Name) + ")";
                int result = dataOper.ExecSQLResult(sql);//执行添加操作
                if (result == 1)//添加成功
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lvFriend.Groups[0].Items.Add(lvFriend.SelectedItems[0]);//将好友添加到“我的好友”组中
                    ShowFriendList();//更新好友列表             
                }
                else
                {
                    MessageBox.Show("添加失败，请稍候再试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //删除好友
        private void tsMenuDel_Click(object sender, EventArgs e)
        {
            if (lvFriend.SelectedItems.Count > 0)//判断是否有选中项
            {
                //弹出确认删除对话框
                DialogResult result = MessageBox.Show("确实要删除该好友吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) //如果单击了是按钮
                {
                    //定义删除指定用户指定好友的SQL语句
                    string sql = "delete from tb_Friend where HostID="+ PublicClass.loginID + " AND FriendID="+ Convert.ToInt32(lvFriend.SelectedItems[0].Name) + "";
                    int deleteResult = dataOper.ExecSQLResult(sql);//执行删除操作
                    if (deleteResult == 1)//删除成功
                    {
                        MessageBox.Show("好友已删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lvFriend.Items.Remove(lvFriend.SelectedItems[0]);//将用户从好友列表中移除
                    }
                }
            }
        }        

        //退出
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            //弹出确定对话框
            DialogResult result = MessageBox.Show("确实要退出吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)//如果单击是按钮
            {
                Application.ExitThread();//退出当前程序
            }
        }

        Frm_Chat frmChat;//聊天窗体对象
        //双击打开聊天窗体
        private void lvFriend_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvFriend.SelectedItems.Count > 0)//判断是否有选中项
            {
                
                if (frmChat == null)//判断聊天窗体对象是否为空
                {
                    frmChat = new Frm_Chat();//创建聊天窗体对象
                    frmChat.friendID = Convert.ToInt32(lvFriend.SelectedItems[0].Name);//记录聊天的账号
                    frmChat.nickName = dataOper.GetDataSet("select NickName from tb_User where ID=" + frmChat.friendID).Tables[0].Rows[0][0].ToString();//记录昵称
                    frmChat.headID = Convert.ToInt32(dataOper.GetDataSet("select HeadID from tb_User where ID=" + frmChat.friendID).Tables[0].Rows[0][0])+1;//记录头像ID
                    frmChat.ShowDialog();//以对话框显示聊天窗体对象
                    frmChat = null;//将聊天窗体对象设置为空
                }
                if (tmChat.Enabled == true)//如果聊天定时器处于可用状态
                {
                    tmChat.Stop();//停止聊天定时器
                    lvFriend.SelectedItems[0].ImageIndex = friendHeadID;//将选中项的头像显示为正常状态
                }
            }
        }

        //系统托盘图标
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)//判断窗体是否为最小化状态
            {
                this.Show();//显示当前窗体
                this.WindowState = FormWindowState.Normal;//还原窗体
            }
        }

        //窗体尺寸发生变化时触发的事件（系统托盘）
        private void Frm_Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)//判断窗体是否为正常状态
                notifyIcon1.Visible = false;//隐藏托盘图标
            else if (this.WindowState == FormWindowState.Minimized)//判断窗体是否为最小化状态
            {
                this.Hide();//隐藏当前窗体
                notifyIcon1.Visible = true;//隐藏托盘图标
            }
        }

        //关闭窗体
        private void pboxClose_Click(object sender, EventArgs e)
        {
            dataOper.ExecSQLResult("update tb_User set Flag=0 where ID=" + PublicClass.loginID);//设置离线状态
            Application.ExitThread();//退出当前应用程序
        }

        //最小化窗体
        private void pboxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//最小化窗体
        }

        //拖动窗体
        private void Frm_Main_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture();//用来释放被当前线程中某个窗口捕获的光标
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);//向Windows发送拖动窗体的消息
        }

        private void txtSign_Click(object sender, EventArgs e)
        {
            txtSign.ReadOnly = false;//设置个性签名可编辑
            txtSign.SelectAll();//全选文本
        }

        private void txtSign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')//如果按下回车键
            {
                dataOper.ExecSQLResult("update tb_User set Sign='" + txtSign.Text + "' where ID=" + PublicClass.loginID);//更新个性签名
                txtSign.ReadOnly = true;//显示个性签名不可编辑
                lblId.Focus();
            }
        }

        private void lvFriend_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}