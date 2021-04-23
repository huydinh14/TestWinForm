
namespace VIEW
{
    partial class frmManageEmployees
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gcEmployee = new DevExpress.XtraGrid.GridControl();
            this.gvEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemFontEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemFontEdit();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvcmbRules = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNumberPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassWord = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployOfTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvCmbRule = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblMaNV = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblHoTen = new DevExpress.XtraEditors.LabelControl();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblSĐT = new DevExpress.XtraEditors.LabelControl();
            this.txtIDCard = new DevExpress.XtraEditors.TextEdit();
            this.lblCMND = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.txtSalary = new DevExpress.XtraEditors.TextEdit();
            this.lblLuong = new DevExpress.XtraEditors.LabelControl();
            this.cmbRule = new DevExpress.XtraEditors.LookUpEdit();
            this.lblChucVu = new DevExpress.XtraEditors.LabelControl();
            this.lblNgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.dtBirthday = new DevExpress.XtraEditors.DateEdit();
            this.lblGioiTinh = new DevExpress.XtraEditors.LabelControl();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.btnLoadNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddEmp = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcmbRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCmbRule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDCard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcEmployee
            // 
            this.gcEmployee.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            gridLevelNode1.RelationName = "Level1";
            this.gcEmployee.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcEmployee.Location = new System.Drawing.Point(14, 363);
            this.gcEmployee.MainView = this.gvEmployee;
            this.gcEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.gcEmployee.Name = "gcEmployee";
            this.gcEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gvCmbRule,
            this.repositoryItemFontEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemGridLookUpEdit1,
            this.gvcmbRules});
            this.gcEmployee.Size = new System.Drawing.Size(1261, 401);
            this.gcEmployee.TabIndex = 13;
            this.gcEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployee});
            // 
            // gvEmployee
            // 
            this.gvEmployee.Appearance.GroupPanel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmployee.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEmployee.Appearance.GroupPanel.Options.UseFont = true;
            this.gvEmployee.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvEmployee.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gvEmployee.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFullName,
            this.colRule,
            this.colNumberPhone,
            this.colGender,
            this.colBirthDay,
            this.colEmail,
            this.colPassWord,
            this.colIDCard,
            this.colSalary,
            this.colEmployOfTypeID,
            this.colStatus});
            this.gvEmployee.DetailHeight = 546;
            this.gvEmployee.GridControl = this.gcEmployee;
            this.gvEmployee.GroupPanelText = "Danh Sách Nhân Viên";
            this.gvEmployee.Name = "gvEmployee";
            this.gvEmployee.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvEmployee.OptionsBehavior.Editable = false;
            this.gvEmployee.OptionsSelection.MultiSelect = true;
            this.gvEmployee.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvEmployee.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvEmployee_SelectionChanged);
            // 
            // colID
            // 
            this.colID.Caption = "Mã NV";
            this.colID.ColumnEdit = this.repositoryItemFontEdit1;
            this.colID.FieldName = "StrID";
            this.colID.MinWidth = 39;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 146;
            // 
            // repositoryItemFontEdit1
            // 
            this.repositoryItemFontEdit1.AutoHeight = false;
            this.repositoryItemFontEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1";
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Họ Tên";
            this.colFullName.FieldName = "StrFullName";
            this.colFullName.MinWidth = 39;
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 146;
            // 
            // colRule
            // 
            this.colRule.Caption = "Chức Vụ";
            this.colRule.ColumnEdit = this.gvcmbRules;
            this.colRule.FieldName = "StrEmployTypeID";
            this.colRule.MinWidth = 39;
            this.colRule.Name = "colRule";
            this.colRule.Visible = true;
            this.colRule.VisibleIndex = 2;
            this.colRule.Width = 146;
            // 
            // gvcmbRules
            // 
            this.gvcmbRules.AutoHeight = false;
            this.gvcmbRules.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvcmbRules.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colID", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colName", "Chức vụ")});
            this.gvcmbRules.DisplayMember = "StrName";
            this.gvcmbRules.Name = "gvcmbRules";
            this.gvcmbRules.ValueMember = "StrID";
            // 
            // colNumberPhone
            // 
            this.colNumberPhone.Caption = "SĐT";
            this.colNumberPhone.FieldName = "StrNumberPhone";
            this.colNumberPhone.MinWidth = 39;
            this.colNumberPhone.Name = "colNumberPhone";
            this.colNumberPhone.Visible = true;
            this.colNumberPhone.VisibleIndex = 3;
            this.colNumberPhone.Width = 146;
            // 
            // colGender
            // 
            this.colGender.Caption = "Giới Tính";
            this.colGender.FieldName = "StrGender";
            this.colGender.MinWidth = 39;
            this.colGender.Name = "colGender";
            this.colGender.Visible = true;
            this.colGender.VisibleIndex = 4;
            this.colGender.Width = 146;
            // 
            // colBirthDay
            // 
            this.colBirthDay.Caption = "Ngày Sinh";
            this.colBirthDay.FieldName = "DTBirthDay";
            this.colBirthDay.MinWidth = 31;
            this.colBirthDay.Name = "colBirthDay";
            this.colBirthDay.Visible = true;
            this.colBirthDay.VisibleIndex = 5;
            this.colBirthDay.Width = 117;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "StrEmail";
            this.colEmail.MinWidth = 31;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            this.colEmail.Width = 117;
            // 
            // colPassWord
            // 
            this.colPassWord.Caption = "PassWord";
            this.colPassWord.FieldName = "StrPassword";
            this.colPassWord.MinWidth = 31;
            this.colPassWord.Name = "colPassWord";
            this.colPassWord.Visible = true;
            this.colPassWord.VisibleIndex = 7;
            this.colPassWord.Width = 117;
            // 
            // colIDCard
            // 
            this.colIDCard.Caption = "IDCard";
            this.colIDCard.FieldName = "StrIDCard";
            this.colIDCard.MinWidth = 31;
            this.colIDCard.Name = "colIDCard";
            this.colIDCard.Visible = true;
            this.colIDCard.VisibleIndex = 8;
            this.colIDCard.Width = 117;
            // 
            // colSalary
            // 
            this.colSalary.Caption = "Salary";
            this.colSalary.FieldName = "DecSalary";
            this.colSalary.MinWidth = 31;
            this.colSalary.Name = "colSalary";
            this.colSalary.Visible = true;
            this.colSalary.VisibleIndex = 9;
            this.colSalary.Width = 117;
            // 
            // colEmployOfTypeID
            // 
            this.colEmployOfTypeID.Caption = "EmployOfTypeID";
            this.colEmployOfTypeID.FieldName = "StrEmployTypeID";
            this.colEmployOfTypeID.MinWidth = 31;
            this.colEmployOfTypeID.Name = "colEmployOfTypeID";
            this.colEmployOfTypeID.Width = 117;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.FieldName = "Bstatus";
            this.colStatus.MinWidth = 31;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 10;
            this.colStatus.Width = 117;
            // 
            // gvCmbRule
            // 
            this.gvCmbRule.AutoHeight = false;
            this.gvCmbRule.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gvCmbRule.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colID", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colName", "Chức vụ")});
            this.gvCmbRule.DisplayMember = "StrName";
            this.gvCmbRule.Name = "gvCmbRule";
            this.gvCmbRule.ValueMember = "StrID";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(184, 166);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(8, 8);
            this.progressBar1.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(166, 88);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(155, 22);
            this.txtID.TabIndex = 0;
            // 
            // lblMaNV
            // 
            this.lblMaNV.Location = new System.Drawing.Point(77, 94);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(37, 16);
            this.lblMaNV.TabIndex = 4;
            this.lblMaNV.Text = "Mã NV";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(166, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(77, 128);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(44, 17);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Họ Tên";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(166, 201);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(155, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(77, 166);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(31, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblSĐT
            // 
            this.lblSĐT.Location = new System.Drawing.Point(77, 204);
            this.lblSĐT.Name = "lblSĐT";
            this.lblSĐT.Size = new System.Drawing.Size(25, 16);
            this.lblSĐT.TabIndex = 4;
            this.lblSĐT.Text = "SĐT";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(494, 88);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(155, 22);
            this.txtIDCard.TabIndex = 4;
            // 
            // lblCMND
            // 
            this.lblCMND.Location = new System.Drawing.Point(405, 91);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(34, 16);
            this.lblCMND.TabIndex = 4;
            this.lblCMND.Text = "CMND";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(494, 125);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(155, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Location = new System.Drawing.Point(405, 128);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(56, 17);
            this.lblMatKhau.TabIndex = 4;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(780, 85);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(155, 22);
            this.txtSalary.TabIndex = 8;
            // 
            // lblLuong
            // 
            this.lblLuong.Location = new System.Drawing.Point(701, 88);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(35, 16);
            this.lblLuong.TabIndex = 4;
            this.lblLuong.Text = "Lương";
            // 
            // cmbRule
            // 
            this.cmbRule.Location = new System.Drawing.Point(494, 165);
            this.cmbRule.Name = "cmbRule";
            this.cmbRule.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbRule.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colID", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colName", "Chức Vụ")});
            this.cmbRule.Properties.DisplayMember = "StrName";
            this.cmbRule.Properties.NullText = "[Chưa chọn chức vụ]";
            this.cmbRule.Properties.ValueMember = "StrID";
            this.cmbRule.Size = new System.Drawing.Size(155, 22);
            this.cmbRule.TabIndex = 6;
            // 
            // lblChucVu
            // 
            this.lblChucVu.Location = new System.Drawing.Point(405, 168);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(53, 17);
            this.lblChucVu.TabIndex = 4;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Location = new System.Drawing.Point(405, 203);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(57, 16);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // dtBirthday
            // 
            this.dtBirthday.EditValue = null;
            this.dtBirthday.Location = new System.Drawing.Point(494, 201);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBirthday.Size = new System.Drawing.Size(155, 22);
            this.dtBirthday.TabIndex = 7;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Location = new System.Drawing.Point(701, 130);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(48, 17);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(793, 126);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(58, 21);
            this.radNam.TabIndex = 9;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(879, 128);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 21);
            this.radNu.TabIndex = 10;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // btnLoadNew
            // 
            this.btnLoadNew.Location = new System.Drawing.Point(729, 197);
            this.btnLoadNew.Name = "btnLoadNew";
            this.btnLoadNew.Size = new System.Drawing.Size(122, 29);
            this.btnLoadNew.TabIndex = 12;
            this.btnLoadNew.Text = "Làm mới";
            this.btnLoadNew.Click += new System.EventHandler(this.btnLoadNew_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(1035, 88);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(122, 29);
            this.btnAddEmp.TabIndex = 11;
            this.btnAddEmp.Tag = "";
            this.btnAddEmp.Text = "Thêm";
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(1035, 145);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 29);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Tag = "";
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1035, 197);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 29);
            this.btnSua.TabIndex = 11;
            this.btnSua.Tag = "";
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(879, 196);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(122, 29);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.Click += new System.EventHandler(this.btnLoadNew_Click);
            // 
            // frmManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 778);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnLoadNew);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.cmbRule);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblSĐT);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtIDCard);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gcEmployee);
            this.Name = "frmManageEmployees";
            this.Text = "5";
            this.Load += new System.EventHandler(this.frmGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvcmbRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCmbRule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDCard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBirthday.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.Repository.RepositoryItemFontEdit repositoryItemFontEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colRule;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvCmbRule;
        private DevExpress.XtraGrid.Columns.GridColumn colNumberPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private System.Windows.Forms.ProgressBar progressBar1;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDay;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPassWord;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCard;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployOfTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit gvcmbRules;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblMaNV;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl lblHoTen;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.LabelControl lblSĐT;
        private DevExpress.XtraEditors.TextEdit txtIDCard;
        private DevExpress.XtraEditors.LabelControl lblCMND;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lblMatKhau;
        private DevExpress.XtraEditors.TextEdit txtSalary;
        private DevExpress.XtraEditors.LabelControl lblLuong;
        private DevExpress.XtraEditors.LookUpEdit cmbRule;
        private DevExpress.XtraEditors.LabelControl lblChucVu;
        private DevExpress.XtraEditors.LabelControl lblNgaySinh;
        private DevExpress.XtraEditors.DateEdit dtBirthday;
        private DevExpress.XtraEditors.LabelControl lblGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private DevExpress.XtraEditors.SimpleButton btnLoadNew;
        private DevExpress.XtraEditors.SimpleButton btnAddEmp;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
    }
}