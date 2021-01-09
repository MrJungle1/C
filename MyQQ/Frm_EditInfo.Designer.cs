namespace MyQQ
{
    partial class Frm_EditInfo
    {
        ///<summary>
        ///必需的设计器变量。
        ///</summary>
        private System.ComponentModel.IContainer components = null;

        ///<summary>
        ///清理所有正在使用的资源。
        ///</summary>
        ///<param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        ///<summary>
        ///设计器支持所需的方法 - 不要
        ///使用代码编辑器修改此方法的内容。
        ///</summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditInfo));
            this.cboxBloodType = new System.Windows.Forms.ComboBox();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.cboxStar = new System.Windows.Forms.ComboBox();
            this.lblStar = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.cboxSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblLoginId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnNobody = new System.Windows.Forms.RadioButton();
            this.rbtnValidation = new System.Windows.Forms.RadioButton();
            this.rbtnAnybody = new System.Windows.Forms.RadioButton();
            this.goupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNewPwdAgain = new System.Windows.Forms.TextBox();
            this.lblOldPwd = new System.Windows.Forms.Label();
            this.lblNewPwdAgain = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.lblNewPwd = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.imglistHead = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnShowHead = new System.Windows.Forms.Button();
            this.pboxHead = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2.SuspendLayout();
            this.goupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxBloodType
            // 
            this.cboxBloodType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBloodType.FormattingEnabled = true;
            this.cboxBloodType.Items.AddRange(new object[] {
            "A型 ",
            "B型 ",
            "O型 ",
            "AB型"});
            this.cboxBloodType.Location = new System.Drawing.Point(225, 146);
            this.cboxBloodType.Name = "cboxBloodType";
            this.cboxBloodType.Size = new System.Drawing.Size(93, 20);
            this.cboxBloodType.TabIndex = 13;
            // 
            // lblBloodType
            // 
            this.lblBloodType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.BackColor = System.Drawing.Color.Transparent;
            this.lblBloodType.Location = new System.Drawing.Point(185, 150);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(41, 12);
            this.lblBloodType.TabIndex = 12;
            this.lblBloodType.Text = "血型：";
            // 
            // cboxStar
            // 
            this.cboxStar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStar.FormattingEnabled = true;
            this.cboxStar.Items.AddRange(new object[] {
            "白羊座",
            "金牛座",
            "双子座",
            "巨蟹座",
            "狮子座",
            "处女座",
            "天秤座",
            "天蝎座",
            "射手座",
            "摩羯座",
            "水瓶座",
            "双鱼座"});
            this.cboxStar.Location = new System.Drawing.Point(73, 146);
            this.cboxStar.Name = "cboxStar";
            this.cboxStar.Size = new System.Drawing.Size(95, 20);
            this.cboxStar.TabIndex = 11;
            // 
            // lblStar
            // 
            this.lblStar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStar.AutoSize = true;
            this.lblStar.BackColor = System.Drawing.Color.Transparent;
            this.lblStar.Location = new System.Drawing.Point(37, 150);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(41, 12);
            this.lblStar.TabIndex = 10;
            this.lblStar.Text = "星座：";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(73, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(95, 21);
            this.txtName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(13, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "真实姓名：";
            // 
            // txtAge
            // 
            this.txtAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAge.Location = new System.Drawing.Point(225, 114);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(93, 21);
            this.txtAge.TabIndex = 9;
            // 
            // lblAge
            // 
            this.lblAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Location = new System.Drawing.Point(185, 118);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 12);
            this.lblAge.TabIndex = 8;
            this.lblAge.Text = "年龄：";
            // 
            // cboxSex
            // 
            this.cboxSex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSex.FormattingEnabled = true;
            this.cboxSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboxSex.Location = new System.Drawing.Point(73, 82);
            this.cboxSex.Name = "cboxSex";
            this.cboxSex.Size = new System.Drawing.Size(95, 20);
            this.cboxSex.TabIndex = 5;
            // 
            // lblSex
            // 
            this.lblSex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSex.AutoSize = true;
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Location = new System.Drawing.Point(37, 86);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 4;
            this.lblSex.Text = "性别：";
            // 
            // txtNickName
            // 
            this.txtNickName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNickName.Location = new System.Drawing.Point(73, 50);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(95, 21);
            this.txtNickName.TabIndex = 3;
            this.txtNickName.TextChanged += new System.EventHandler(this.txtNickName_TextChanged);
            // 
            // lblNickName
            // 
            this.lblNickName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNickName.AutoSize = true;
            this.lblNickName.BackColor = System.Drawing.Color.Transparent;
            this.lblNickName.Location = new System.Drawing.Point(13, 54);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(65, 12);
            this.lblNickName.TabIndex = 2;
            this.lblNickName.Text = "用户昵称：";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(73, 18);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(95, 21);
            this.txtID.TabIndex = 1;
            this.txtID.TabStop = false;
            // 
            // lblLoginId
            // 
            this.lblLoginId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginId.Location = new System.Drawing.Point(13, 22);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(65, 12);
            this.lblLoginId.TabIndex = 0;
            this.lblLoginId.Text = "用户号码：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbtnNobody);
            this.groupBox2.Controls.Add(this.rbtnValidation);
            this.groupBox2.Controls.Add(this.rbtnAnybody);
            this.groupBox2.Location = new System.Drawing.Point(8, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "身份验证";
            // 
            // rbtnNobody
            // 
            this.rbtnNobody.AutoSize = true;
            this.rbtnNobody.Location = new System.Drawing.Point(24, 56);
            this.rbtnNobody.Name = "rbtnNobody";
            this.rbtnNobody.Size = new System.Drawing.Size(155, 16);
            this.rbtnNobody.TabIndex = 2;
            this.rbtnNobody.Tag = "3";
            this.rbtnNobody.Text = "不允许任何人加我为好友";
            this.rbtnNobody.UseVisualStyleBackColor = true;
            // 
            // rbtnValidation
            // 
            this.rbtnValidation.AutoSize = true;
            this.rbtnValidation.Location = new System.Drawing.Point(24, 38);
            this.rbtnValidation.Name = "rbtnValidation";
            this.rbtnValidation.Size = new System.Drawing.Size(179, 16);
            this.rbtnValidation.TabIndex = 1;
            this.rbtnValidation.Tag = "2";
            this.rbtnValidation.Text = "需要身份验证才能加我为好友";
            this.rbtnValidation.UseVisualStyleBackColor = true;
            // 
            // rbtnAnybody
            // 
            this.rbtnAnybody.AutoSize = true;
            this.rbtnAnybody.Checked = true;
            this.rbtnAnybody.Location = new System.Drawing.Point(24, 20);
            this.rbtnAnybody.Name = "rbtnAnybody";
            this.rbtnAnybody.Size = new System.Drawing.Size(143, 16);
            this.rbtnAnybody.TabIndex = 0;
            this.rbtnAnybody.TabStop = true;
            this.rbtnAnybody.Tag = "1";
            this.rbtnAnybody.Text = "允许任何人加我为好友";
            this.rbtnAnybody.UseVisualStyleBackColor = true;
            // 
            // goupBox1
            // 
            this.goupBox1.BackColor = System.Drawing.Color.Transparent;
            this.goupBox1.Controls.Add(this.txtNewPwdAgain);
            this.goupBox1.Controls.Add(this.lblOldPwd);
            this.goupBox1.Controls.Add(this.lblNewPwdAgain);
            this.goupBox1.Controls.Add(this.txtNewPwd);
            this.goupBox1.Controls.Add(this.txtOldPwd);
            this.goupBox1.Controls.Add(this.lblNewPwd);
            this.goupBox1.Location = new System.Drawing.Point(8, 6);
            this.goupBox1.Name = "goupBox1";
            this.goupBox1.Size = new System.Drawing.Size(298, 91);
            this.goupBox1.TabIndex = 0;
            this.goupBox1.TabStop = false;
            this.goupBox1.Text = "修改密码";
            // 
            // txtNewPwdAgain
            // 
            this.txtNewPwdAgain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPwdAgain.Location = new System.Drawing.Point(89, 60);
            this.txtNewPwdAgain.Name = "txtNewPwdAgain";
            this.txtNewPwdAgain.PasswordChar = '*';
            this.txtNewPwdAgain.Size = new System.Drawing.Size(187, 21);
            this.txtNewPwdAgain.TabIndex = 5;
            // 
            // lblOldPwd
            // 
            this.lblOldPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOldPwd.AutoSize = true;
            this.lblOldPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblOldPwd.Location = new System.Drawing.Point(30, 20);
            this.lblOldPwd.Name = "lblOldPwd";
            this.lblOldPwd.Size = new System.Drawing.Size(53, 12);
            this.lblOldPwd.TabIndex = 0;
            this.lblOldPwd.Text = "原密码：";
            // 
            // lblNewPwdAgain
            // 
            this.lblNewPwdAgain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewPwdAgain.AutoSize = true;
            this.lblNewPwdAgain.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPwdAgain.Location = new System.Drawing.Point(6, 63);
            this.lblNewPwdAgain.Name = "lblNewPwdAgain";
            this.lblNewPwdAgain.Size = new System.Drawing.Size(77, 12);
            this.lblNewPwdAgain.TabIndex = 4;
            this.lblNewPwdAgain.Text = "新密码确认：";
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPwd.Location = new System.Drawing.Point(89, 38);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(187, 21);
            this.txtNewPwd.TabIndex = 3;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldPwd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtOldPwd.Location = new System.Drawing.Point(89, 17);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.ReadOnly = true;
            this.txtOldPwd.Size = new System.Drawing.Size(187, 21);
            this.txtOldPwd.TabIndex = 1;
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewPwd.AutoSize = true;
            this.lblNewPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPwd.Location = new System.Drawing.Point(30, 41);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(53, 12);
            this.lblNewPwd.TabIndex = 2;
            this.lblNewPwd.Text = "新密码：";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.Location = new System.Drawing.Point(184, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(66, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Tag = "1";
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(256, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // imglistHead
            // 
            this.imglistHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistHead.ImageStream")));
            this.imglistHead.TransparentColor = System.Drawing.Color.Empty;
            this.imglistHead.Images.SetKeyName(0, "1");
            this.imglistHead.Images.SetKeyName(1, "2");
            this.imglistHead.Images.SetKeyName(2, "3");
            this.imglistHead.Images.SetKeyName(3, "4");
            this.imglistHead.Images.SetKeyName(4, "5");
            this.imglistHead.Images.SetKeyName(5, "6");
            this.imglistHead.Images.SetKeyName(6, "7");
            this.imglistHead.Images.SetKeyName(7, "8");
            this.imglistHead.Images.SetKeyName(8, "9");
            this.imglistHead.Images.SetKeyName(9, "10");
            this.imglistHead.Images.SetKeyName(10, "11");
            this.imglistHead.Images.SetKeyName(11, "12");
            this.imglistHead.Images.SetKeyName(12, "13");
            this.imglistHead.Images.SetKeyName(13, "14");
            this.imglistHead.Images.SetKeyName(14, "15");
            this.imglistHead.Images.SetKeyName(15, "16");
            this.imglistHead.Images.SetKeyName(16, "17");
            this.imglistHead.Images.SetKeyName(17, "18");
            this.imglistHead.Images.SetKeyName(18, "19");
            this.imglistHead.Images.SetKeyName(19, "20");
            this.imglistHead.Images.SetKeyName(20, "21");
            this.imglistHead.Images.SetKeyName(21, "22");
            this.imglistHead.Images.SetKeyName(22, "23");
            this.imglistHead.Images.SetKeyName(23, "24");
            this.imglistHead.Images.SetKeyName(24, "25");
            this.imglistHead.Images.SetKeyName(25, "26");
            this.imglistHead.Images.SetKeyName(26, "27");
            this.imglistHead.Images.SetKeyName(27, "28");
            this.imglistHead.Images.SetKeyName(28, "29");
            this.imglistHead.Images.SetKeyName(29, "30");
            this.imglistHead.Images.SetKeyName(30, "31");
            this.imglistHead.Images.SetKeyName(31, "32");
            this.imglistHead.Images.SetKeyName(32, "33");
            this.imglistHead.Images.SetKeyName(33, "34");
            this.imglistHead.Images.SetKeyName(34, "35");
            this.imglistHead.Images.SetKeyName(35, "36");
            this.imglistHead.Images.SetKeyName(36, "37");
            this.imglistHead.Images.SetKeyName(37, "38");
            this.imglistHead.Images.SetKeyName(38, "39");
            this.imglistHead.Images.SetKeyName(39, "40");
            this.imglistHead.Images.SetKeyName(40, "41");
            this.imglistHead.Images.SetKeyName(41, "42");
            this.imglistHead.Images.SetKeyName(42, "43");
            this.imglistHead.Images.SetKeyName(43, "44");
            this.imglistHead.Images.SetKeyName(44, "45");
            this.imglistHead.Images.SetKeyName(45, "46");
            this.imglistHead.Images.SetKeyName(46, "47");
            this.imglistHead.Images.SetKeyName(47, "48");
            this.imglistHead.Images.SetKeyName(48, "49");
            this.imglistHead.Images.SetKeyName(49, "50");
            this.imglistHead.Images.SetKeyName(50, "51");
            this.imglistHead.Images.SetKeyName(51, "52");
            this.imglistHead.Images.SetKeyName(52, "53");
            this.imglistHead.Images.SetKeyName(53, "54");
            this.imglistHead.Images.SetKeyName(54, "55");
            this.imglistHead.Images.SetKeyName(55, "56");
            this.imglistHead.Images.SetKeyName(56, "57");
            this.imglistHead.Images.SetKeyName(57, "58");
            this.imglistHead.Images.SetKeyName(58, "59");
            this.imglistHead.Images.SetKeyName(59, "60");
            this.imglistHead.Images.SetKeyName(60, "61");
            this.imglistHead.Images.SetKeyName(61, "62");
            this.imglistHead.Images.SetKeyName(62, "63");
            this.imglistHead.Images.SetKeyName(63, "64");
            this.imglistHead.Images.SetKeyName(64, "65");
            this.imglistHead.Images.SetKeyName(65, "66");
            this.imglistHead.Images.SetKeyName(66, "67");
            this.imglistHead.Images.SetKeyName(67, "68");
            this.imglistHead.Images.SetKeyName(68, "69");
            this.imglistHead.Images.SetKeyName(69, "70");
            this.imglistHead.Images.SetKeyName(70, "71");
            this.imglistHead.Images.SetKeyName(71, "72");
            this.imglistHead.Images.SetKeyName(72, "73");
            this.imglistHead.Images.SetKeyName(73, "74");
            this.imglistHead.Images.SetKeyName(74, "75");
            this.imglistHead.Images.SetKeyName(75, "76");
            this.imglistHead.Images.SetKeyName(76, "77");
            this.imglistHead.Images.SetKeyName(77, "78");
            this.imglistHead.Images.SetKeyName(78, "79");
            this.imglistHead.Images.SetKeyName(79, "80");
            this.imglistHead.Images.SetKeyName(80, "81");
            this.imglistHead.Images.SetKeyName(81, "82");
            this.imglistHead.Images.SetKeyName(82, "83");
            this.imglistHead.Images.SetKeyName(83, "84");
            this.imglistHead.Images.SetKeyName(84, "85");
            this.imglistHead.Images.SetKeyName(85, "86");
            this.imglistHead.Images.SetKeyName(86, "87");
            this.imglistHead.Images.SetKeyName(87, "88");
            this.imglistHead.Images.SetKeyName(88, "89");
            this.imglistHead.Images.SetKeyName(89, "90");
            this.imglistHead.Images.SetKeyName(90, "91");
            this.imglistHead.Images.SetKeyName(91, "92");
            this.imglistHead.Images.SetKeyName(92, "93");
            this.imglistHead.Images.SetKeyName(93, "94");
            this.imglistHead.Images.SetKeyName(94, "95");
            this.imglistHead.Images.SetKeyName(95, "96");
            this.imglistHead.Images.SetKeyName(96, "97");
            this.imglistHead.Images.SetKeyName(97, "98");
            this.imglistHead.Images.SetKeyName(98, "99");
            this.imglistHead.Images.SetKeyName(99, "100");
            this.imglistHead.Images.SetKeyName(100, "back.bmp");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(332, 221);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboxBloodType);
            this.tabPage1.Controls.Add(this.txtAge);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.cboxStar);
            this.tabPage1.Controls.Add(this.txtNickName);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.cboxSex);
            this.tabPage1.Controls.Add(this.lblLoginId);
            this.tabPage1.Controls.Add(this.lblBloodType);
            this.tabPage1.Controls.Add(this.lblNickName);
            this.tabPage1.Controls.Add(this.lblStar);
            this.tabPage1.Controls.Add(this.lblSex);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.btnShowHead);
            this.tabPage1.Controls.Add(this.lblAge);
            this.tabPage1.Controls.Add(this.pboxHead);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(324, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "个人信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnShowHead
            // 
            this.btnShowHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowHead.BackColor = System.Drawing.Color.AliceBlue;
            this.btnShowHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowHead.BackgroundImage")));
            this.btnShowHead.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowHead.Location = new System.Drawing.Point(275, 50);
            this.btnShowHead.Name = "btnShowHead";
            this.btnShowHead.Size = new System.Drawing.Size(18, 16);
            this.btnShowHead.TabIndex = 14;
            this.btnShowHead.UseVisualStyleBackColor = false;
            this.btnShowHead.Click += new System.EventHandler(this.btnShowHead_Click);
            // 
            // pboxHead
            // 
            this.pboxHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxHead.Location = new System.Drawing.Point(213, 24);
            this.pboxHead.Name = "pboxHead";
            this.pboxHead.Size = new System.Drawing.Size(50, 40);
            this.pboxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxHead.TabIndex = 8;
            this.pboxHead.TabStop = false;
            this.pboxHead.Click += new System.EventHandler(this.btnShowHead_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.goupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(324, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "安全设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Frm_EditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(339, 255);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_EditInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "个人信息设置";
            this.Load += new System.EventHandler(this.Frm_EditInfo_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.goupBox1.ResumeLayout(false);
            this.goupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxHead)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cboxSex;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.PictureBox pboxHead;        
        private System.Windows.Forms.Button btnShowHead;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.ComboBox cboxStar;
        private System.Windows.Forms.ComboBox cboxBloodType;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtNewPwdAgain;
        private System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label lblNewPwdAgain;
        private System.Windows.Forms.Label lblNewPwd;
        private System.Windows.Forms.TextBox txtOldPwd;
        private System.Windows.Forms.GroupBox goupBox1;
        private System.Windows.Forms.Label lblOldPwd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnAnybody;
        private System.Windows.Forms.RadioButton rbtnValidation;
        private System.Windows.Forms.RadioButton rbtnNobody;
        private System.Windows.Forms.ImageList imglistHead;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}