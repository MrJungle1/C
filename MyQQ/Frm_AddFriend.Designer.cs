namespace MyQQ
{
    partial class Frm_AddFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddFriend));
            this.tabSearch = new System.Windows.Forms.TabControl();
            this.tpBaseSearch = new System.Windows.Forms.TabPage();
            this.pnlBaseCondition = new System.Windows.Forms.Panel();
            this.pnlBaseResult = new System.Windows.Forms.Panel();
            this.dgvBasicResult = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picBaseResult = new System.Windows.Forms.PictureBox();
            this.lblBaseResult = new System.Windows.Forms.Label();
            this.pnlSearchType = new System.Windows.Forms.Panel();
            this.rbtnDetailSearch = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.gBaseCondition = new System.Windows.Forms.GroupBox();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.lblLoginId = new System.Windows.Forms.Label();
            this.picBaseCondition = new System.Windows.Forms.PictureBox();
            this.lblBaseCondition = new System.Windows.Forms.Label();
            this.tpAdvancedSearch = new System.Windows.Forms.TabPage();
            this.pnlAdvancedCondition = new System.Windows.Forms.Panel();
            this.pnlAdvancedResult = new System.Windows.Forms.Panel();
            this.picAdvancedResult = new System.Windows.Forms.PictureBox();
            this.lblAdvancedResult = new System.Windows.Forms.Label();
            this.dgvAdvancedResult = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAdvancedCondition = new System.Windows.Forms.GroupBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.cboxSex = new System.Windows.Forms.ComboBox();
            this.cboxAge = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.picAdvancedCondition = new System.Windows.Forms.PictureBox();
            this.lblAdvancedCondion = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.chLoginId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNickName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pboxClose = new System.Windows.Forms.PictureBox();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.tabSearch.SuspendLayout();
            this.tpBaseSearch.SuspendLayout();
            this.pnlBaseCondition.SuspendLayout();
            this.pnlBaseResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasicResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseResult)).BeginInit();
            this.pnlSearchType.SuspendLayout();
            this.gBaseCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseCondition)).BeginInit();
            this.tpAdvancedSearch.SuspendLayout();
            this.pnlAdvancedCondition.SuspendLayout();
            this.pnlAdvancedResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvancedResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvancedResult)).BeginInit();
            this.gAdvancedCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvancedCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.tpBaseSearch);
            this.tabSearch.Controls.Add(this.tpAdvancedSearch);
            this.tabSearch.Location = new System.Drawing.Point(123, 28);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.SelectedIndex = 0;
            this.tabSearch.Size = new System.Drawing.Size(377, 266);
            this.tabSearch.TabIndex = 1;
            this.tabSearch.SelectedIndexChanged += new System.EventHandler(this.tabSearch_SelectedIndexChanged);
            // 
            // tpBaseSearch
            // 
            this.tpBaseSearch.BackColor = System.Drawing.Color.White;
            this.tpBaseSearch.Controls.Add(this.pnlBaseCondition);
            this.tpBaseSearch.ForeColor = System.Drawing.Color.Black;
            this.tpBaseSearch.Location = new System.Drawing.Point(4, 22);
            this.tpBaseSearch.Name = "tpBaseSearch";
            this.tpBaseSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpBaseSearch.Size = new System.Drawing.Size(369, 240);
            this.tpBaseSearch.TabIndex = 0;
            this.tpBaseSearch.Text = "基本查找";
            // 
            // pnlBaseCondition
            // 
            this.pnlBaseCondition.Controls.Add(this.pnlBaseResult);
            this.pnlBaseCondition.Controls.Add(this.pnlSearchType);
            this.pnlBaseCondition.Controls.Add(this.gBaseCondition);
            this.pnlBaseCondition.Controls.Add(this.picBaseCondition);
            this.pnlBaseCondition.Controls.Add(this.lblBaseCondition);
            this.pnlBaseCondition.Location = new System.Drawing.Point(0, 0);
            this.pnlBaseCondition.Name = "pnlBaseCondition";
            this.pnlBaseCondition.Size = new System.Drawing.Size(366, 240);
            this.pnlBaseCondition.TabIndex = 4;
            // 
            // pnlBaseResult
            // 
            this.pnlBaseResult.Controls.Add(this.dgvBasicResult);
            this.pnlBaseResult.Controls.Add(this.picBaseResult);
            this.pnlBaseResult.Controls.Add(this.lblBaseResult);
            this.pnlBaseResult.Location = new System.Drawing.Point(17, 14);
            this.pnlBaseResult.Name = "pnlBaseResult";
            this.pnlBaseResult.Size = new System.Drawing.Size(347, 220);
            this.pnlBaseResult.TabIndex = 4;
            this.pnlBaseResult.Visible = false;
            // 
            // dgvBasicResult
            // 
            this.dgvBasicResult.AllowUserToAddRows = false;
            this.dgvBasicResult.AllowUserToDeleteRows = false;
            this.dgvBasicResult.AllowUserToResizeColumns = false;
            this.dgvBasicResult.AllowUserToResizeRows = false;
            this.dgvBasicResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBasicResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvBasicResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBasicResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBasicResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nickName,
            this.age,
            this.sex});
            this.dgvBasicResult.GridColor = System.Drawing.Color.White;
            this.dgvBasicResult.Location = new System.Drawing.Point(0, 37);
            this.dgvBasicResult.MultiSelect = false;
            this.dgvBasicResult.Name = "dgvBasicResult";
            this.dgvBasicResult.ReadOnly = true;
            this.dgvBasicResult.RowHeadersVisible = false;
            this.dgvBasicResult.RowTemplate.Height = 23;
            this.dgvBasicResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBasicResult.Size = new System.Drawing.Size(347, 180);
            this.dgvBasicResult.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "MyQQ账号";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nickName
            // 
            this.nickName.DataPropertyName = "NickName";
            this.nickName.HeaderText = "昵称";
            this.nickName.Name = "nickName";
            this.nickName.ReadOnly = true;
            // 
            // age
            // 
            this.age.DataPropertyName = "Age";
            this.age.HeaderText = "年龄";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "Sex";
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // picBaseResult
            // 
            this.picBaseResult.Image = global::MyQQ.Properties.Resources.search;
            this.picBaseResult.Location = new System.Drawing.Point(30, 8);
            this.picBaseResult.Name = "picBaseResult";
            this.picBaseResult.Size = new System.Drawing.Size(17, 18);
            this.picBaseResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBaseResult.TabIndex = 2;
            this.picBaseResult.TabStop = false;
            // 
            // lblBaseResult
            // 
            this.lblBaseResult.AutoSize = true;
            this.lblBaseResult.Location = new System.Drawing.Point(68, 12);
            this.lblBaseResult.Name = "lblBaseResult";
            this.lblBaseResult.Size = new System.Drawing.Size(161, 12);
            this.lblBaseResult.TabIndex = 3;
            this.lblBaseResult.Text = "以下是MyQQ为您找到的结果：";
            // 
            // pnlSearchType
            // 
            this.pnlSearchType.Controls.Add(this.rbtnDetailSearch);
            this.pnlSearchType.Controls.Add(this.rbtnAll);
            this.pnlSearchType.Location = new System.Drawing.Point(70, 29);
            this.pnlSearchType.Name = "pnlSearchType";
            this.pnlSearchType.Size = new System.Drawing.Size(200, 49);
            this.pnlSearchType.TabIndex = 2;
            // 
            // rbtnDetailSearch
            // 
            this.rbtnDetailSearch.AutoSize = true;
            this.rbtnDetailSearch.Location = new System.Drawing.Point(12, 30);
            this.rbtnDetailSearch.Name = "rbtnDetailSearch";
            this.rbtnDetailSearch.Size = new System.Drawing.Size(71, 16);
            this.rbtnDetailSearch.TabIndex = 1;
            this.rbtnDetailSearch.Text = "精确查找";
            this.rbtnDetailSearch.UseVisualStyleBackColor = true;
            this.rbtnDetailSearch.CheckedChanged += new System.EventHandler(this.rbtnDetailSearch_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Location = new System.Drawing.Point(12, 9);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(83, 16);
            this.rbtnAll.TabIndex = 0;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "查找所有人";
            this.rbtnAll.UseVisualStyleBackColor = true;
            // 
            // gBaseCondition
            // 
            this.gBaseCondition.Controls.Add(this.txtNickName);
            this.gBaseCondition.Controls.Add(this.txtLoginId);
            this.gBaseCondition.Controls.Add(this.lblNickName);
            this.gBaseCondition.Controls.Add(this.lblLoginId);
            this.gBaseCondition.Location = new System.Drawing.Point(17, 96);
            this.gBaseCondition.Name = "gBaseCondition";
            this.gBaseCondition.Size = new System.Drawing.Size(294, 80);
            this.gBaseCondition.TabIndex = 3;
            this.gBaseCondition.TabStop = false;
            this.gBaseCondition.Text = "精确查找条件";
            this.gBaseCondition.Visible = false;
            // 
            // txtNickName
            // 
            this.txtNickName.Location = new System.Drawing.Point(96, 49);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(159, 21);
            this.txtNickName.TabIndex = 3;
            // 
            // txtLoginId
            // 
            this.txtLoginId.Location = new System.Drawing.Point(96, 21);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(159, 21);
            this.txtLoginId.TabIndex = 2;
            this.txtLoginId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoginId_KeyPress);
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Location = new System.Drawing.Point(25, 52);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(65, 12);
            this.lblNickName.TabIndex = 1;
            this.lblNickName.Text = "对方昵称：";
            // 
            // lblLoginId
            // 
            this.lblLoginId.AutoSize = true;
            this.lblLoginId.Location = new System.Drawing.Point(25, 24);
            this.lblLoginId.Name = "lblLoginId";
            this.lblLoginId.Size = new System.Drawing.Size(65, 12);
            this.lblLoginId.TabIndex = 0;
            this.lblLoginId.Text = "对方帐号：";
            // 
            // picBaseCondition
            // 
            this.picBaseCondition.Image = global::MyQQ.Properties.Resources.search;
            this.picBaseCondition.Location = new System.Drawing.Point(30, 8);
            this.picBaseCondition.Name = "picBaseCondition";
            this.picBaseCondition.Size = new System.Drawing.Size(17, 18);
            this.picBaseCondition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBaseCondition.TabIndex = 0;
            this.picBaseCondition.TabStop = false;
            // 
            // lblBaseCondition
            // 
            this.lblBaseCondition.AutoSize = true;
            this.lblBaseCondition.Location = new System.Drawing.Point(68, 14);
            this.lblBaseCondition.Name = "lblBaseCondition";
            this.lblBaseCondition.Size = new System.Drawing.Size(173, 12);
            this.lblBaseCondition.TabIndex = 1;
            this.lblBaseCondition.Text = "可以设置精确查询条件查找好友";
            // 
            // tpAdvancedSearch
            // 
            this.tpAdvancedSearch.BackColor = System.Drawing.Color.White;
            this.tpAdvancedSearch.Controls.Add(this.pnlAdvancedCondition);
            this.tpAdvancedSearch.Location = new System.Drawing.Point(4, 22);
            this.tpAdvancedSearch.Name = "tpAdvancedSearch";
            this.tpAdvancedSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdvancedSearch.Size = new System.Drawing.Size(369, 240);
            this.tpAdvancedSearch.TabIndex = 1;
            this.tpAdvancedSearch.Text = "高级查找";
            // 
            // pnlAdvancedCondition
            // 
            this.pnlAdvancedCondition.Controls.Add(this.pnlAdvancedResult);
            this.pnlAdvancedCondition.Controls.Add(this.gAdvancedCondition);
            this.pnlAdvancedCondition.Controls.Add(this.picAdvancedCondition);
            this.pnlAdvancedCondition.Controls.Add(this.lblAdvancedCondion);
            this.pnlAdvancedCondition.Location = new System.Drawing.Point(0, 0);
            this.pnlAdvancedCondition.Name = "pnlAdvancedCondition";
            this.pnlAdvancedCondition.Size = new System.Drawing.Size(369, 237);
            this.pnlAdvancedCondition.TabIndex = 4;
            // 
            // pnlAdvancedResult
            // 
            this.pnlAdvancedResult.Controls.Add(this.picAdvancedResult);
            this.pnlAdvancedResult.Controls.Add(this.lblAdvancedResult);
            this.pnlAdvancedResult.Controls.Add(this.dgvAdvancedResult);
            this.pnlAdvancedResult.Location = new System.Drawing.Point(30, 37);
            this.pnlAdvancedResult.Name = "pnlAdvancedResult";
            this.pnlAdvancedResult.Size = new System.Drawing.Size(348, 194);
            this.pnlAdvancedResult.TabIndex = 4;
            this.pnlAdvancedResult.Visible = false;
            // 
            // picAdvancedResult
            // 
            this.picAdvancedResult.Image = global::MyQQ.Properties.Resources.search;
            this.picAdvancedResult.Location = new System.Drawing.Point(30, 12);
            this.picAdvancedResult.Name = "picAdvancedResult";
            this.picAdvancedResult.Size = new System.Drawing.Size(17, 18);
            this.picAdvancedResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdvancedResult.TabIndex = 3;
            this.picAdvancedResult.TabStop = false;
            // 
            // lblAdvancedResult
            // 
            this.lblAdvancedResult.AutoSize = true;
            this.lblAdvancedResult.Location = new System.Drawing.Point(65, 17);
            this.lblAdvancedResult.Name = "lblAdvancedResult";
            this.lblAdvancedResult.Size = new System.Drawing.Size(161, 12);
            this.lblAdvancedResult.TabIndex = 4;
            this.lblAdvancedResult.Text = "以下是MyQQ为您找到的结果：";
            // 
            // dgvAdvancedResult
            // 
            this.dgvAdvancedResult.AllowUserToAddRows = false;
            this.dgvAdvancedResult.AllowUserToDeleteRows = false;
            this.dgvAdvancedResult.AllowUserToResizeColumns = false;
            this.dgvAdvancedResult.AllowUserToResizeRows = false;
            this.dgvAdvancedResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdvancedResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdvancedResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAdvancedResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdvancedResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvAdvancedResult.GridColor = System.Drawing.Color.White;
            this.dgvAdvancedResult.Location = new System.Drawing.Point(0, 42);
            this.dgvAdvancedResult.MultiSelect = false;
            this.dgvAdvancedResult.Name = "dgvAdvancedResult";
            this.dgvAdvancedResult.ReadOnly = true;
            this.dgvAdvancedResult.RowHeadersVisible = false;
            this.dgvAdvancedResult.RowTemplate.Height = 23;
            this.dgvAdvancedResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdvancedResult.Size = new System.Drawing.Size(336, 152);
            this.dgvAdvancedResult.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "MyQQ号码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NickName";
            this.dataGridViewTextBoxColumn2.HeaderText = "昵称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn3.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn4.HeaderText = "性别";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // gAdvancedCondition
            // 
            this.gAdvancedCondition.Controls.Add(this.lblSex);
            this.gAdvancedCondition.Controls.Add(this.cboxSex);
            this.gAdvancedCondition.Controls.Add(this.cboxAge);
            this.gAdvancedCondition.Controls.Add(this.lblAge);
            this.gAdvancedCondition.Location = new System.Drawing.Point(30, 48);
            this.gAdvancedCondition.Name = "gAdvancedCondition";
            this.gAdvancedCondition.Size = new System.Drawing.Size(266, 115);
            this.gAdvancedCondition.TabIndex = 3;
            this.gAdvancedCondition.TabStop = false;
            this.gAdvancedCondition.Text = "基本条件";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(37, 69);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "性别：";
            // 
            // cboxSex
            // 
            this.cboxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSex.FormattingEnabled = true;
            this.cboxSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboxSex.Location = new System.Drawing.Point(84, 66);
            this.cboxSex.Name = "cboxSex";
            this.cboxSex.Size = new System.Drawing.Size(121, 20);
            this.cboxSex.TabIndex = 2;
            // 
            // cboxAge
            // 
            this.cboxAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAge.FormattingEnabled = true;
            this.cboxAge.Items.AddRange(new object[] {
            "不限",
            "0～10岁",
            "10～20岁",
            "20～30岁",
            "30～40岁",
            "40～50岁",
            "50岁以上"});
            this.cboxAge.Location = new System.Drawing.Point(84, 30);
            this.cboxAge.Name = "cboxAge";
            this.cboxAge.Size = new System.Drawing.Size(121, 20);
            this.cboxAge.TabIndex = 1;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(37, 33);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 12);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "年龄：";
            // 
            // picAdvancedCondition
            // 
            this.picAdvancedCondition.Image = global::MyQQ.Properties.Resources.search;
            this.picAdvancedCondition.Location = new System.Drawing.Point(30, 13);
            this.picAdvancedCondition.Name = "picAdvancedCondition";
            this.picAdvancedCondition.Size = new System.Drawing.Size(17, 18);
            this.picAdvancedCondition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdvancedCondition.TabIndex = 1;
            this.picAdvancedCondition.TabStop = false;
            // 
            // lblAdvancedCondion
            // 
            this.lblAdvancedCondion.AutoSize = true;
            this.lblAdvancedCondion.Location = new System.Drawing.Point(65, 18);
            this.lblAdvancedCondion.Name = "lblAdvancedCondion";
            this.lblAdvancedCondion.Size = new System.Drawing.Size(185, 12);
            this.lblAdvancedCondion.TabIndex = 2;
            this.lblAdvancedCondion.Text = "您可以通过年龄或者性别进行查找";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(416, 300);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.Location = new System.Drawing.Point(339, 300);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(339, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "加为好友";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(262, 300);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "上一步";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chLoginId
            // 
            this.chLoginId.Text = "MyQQ号码";
            this.chLoginId.Width = 80;
            // 
            // chNickName
            // 
            this.chNickName.Text = "MyQQ昵称";
            this.chNickName.Width = 80;
            // 
            // chAge
            // 
            this.chAge.Text = "年龄";
            this.chAge.Width = 80;
            // 
            // chSex
            // 
            this.chSex.Text = "性别";
            this.chSex.Width = 80;
            // 
            // pboxClose
            // 
            this.pboxClose.BackColor = System.Drawing.Color.Transparent;
            this.pboxClose.Location = new System.Drawing.Point(469, -1);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(27, 28);
            this.pboxClose.TabIndex = 8;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pboxMin
            // 
            this.pboxMin.BackColor = System.Drawing.Color.Transparent;
            this.pboxMin.Location = new System.Drawing.Point(440, -1);
            this.pboxMin.Name = "pboxMin";
            this.pboxMin.Size = new System.Drawing.Size(27, 28);
            this.pboxMin.TabIndex = 7;
            this.pboxMin.TabStop = false;
            this.pboxMin.Click += new System.EventHandler(this.pboxMin_Click);
            // 
            // Frm_AddFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::MyQQ.Properties.Resources.searchback;
            this.ClientSize = new System.Drawing.Size(499, 329);
            this.Controls.Add(this.pboxClose);
            this.Controls.Add(this.pboxMin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_AddFriend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找/添加好友";
            this.Load += new System.EventHandler(this.Frm_AddFriend_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_AddFriend_MouseDown);
            this.tabSearch.ResumeLayout(false);
            this.tpBaseSearch.ResumeLayout(false);
            this.pnlBaseCondition.ResumeLayout(false);
            this.pnlBaseCondition.PerformLayout();
            this.pnlBaseResult.ResumeLayout(false);
            this.pnlBaseResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBasicResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseResult)).EndInit();
            this.pnlSearchType.ResumeLayout(false);
            this.pnlSearchType.PerformLayout();
            this.gBaseCondition.ResumeLayout(false);
            this.gBaseCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseCondition)).EndInit();
            this.tpAdvancedSearch.ResumeLayout(false);
            this.pnlAdvancedCondition.ResumeLayout(false);
            this.pnlAdvancedCondition.PerformLayout();
            this.pnlAdvancedResult.ResumeLayout(false);
            this.pnlAdvancedResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvancedResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvancedResult)).EndInit();
            this.gAdvancedCondition.ResumeLayout(false);
            this.gAdvancedCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdvancedCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabSearch;
        private System.Windows.Forms.TabPage tpBaseSearch;
        private System.Windows.Forms.TabPage tpAdvancedSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picBaseCondition;
        private System.Windows.Forms.Label lblBaseCondition;
        private System.Windows.Forms.Panel pnlSearchType;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnDetailSearch;
        private System.Windows.Forms.GroupBox gBaseCondition;
        private System.Windows.Forms.Label lblLoginId;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.PictureBox picAdvancedCondition;
        private System.Windows.Forms.Label lblAdvancedCondion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColumnHeader chLoginId;
        private System.Windows.Forms.ColumnHeader chNickName;
        private System.Windows.Forms.ColumnHeader chAge;
        private System.Windows.Forms.ColumnHeader chSex;
        private System.Windows.Forms.DataGridView dgvBasicResult;
        private System.Windows.Forms.Panel pnlBaseCondition;
        private System.Windows.Forms.Panel pnlBaseResult;
        private System.Windows.Forms.PictureBox picBaseResult;
        private System.Windows.Forms.Label lblBaseResult;
        private System.Windows.Forms.Panel pnlAdvancedCondition;
        private System.Windows.Forms.Panel pnlAdvancedResult;
        private System.Windows.Forms.PictureBox picAdvancedResult;
        private System.Windows.Forms.Label lblAdvancedResult;
        private System.Windows.Forms.DataGridView dgvAdvancedResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox gAdvancedCondition;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cboxSex;
        private System.Windows.Forms.ComboBox cboxAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.PictureBox pboxMin;
    }
}