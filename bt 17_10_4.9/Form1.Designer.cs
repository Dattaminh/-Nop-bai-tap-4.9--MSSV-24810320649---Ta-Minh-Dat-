namespace ClinicAppointmentManager;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        menuStrip = new MenuStrip();
        mnuFile = new ToolStripMenuItem();
        mnuExportCsv = new ToolStripMenuItem();
        mnuSeparator = new ToolStripSeparator();
        mnuExit = new ToolStripMenuItem();
        statusStrip = new StatusStrip();
        lblStatusCount = new ToolStripStatusLabel();
        errorProvider = new ErrorProvider(components);
        mainLayout = new TableLayoutPanel();
        grpInput = new GroupBox();
        inputLayout = new TableLayoutPanel();
        lblId = new Label();
        txtId = new TextBox();
        lblPatientName = new Label();
        txtPatientName = new TextBox();
        lblPhone = new Label();
        txtPhone = new TextBox();
        lblDateTime = new Label();
        dtpAppointment = new DateTimePicker();
        lblDoctor = new Label();
        cboDoctor = new ComboBox();
        lblStatus = new Label();
        cboStatus = new ComboBox();
        lblReason = new Label();
        txtReason = new TextBox();
        pnlButtons = new FlowLayoutPanel();
        btnAdd = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        grpList = new GroupBox();
        listLayout = new TableLayoutPanel();
        pnlFilter = new TableLayoutPanel();
        lblSearch = new Label();
        txtSearch = new TextBox();
        lblFilterDate = new Label();
        dtpFilterDate = new DateTimePicker();
        lblFilterStatus = new Label();
        cboFilterStatus = new ComboBox();
        dgvAppointments = new DataGridView();
        menuStrip.SuspendLayout();
        statusStrip.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        mainLayout.SuspendLayout();
        grpInput.SuspendLayout();
        inputLayout.SuspendLayout();
        pnlButtons.SuspendLayout();
        grpList.SuspendLayout();
        listLayout.SuspendLayout();
        pnlFilter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
        SuspendLayout();
        // 
        // menuStrip
        // 
        menuStrip.ImageScalingSize = new Size(20, 20);
        menuStrip.Items.AddRange(new ToolStripItem[] { mnuFile });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Padding = new Padding(7, 3, 0, 3);
        menuStrip.Size = new Size(1555, 30);
        menuStrip.TabIndex = 0;
        menuStrip.Text = "menuStrip";
        // 
        // mnuFile
        // 
        mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuExportCsv, mnuSeparator, mnuExit });
        mnuFile.Name = "mnuFile";
        mnuFile.Size = new Size(69, 24);
        mnuFile.Text = "&Tệp tin";
        // 
        // mnuExportCsv
        // 
        mnuExportCsv.Name = "mnuExportCsv";
        mnuExportCsv.ShortcutKeys = Keys.Control | Keys.E;
        mnuExportCsv.Size = new Size(382, 26);
        mnuExportCsv.Text = "&Xuất danh sách đang hiển thị (CSV)...";
        mnuExportCsv.Click += mnuExportCsv_Click;
        // 
        // mnuSeparator
        // 
        mnuSeparator.Name = "mnuSeparator";
        mnuSeparator.Size = new Size(379, 6);
        // 
        // mnuExit
        // 
        mnuExit.Name = "mnuExit";
        mnuExit.ShortcutKeys = Keys.Alt | Keys.F4;
        mnuExit.Size = new Size(382, 26);
        mnuExit.Text = "T&hoát";
        mnuExit.Click += mnuExit_Click;
        // 
        // statusStrip
        // 
        statusStrip.ImageScalingSize = new Size(20, 20);
        statusStrip.Items.AddRange(new ToolStripItem[] { lblStatusCount });
        statusStrip.Location = new Point(0, 907);
        statusStrip.Name = "statusStrip";
        statusStrip.Padding = new Padding(1, 0, 16, 0);
        statusStrip.Size = new Size(1555, 26);
        statusStrip.TabIndex = 2;
        statusStrip.Text = "statusStrip";
        // 
        // lblStatusCount
        // 
        lblStatusCount.Name = "lblStatusCount";
        lblStatusCount.Size = new Size(96, 20);
        lblStatusCount.Text = "Số lịch hẹn: 0";
        // 
        // errorProvider
        // 
        errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        errorProvider.ContainerControl = this;
        // 
        // mainLayout
        // 
        mainLayout.ColumnCount = 1;
        mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        mainLayout.Controls.Add(grpInput, 0, 0);
        mainLayout.Controls.Add(grpList, 0, 1);
        mainLayout.Dock = DockStyle.Fill;
        mainLayout.Location = new Point(0, 30);
        mainLayout.Margin = new Padding(3, 4, 3, 4);
        mainLayout.Name = "mainLayout";
        mainLayout.Padding = new Padding(9, 11, 9, 11);
        mainLayout.RowCount = 2;
        mainLayout.RowStyles.Add(new RowStyle());
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        mainLayout.Size = new Size(1555, 877);
        mainLayout.TabIndex = 1;
        // 
        // grpInput
        // 
        grpInput.AutoSize = true;
        grpInput.Controls.Add(inputLayout);
        grpInput.Dock = DockStyle.Fill;
        grpInput.Location = new Point(12, 15);
        grpInput.Margin = new Padding(3, 4, 3, 4);
        grpInput.Name = "grpInput";
        grpInput.Padding = new Padding(9, 11, 9, 11);
        grpInput.Size = new Size(1531, 346);
        grpInput.TabIndex = 0;
        grpInput.TabStop = false;
        grpInput.Text = "Thông tin lịch hẹn";
        // 
        // inputLayout
        // 
        inputLayout.AutoSize = true;
        inputLayout.ColumnCount = 4;
        inputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
        inputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        inputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
        inputLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        inputLayout.Controls.Add(lblId, 0, 0);
        inputLayout.Controls.Add(txtId, 1, 0);
        inputLayout.Controls.Add(lblPatientName, 2, 0);
        inputLayout.Controls.Add(txtPatientName, 3, 0);
        inputLayout.Controls.Add(lblPhone, 0, 1);
        inputLayout.Controls.Add(txtPhone, 1, 1);
        inputLayout.Controls.Add(lblDateTime, 2, 1);
        inputLayout.Controls.Add(dtpAppointment, 3, 1);
        inputLayout.Controls.Add(lblDoctor, 0, 2);
        inputLayout.Controls.Add(cboDoctor, 1, 2);
        inputLayout.Controls.Add(lblStatus, 2, 2);
        inputLayout.Controls.Add(cboStatus, 3, 2);
        inputLayout.Controls.Add(lblReason, 0, 3);
        inputLayout.Controls.Add(txtReason, 1, 3);
        inputLayout.Controls.Add(pnlButtons, 0, 4);
        inputLayout.Dock = DockStyle.Fill;
        inputLayout.Location = new Point(9, 31);
        inputLayout.Margin = new Padding(3, 4, 3, 4);
        inputLayout.Name = "inputLayout";
        inputLayout.RowCount = 5;
        inputLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        inputLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        inputLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        inputLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
        inputLayout.RowStyles.Add(new RowStyle());
        inputLayout.Size = new Size(1513, 304);
        inputLayout.TabIndex = 0;
        // 
        // lblId
        // 
        lblId.Anchor = AnchorStyles.Left;
        lblId.AutoSize = true;
        lblId.Location = new Point(3, 14);
        lblId.Name = "lblId";
        lblId.Size = new Size(88, 20);
        lblId.TabIndex = 0;
        lblId.Text = "Mã lịch hẹn:";
        // 
        // txtId
        // 
        txtId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtId.Location = new Point(140, 10);
        txtId.Margin = new Padding(3, 4, 3, 4);
        txtId.MaxLength = 20;
        txtId.Name = "txtId";
        txtId.Size = new Size(613, 27);
        txtId.TabIndex = 1;
        // 
        // lblPatientName
        // 
        lblPatientName.Anchor = AnchorStyles.Left;
        lblPatientName.AutoSize = true;
        lblPatientName.Location = new Point(759, 14);
        lblPatientName.Name = "lblPatientName";
        lblPatientName.Size = new Size(130, 20);
        lblPatientName.TabIndex = 2;
        lblPatientName.Text = "Họ tên bệnh nhân:";
        // 
        // txtPatientName
        // 
        txtPatientName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtPatientName.Location = new Point(896, 10);
        txtPatientName.Margin = new Padding(3, 4, 3, 4);
        txtPatientName.MaxLength = 100;
        txtPatientName.Name = "txtPatientName";
        txtPatientName.Size = new Size(614, 27);
        txtPatientName.TabIndex = 3;
        // 
        // lblPhone
        // 
        lblPhone.Anchor = AnchorStyles.Left;
        lblPhone.AutoSize = true;
        lblPhone.Location = new Point(3, 62);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new Size(100, 20);
        lblPhone.TabIndex = 4;
        lblPhone.Text = "Số điện thoại:";
        // 
        // txtPhone
        // 
        txtPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtPhone.Location = new Point(140, 58);
        txtPhone.Margin = new Padding(3, 4, 3, 4);
        txtPhone.MaxLength = 15;
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(613, 27);
        txtPhone.TabIndex = 5;
        // 
        // lblDateTime
        // 
        lblDateTime.Anchor = AnchorStyles.Left;
        lblDateTime.AutoSize = true;
        lblDateTime.Location = new Point(759, 62);
        lblDateTime.Name = "lblDateTime";
        lblDateTime.Size = new Size(101, 20);
        lblDateTime.TabIndex = 6;
        lblDateTime.Text = "Ngày giờ hẹn:";
        // 
        // dtpAppointment
        // 
        dtpAppointment.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        dtpAppointment.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpAppointment.Format = DateTimePickerFormat.Custom;
        dtpAppointment.Location = new Point(896, 58);
        dtpAppointment.Margin = new Padding(3, 4, 3, 4);
        dtpAppointment.Name = "dtpAppointment";
        dtpAppointment.ShowUpDown = true;
        dtpAppointment.Size = new Size(614, 27);
        dtpAppointment.TabIndex = 7;
        // 
        // lblDoctor
        // 
        lblDoctor.Anchor = AnchorStyles.Left;
        lblDoctor.AutoSize = true;
        lblDoctor.Location = new Point(3, 110);
        lblDoctor.Name = "lblDoctor";
        lblDoctor.Size = new Size(50, 20);
        lblDoctor.TabIndex = 8;
        lblDoctor.Text = "Bác sĩ:";
        // 
        // cboDoctor
        // 
        cboDoctor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cboDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDoctor.Location = new Point(140, 106);
        cboDoctor.Margin = new Padding(3, 4, 3, 4);
        cboDoctor.Name = "cboDoctor";
        cboDoctor.Size = new Size(613, 28);
        cboDoctor.TabIndex = 9;
        // 
        // lblStatus
        // 
        lblStatus.Anchor = AnchorStyles.Left;
        lblStatus.AutoSize = true;
        lblStatus.Location = new Point(759, 110);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(78, 20);
        lblStatus.TabIndex = 10;
        lblStatus.Text = "Trạng thái:";
        // 
        // cboStatus
        // 
        cboStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cboStatus.Location = new Point(896, 106);
        cboStatus.Margin = new Padding(3, 4, 3, 4);
        cboStatus.Name = "cboStatus";
        cboStatus.Size = new Size(614, 28);
        cboStatus.TabIndex = 11;
        // 
        // lblReason
        // 
        lblReason.AutoSize = true;
        lblReason.Location = new Point(3, 157);
        lblReason.Margin = new Padding(3, 13, 3, 0);
        lblReason.Name = "lblReason";
        lblReason.Size = new Size(87, 20);
        lblReason.TabIndex = 12;
        lblReason.Text = "Lý do khám:";
        // 
        // txtReason
        // 
        inputLayout.SetColumnSpan(txtReason, 3);
        txtReason.Dock = DockStyle.Fill;
        txtReason.Location = new Point(140, 148);
        txtReason.Margin = new Padding(3, 4, 3, 4);
        txtReason.Multiline = true;
        txtReason.Name = "txtReason";
        txtReason.ScrollBars = ScrollBars.Vertical;
        txtReason.Size = new Size(1370, 85);
        txtReason.TabIndex = 13;
        // 
        // pnlButtons
        // 
        pnlButtons.AutoSize = true;
        inputLayout.SetColumnSpan(pnlButtons, 4);
        pnlButtons.Controls.Add(btnAdd);
        pnlButtons.Controls.Add(btnUpdate);
        pnlButtons.Controls.Add(btnDelete);
        pnlButtons.Controls.Add(btnClear);
        pnlButtons.Dock = DockStyle.Fill;
        pnlButtons.Location = new Point(3, 241);
        pnlButtons.Margin = new Padding(3, 4, 3, 4);
        pnlButtons.Name = "pnlButtons";
        pnlButtons.Padding = new Padding(0, 8, 0, 0);
        pnlButtons.Size = new Size(1507, 59);
        pnlButtons.TabIndex = 14;
        pnlButtons.WrapContents = false;
        // 
        // btnAdd
        // 
        btnAdd.Location = new Point(3, 12);
        btnAdd.Margin = new Padding(3, 4, 3, 4);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(126, 43);
        btnAdd.TabIndex = 0;
        btnAdd.Text = "Thêm";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += btnAdd_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(135, 12);
        btnUpdate.Margin = new Padding(3, 4, 3, 4);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(126, 43);
        btnUpdate.TabIndex = 1;
        btnUpdate.Text = "Cập nhật";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(267, 12);
        btnDelete.Margin = new Padding(3, 4, 3, 4);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(126, 43);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Xóa";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new Point(399, 12);
        btnClear.Margin = new Padding(3, 4, 3, 4);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(126, 43);
        btnClear.TabIndex = 3;
        btnClear.Text = "Làm mới";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // grpList
        // 
        grpList.Controls.Add(listLayout);
        grpList.Dock = DockStyle.Fill;
        grpList.Location = new Point(12, 369);
        grpList.Margin = new Padding(3, 4, 3, 4);
        grpList.Name = "grpList";
        grpList.Padding = new Padding(9, 11, 9, 11);
        grpList.Size = new Size(1531, 493);
        grpList.TabIndex = 1;
        grpList.TabStop = false;
        grpList.Text = "Danh sách lịch hẹn";
        // 
        // listLayout
        // 
        listLayout.ColumnCount = 1;
        listLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        listLayout.Controls.Add(pnlFilter, 0, 0);
        listLayout.Controls.Add(dgvAppointments, 0, 1);
        listLayout.Dock = DockStyle.Fill;
        listLayout.Location = new Point(9, 31);
        listLayout.Margin = new Padding(3, 4, 3, 4);
        listLayout.Name = "listLayout";
        listLayout.RowCount = 2;
        listLayout.RowStyles.Add(new RowStyle());
        listLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        listLayout.Size = new Size(1513, 451);
        listLayout.TabIndex = 0;
        // 
        // pnlFilter
        // 
        pnlFilter.AutoSize = true;
        pnlFilter.ColumnCount = 6;
        pnlFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
        pnlFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
        pnlFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103F));
        pnlFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        pnlFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
        pnlFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        pnlFilter.Controls.Add(lblSearch, 0, 0);
        pnlFilter.Controls.Add(txtSearch, 1, 0);
        pnlFilter.Controls.Add(lblFilterDate, 2, 0);
        pnlFilter.Controls.Add(dtpFilterDate, 3, 0);
        pnlFilter.Controls.Add(lblFilterStatus, 4, 0);
        pnlFilter.Controls.Add(cboFilterStatus, 5, 0);
        pnlFilter.Dock = DockStyle.Fill;
        pnlFilter.Location = new Point(3, 4);
        pnlFilter.Margin = new Padding(3, 4, 3, 4);
        pnlFilter.Name = "pnlFilter";
        pnlFilter.Padding = new Padding(0, 0, 0, 8);
        pnlFilter.RowCount = 1;
        pnlFilter.RowStyles.Add(new RowStyle());
        pnlFilter.Size = new Size(1507, 44);
        pnlFilter.TabIndex = 0;
        // 
        // lblSearch
        // 
        lblSearch.Anchor = AnchorStyles.Left;
        lblSearch.AutoSize = true;
        lblSearch.Location = new Point(3, 8);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(73, 20);
        lblSearch.TabIndex = 0;
        lblSearch.Text = "Tìm kiếm:";
        // 
        // txtSearch
        // 
        txtSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtSearch.Location = new Point(83, 4);
        txtSearch.Margin = new Padding(3, 4, 3, 4);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Tên bệnh nhân hoặc số điện thoại";
        txtSearch.Size = new Size(487, 27);
        txtSearch.TabIndex = 1;
        txtSearch.TextChanged += FilterChanged;
        // 
        // lblFilterDate
        // 
        lblFilterDate.Anchor = AnchorStyles.Left;
        lblFilterDate.AutoSize = true;
        lblFilterDate.Location = new Point(576, 8);
        lblFilterDate.Name = "lblFilterDate";
        lblFilterDate.Size = new Size(75, 20);
        lblFilterDate.TabIndex = 2;
        lblFilterDate.Text = "Ngày hẹn:";
        // 
        // dtpFilterDate
        // 
        dtpFilterDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        dtpFilterDate.Format = DateTimePickerFormat.Short;
        dtpFilterDate.Location = new Point(679, 4);
        dtpFilterDate.Margin = new Padding(3, 4, 3, 4);
        dtpFilterDate.Name = "dtpFilterDate";
        dtpFilterDate.ShowCheckBox = true;
        dtpFilterDate.Size = new Size(363, 27);
        dtpFilterDate.TabIndex = 3;
        dtpFilterDate.ValueChanged += FilterChanged;
        // 
        // lblFilterStatus
        // 
        lblFilterStatus.Anchor = AnchorStyles.Left;
        lblFilterStatus.AutoSize = true;
        lblFilterStatus.Location = new Point(1048, 8);
        lblFilterStatus.Name = "lblFilterStatus";
        lblFilterStatus.Size = new Size(78, 20);
        lblFilterStatus.TabIndex = 4;
        lblFilterStatus.Text = "Trạng thái:";
        // 
        // cboFilterStatus
        // 
        cboFilterStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        cboFilterStatus.Location = new Point(1139, 4);
        cboFilterStatus.Margin = new Padding(3, 4, 3, 4);
        cboFilterStatus.Name = "cboFilterStatus";
        cboFilterStatus.Size = new Size(365, 28);
        cboFilterStatus.TabIndex = 5;
        cboFilterStatus.SelectedIndexChanged += FilterChanged;
        // 
        // dgvAppointments
        // 
        dgvAppointments.AllowUserToAddRows = false;
        dgvAppointments.AllowUserToDeleteRows = false;
        dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvAppointments.BackgroundColor = SystemColors.Window;
        dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvAppointments.Dock = DockStyle.Fill;
        dgvAppointments.Location = new Point(3, 56);
        dgvAppointments.Margin = new Padding(3, 4, 3, 4);
        dgvAppointments.MultiSelect = false;
        dgvAppointments.Name = "dgvAppointments";
        dgvAppointments.ReadOnly = true;
        dgvAppointments.RowHeadersVisible = false;
        dgvAppointments.RowHeadersWidth = 51;
        dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAppointments.Size = new Size(1507, 391);
        dgvAppointments.TabIndex = 1;
        dgvAppointments.SelectionChanged += dgvAppointments_SelectionChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1555, 933);
        Controls.Add(mainLayout);
        Controls.Add(statusStrip);
        Controls.Add(menuStrip);
        MainMenuStrip = menuStrip;
        Margin = new Padding(3, 4, 3, 4);
        MinimumSize = new Size(1026, 784);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Clinic Appointment Manager - Quản lý lịch hẹn phòng khám";
        Load += Form1_Load;
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        mainLayout.ResumeLayout(false);
        mainLayout.PerformLayout();
        grpInput.ResumeLayout(false);
        grpInput.PerformLayout();
        inputLayout.ResumeLayout(false);
        inputLayout.PerformLayout();
        pnlButtons.ResumeLayout(false);
        grpList.ResumeLayout(false);
        listLayout.ResumeLayout(false);
        listLayout.PerformLayout();
        pnlFilter.ResumeLayout(false);
        pnlFilter.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip;
    private ToolStripMenuItem mnuFile;
    private ToolStripMenuItem mnuExportCsv;
    private ToolStripSeparator mnuSeparator;
    private ToolStripMenuItem mnuExit;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel lblStatusCount;
    private ErrorProvider errorProvider;
    private TableLayoutPanel mainLayout;
    private GroupBox grpInput;
    private TableLayoutPanel inputLayout;
    private Label lblId;
    private TextBox txtId;
    private Label lblPatientName;
    private TextBox txtPatientName;
    private Label lblPhone;
    private TextBox txtPhone;
    private Label lblDateTime;
    private DateTimePicker dtpAppointment;
    private Label lblDoctor;
    private ComboBox cboDoctor;
    private Label lblStatus;
    private ComboBox cboStatus;
    private Label lblReason;
    private TextBox txtReason;
    private FlowLayoutPanel pnlButtons;
    private Button btnAdd;
    private Button btnUpdate;
    private Button btnDelete;
    private Button btnClear;
    private GroupBox grpList;
    private TableLayoutPanel listLayout;
    private TableLayoutPanel pnlFilter;
    private Label lblSearch;
    private TextBox txtSearch;
    private Label lblFilterDate;
    private DateTimePicker dtpFilterDate;
    private Label lblFilterStatus;
    private ComboBox cboFilterStatus;
    private DataGridView dgvAppointments;
    private DataGridViewTextBoxColumn colId;
    private DataGridViewTextBoxColumn colPatientName;
    private DataGridViewTextBoxColumn colPhone;
    private DataGridViewTextBoxColumn colDateTime;
    private DataGridViewTextBoxColumn colDoctor;
    private DataGridViewTextBoxColumn colReason;
    private DataGridViewTextBoxColumn colStatus;
}
