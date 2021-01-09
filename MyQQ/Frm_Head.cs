using System;
using System.Windows.Forms;

namespace MyQQ
{
    ///<summary>
    ///头像选择窗体
    ///</summary>
    public partial class Frm_Head : Form
    {
        public Frm_Head()
        {
            InitializeComponent();
        }
        public Frm_EditInfo frmEditInfo;  //个人信息窗体

        //窗体加载事件
        private void Frm_Head_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < imglistHead.Images.Count; i++)//遍历ImageList列表
            {
                lvHead.Items.Add(i.ToString());//将遍历项添加到ListView列表中
                lvHead.Items[i].ImageIndex = i;//为头像设置索引
            }            
        }       

        //确定选择头像
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lvHead.SelectedItems.Count != 0)//判断是否选中了头像
            {
                int headID = lvHead.SelectedItems[0].ImageIndex;//获得当前选中头像的索引
                frmEditInfo.ShowHead(headID);//设置个人信息窗体中显示的头像
                this.Close();//关闭当前窗体
            }
            else
            {
                MessageBox.Show("请选择一个头像！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //双击选择头像
        private void lvHead_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int headID = lvHead.SelectedItems[0].ImageIndex;//获得当前选中头像的索引
            frmEditInfo.ShowHead(headID);//设置个人信息窗体中显示的头像
            this.Close();//关闭当前窗体
        }

        //关闭窗体
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }
    }
}