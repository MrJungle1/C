using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyQQ
{
    public partial class Frm_Chat : Form
    {
        public Frm_Chat()
        {
            InitializeComponent();
        }
        public int friendID=0;//当前聊天的好友号码
        public string nickName;//当前聊天的好友昵称
        public int headID;//当前聊天的好友头像ID    
        DataOperator dataOper = new DataOperator();//创建数据操作类的对象

        ///<summary>
        ///读取所有的未读消息，显示在窗体中
        ///</summary>
        private void ShowMessage()
        {
            string messageID = "";//消息ID组成的字符串
            string message;//消息内容
            string messageTime;//消息发送时间
            //读取消息的SQL语句
            string sql = "select ID,Message,MessageTime from tb_Message where FromUserID=" + friendID + " and ToUserID=" + PublicClass.loginID + " and MessageTypeID=1 and MessageState=0";
            SqlDataReader datareader = dataOper.GetDataReader(sql);
            //循环将消息添加到窗体上
            while (datareader.Read())
            {
                messageID += datareader["ID"] + "_";//消息ID
                message = datareader["Message"].ToString();//消息
                messageTime = Convert.ToDateTime(datareader["MessageTime"]).ToString(); //消息的发送时间
                //设置消息显示格式
                rtxtMessage.Text += "\n" + nickName + "  " + messageTime + "\n  " + message + "";
            }
            DataOperator.connection.Close();//关闭数据库连接
            if (messageID.Length > 1)//判断是否存在消息
            {
                messageID.Remove(messageID.Length - 1);//去掉最后的连接符
                SetMessage(messageID);//将显示出的消息设置为已读
            }
        }

        ///<summary>
        ///将显示出的消息设置为已读
        ///</summary>        
        private void SetMessage(string messageID)
        {
            string[] messageIDs = messageID.Split('_');//分割出每个消息ID
            string sql = "update tb_Message set MessageState=1 where ID="; //定义更新SQL语句
            foreach (string id in messageIDs)//遍历所有消息ID
            {
                if (id != "")
                {
                    sql += id;//设置更新条件
                    int result = dataOper.ExecSQLResult(sql);//执行数据表更新操作
                }
            }
        }

        //窗体加载事件
        private void Frm_Chat_Load(object sender, EventArgs e)
        {
            this.Text = "与\"" + nickName + "\"聊天中";//设置窗体标题
            pboxHead.Image = imglistHead.Images[headID];//设置好友头像
            lblFriend.Text = string.Format("{0}({1})", nickName, friendID);//设置好友名称
            rtxtMessage.ScrollToCaret(); //滚动条总在最下方
        }

        //显示所有未读消息的计时器
        private void tmShowMessage_Tick(object sender, EventArgs e)
        {
            ShowMessage();//读取所有的未读消息，显示在窗体中
        }

        //发送消息
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (rtxtChat.Text.Trim() == "") //不能发送空消息
            {
                MessageBox.Show("不能发送空消息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else//发送消息
            {
                //此处的MessageTypeId为1，表示聊天消息；MessageState为0，表示消息未读
                string sql = string.Format(
                    "INSERT INTO tb_Message (FromUserID, ToUserID, Message, MessageTypeID, MessageState) VALUES ({0},{1},'{2}',{3},{4})",
                    PublicClass.loginID, friendID, rtxtChat.Text, 1, 0);
                int result = dataOper.ExecSQLResult(sql);//调用方法实现消息插入操作
                rtxtMessage.Text += "\n" + Frm_Main.nickName + "  " + DateTime.Now + "\n  " + rtxtChat.Text + "";
                if (result != 1)//如果返回结果不是1，表示没有发送成功
                {
                    MessageBox.Show("消息发送失败，请重新发送！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                rtxtChat.Text = "";  //清空消息
                rtxtChat.Focus();//定位鼠标输入焦点
            }
        }

        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
            this.Dispose();//释放资源
        }

        //在消息文本框中输入信息后，按下Ctrl+回车键,发送消息
        private void rtxtChat_KeyDown(object sender, KeyEventArgs e)
        {
            //当同时按下Ctrl和Enter时，发送消息
            if (e.Control && e.KeyValue == 13)
            {
                e.Handled = true;
                btnSend_Click(this, null);//发送消息
            }
        }

        //最小化窗体
        private void pboxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//最小化窗体
        }

        //拖动窗体
        private void Frm_Chat_MouseDown(object sender, MouseEventArgs e)
        {
            PublicClass.ReleaseCapture();//用来释放被当前线程中某个窗口捕获的光标
            PublicClass.SendMessage(this.Handle, PublicClass.WM_SYSCOMMAND, PublicClass.SC_MOVE + PublicClass.HTCAPTION, 0);//向Windows发送拖动窗体的消息
        }

        //消息记录
        private void pboxInfo_Click(object sender, EventArgs e)
        {
            rtxtMessage.Clear();
            string messageID = "";//消息ID组成的字符串
            string message;//消息内容
            string messageTime;//消息发送时间
            //读取消息的SQL语句
            string sql = "select ID,NickName,Message,MessageTime from v_Message where (FromUserID=" + friendID + " and ToUserID=" + PublicClass.loginID + ") or (FromUserID=" + PublicClass.loginID + " and ToUserID=" + friendID + ") order by MessageTime asc ";
            SqlDataReader datareader = dataOper.GetDataReader(sql);
            //循环将消息添加到窗体上
            while (datareader.Read())
            {
                messageID += datareader["ID"] + "_";//消息ID
                message = datareader["Message"].ToString();//消息
                messageTime = Convert.ToDateTime(datareader["MessageTime"]).ToString(); //消息的发送时间
                //设置消息显示格式
                rtxtMessage.Text += "\n" + datareader["NickName"] + "  " + messageTime + "\n  " + message + "";
            }
            DataOperator.connection.Close();//关闭数据库连接
        }
    }
}