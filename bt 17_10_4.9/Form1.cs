using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace ClinicAppointmentManager;

public partial class Form1 : Form
{
    private static readonly Regex PhoneRegex = new(@"^(0|\+84)[3-9]\d{8}$", RegexOptions.Compiled);

    private readonly BindingList<Appointment> _allAppointments = [];
    private readonly BindingSource _bindingSource = new();
    private bool _suppressSelection;
    private bool _isLoading;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        _isLoading = true;

        cboDoctor.Items.AddRange(Appointment.Doctors);
        cboStatus.Items.AddRange(Appointment.Statuses);
        cboFilterStatus.Items.Add("Tất cả");
        cboFilterStatus.Items.AddRange(Appointment.Statuses);
        cboDoctor.SelectedIndex = 0;
        cboStatus.SelectedIndex = 0;
        cboFilterStatus.SelectedIndex = 0;

        dtpAppointment.Value = DateTime.Now.AddHours(1);
        dtpFilterDate.Value = DateTime.Today;
        dtpFilterDate.Checked = true;

        SeedSampleData();

        dgvAppointments.AutoGenerateColumns = false;
        dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        _bindingSource.DataSource = new BindingList<Appointment>();
        dgvAppointments.DataSource = _bindingSource;

        _isLoading = false;
        ApplyFilter();
        PrepareNewEntry();
    }

    private void SeedSampleData()
    {
        DateTime now = DateTime.Now;
        _allAppointments.Add(new Appointment
        {
            AppointmentId = "LH001",
            PatientName = "Nguyễn Thị Hoa",
            PhoneNumber = "0912345678",
            AppointmentDateTime = now.AddHours(1),
            Doctor = Appointment.Doctors[0],
            Reason = "Khám tổng quát",
            Status = Appointment.StatusWaiting
        });
        _allAppointments.Add(new Appointment
        {
            AppointmentId = "LH002",
            PatientName = "Trần Văn Nam",
            PhoneNumber = "0987654321",
            AppointmentDateTime = now.AddHours(2).AddMinutes(15),
            Doctor = Appointment.Doctors[1],
            Reason = "Đau họng, sốt nhẹ",
            Status = Appointment.StatusInProgress
        });
        _allAppointments.Add(new Appointment
        {
            AppointmentId = "LH003",
            PatientName = "Lê Minh Châu",
            PhoneNumber = "0905123456",
            AppointmentDateTime = now.AddHours(3),
            Doctor = Appointment.Doctors[2],
            Reason = "Tái khám huyết áp",
            Status = Appointment.StatusCompleted
        });
        _allAppointments.Add(new Appointment
        {
            AppointmentId = "LH004",
            PatientName = "Phạm Quốc Huy",
            PhoneNumber = "0938123456",
            AppointmentDateTime = DateTime.Today.AddDays(1).AddHours(8).AddMinutes(30),
            Doctor = Appointment.Doctors[3],
            Reason = "Đau lưng kéo dài",
            Status = Appointment.StatusWaiting
        });
    }

    private void FilterChanged(object? sender, EventArgs e)
    {
        if (_isLoading)
        {
            return;
        }

        ApplyFilter();
    }

    private void ApplyFilter()
    {
        string keyword = txtSearch.Text.Trim();
        bool filterByDate = dtpFilterDate.Checked;
        DateTime filterDate = dtpFilterDate.Value.Date;
        string status = cboFilterStatus.SelectedItem?.ToString() ?? "Tất cả";

        IEnumerable<Appointment> query = _allAppointments;

        if (!string.IsNullOrEmpty(keyword))
        {
            query = query.Where(a =>
                a.PatientName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                a.PhoneNumber.Contains(keyword, StringComparison.OrdinalIgnoreCase));
        }

        if (filterByDate)
        {
            query = query.Where(a => a.AppointmentDateTime.Date == filterDate);
        }

        if (!string.Equals(status, "Tất cả", StringComparison.OrdinalIgnoreCase))
        {
            query = query.Where(a => a.Status == status);
        }

        var filtered = new BindingList<Appointment>(query.ToList());

        _suppressSelection = true;
        string? selectedId = GetSelectedAppointment()?.AppointmentId;
        _bindingSource.DataSource = filtered;
        RestoreSelection(selectedId);
        _suppressSelection = false;

        UpdateStatusBar(filtered.Count);
    }

    private void UpdateStatusBar(int visibleCount)
    {
        lblStatusCount.Text = $"Số lịch hẹn: {visibleCount} (tổng {_allAppointments.Count})";
    }

    private void dgvAppointments_SelectionChanged(object? sender, EventArgs e)
    {
        if (_suppressSelection || _isLoading)
        {
            return;
        }

        Appointment? selected = GetSelectedAppointment();
        if (selected is not null)
        {
            FillForm(selected);
        }
    }

    private Appointment? GetSelectedAppointment()
    {
        return dgvAppointments.CurrentRow?.DataBoundItem as Appointment;
    }

    private void FillForm(Appointment appointment)
    {
        txtId.Text = appointment.AppointmentId;
        txtPatientName.Text = appointment.PatientName;
        txtPhone.Text = appointment.PhoneNumber;
        dtpAppointment.Value = appointment.AppointmentDateTime;
        cboDoctor.SelectedItem = appointment.Doctor;
        cboStatus.SelectedItem = appointment.Status;
        txtReason.Text = appointment.Reason;
        errorProvider.Clear();
    }

    private void btnAdd_Click(object? sender, EventArgs e)
    {
        if (!ValidateInput(excludeId: null))
        {
            return;
        }

        DialogResult confirm = MessageBox.Show(
            "Bạn có chắc muốn thêm lịch hẹn này?",
            "Xác nhận thêm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes)
        {
            return;
        }

        var appointment = ReadForm();
        _allAppointments.Add(appointment);
        ApplyFilter();
        SelectById(appointment.AppointmentId);
        MessageBox.Show("Đã thêm lịch hẹn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnUpdate_Click(object? sender, EventArgs e)
    {
        Appointment? selected = GetSelectedAppointment();
        if (selected is null)
        {
            MessageBox.Show("Hãy chọn một lịch hẹn trên danh sách để cập nhật.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (!ValidateInput(excludeId: selected.AppointmentId))
        {
            return;
        }

        DialogResult confirm = MessageBox.Show(
            $"Bạn có chắc muốn cập nhật lịch hẹn {selected.AppointmentId}?",
            "Xác nhận cập nhật",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (confirm != DialogResult.Yes)
        {
            return;
        }

        Appointment edited = ReadForm();
        selected.AppointmentId = edited.AppointmentId;
        selected.PatientName = edited.PatientName;
        selected.PhoneNumber = edited.PhoneNumber;
        selected.AppointmentDateTime = edited.AppointmentDateTime;
        selected.Doctor = edited.Doctor;
        selected.Reason = edited.Reason;
        selected.Status = edited.Status;

        ApplyFilter();
        SelectById(selected.AppointmentId);
        MessageBox.Show("Đã cập nhật lịch hẹn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnDelete_Click(object? sender, EventArgs e)
    {
        Appointment? selected = GetSelectedAppointment();
        if (selected is null)
        {
            MessageBox.Show("Hãy chọn một lịch hẹn trên danh sách để xóa.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        DialogResult confirm = MessageBox.Show(
            $"Bạn có chắc muốn xóa lịch hẹn {selected.AppointmentId} - {selected.PatientName}?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (confirm != DialogResult.Yes)
        {
            return;
        }

        _allAppointments.Remove(selected);
        ApplyFilter();
        PrepareNewEntry();
        MessageBox.Show("Đã xóa lịch hẹn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnClear_Click(object? sender, EventArgs e)
    {
        PrepareNewEntry();
    }

    private void PrepareNewEntry()
    {
        _suppressSelection = true;
        dgvAppointments.ClearSelection();
        dgvAppointments.CurrentCell = null;
        _suppressSelection = false;

        errorProvider.Clear();
        txtId.Text = SuggestNextId();
        txtPatientName.Clear();
        txtPhone.Clear();
        txtReason.Clear();
        dtpAppointment.Value = DateTime.Now.AddHours(1);
        if (cboDoctor.Items.Count > 0)
        {
            cboDoctor.SelectedIndex = 0;
        }

        if (cboStatus.Items.Count > 0)
        {
            cboStatus.SelectedIndex = 0;
        }

        txtPatientName.Focus();
    }

    private string SuggestNextId()
    {
        int max = 0;
        foreach (Appointment appointment in _allAppointments)
        {
            string digits = new(appointment.AppointmentId.Where(char.IsDigit).ToArray());
            if (int.TryParse(digits, out int value) && value > max)
            {
                max = value;
            }
        }

        return $"LH{(max + 1):000}";
    }

    private Appointment ReadForm()
    {
        return new Appointment
        {
            AppointmentId = txtId.Text.Trim(),
            PatientName = txtPatientName.Text.Trim(),
            PhoneNumber = NormalizePhone(txtPhone.Text),
            AppointmentDateTime = dtpAppointment.Value,
            Doctor = cboDoctor.SelectedItem?.ToString() ?? string.Empty,
            Reason = txtReason.Text.Trim(),
            Status = cboStatus.SelectedItem?.ToString() ?? Appointment.StatusWaiting
        };
    }

    private bool ValidateInput(string? excludeId)
    {
        errorProvider.Clear();
        bool isValid = true;

        string id = txtId.Text.Trim();
        string name = txtPatientName.Text.Trim();
        string phone = NormalizePhone(txtPhone.Text);
        string reason = txtReason.Text.Trim();

        if (string.IsNullOrWhiteSpace(id))
        {
            errorProvider.SetError(txtId, "Mã lịch hẹn là bắt buộc.");
            isValid = false;
        }
        else if (_allAppointments.Any(a =>
                     !string.Equals(a.AppointmentId, excludeId, StringComparison.OrdinalIgnoreCase) &&
                     a.AppointmentId.Equals(id, StringComparison.OrdinalIgnoreCase)))
        {
            errorProvider.SetError(txtId, "Mã lịch hẹn đã tồn tại.");
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            errorProvider.SetError(txtPatientName, "Họ tên bệnh nhân là bắt buộc.");
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(phone))
        {
            errorProvider.SetError(txtPhone, "Số điện thoại là bắt buộc.");
            isValid = false;
        }
        else if (!PhoneRegex.IsMatch(phone))
        {
            errorProvider.SetError(txtPhone, "Số điện thoại không hợp lệ (0xxxxxxxxx hoặc +84xxxxxxxxx).");
            isValid = false;
        }

        if (string.IsNullOrWhiteSpace(reason))
        {
            errorProvider.SetError(txtReason, "Lý do khám là bắt buộc.");
            isValid = false;
        }

        if (dtpAppointment.Value < DateTime.Now)
        {
            errorProvider.SetError(dtpAppointment, "Ngày hẹn không được nằm trong quá khứ.");
            isValid = false;
        }

        if (cboDoctor.SelectedIndex < 0)
        {
            errorProvider.SetError(cboDoctor, "Hãy chọn bác sĩ.");
            isValid = false;
        }

        if (cboStatus.SelectedIndex < 0)
        {
            errorProvider.SetError(cboStatus, "Hãy chọn trạng thái.");
            isValid = false;
        }

        return isValid;
    }

    private static string NormalizePhone(string? phone)
    {
        if (string.IsNullOrWhiteSpace(phone))
        {
            return string.Empty;
        }

        return phone.Replace(" ", string.Empty).Replace(".", string.Empty).Replace("-", string.Empty);
    }

    private void SelectById(string appointmentId)
    {
        _suppressSelection = true;
        foreach (DataGridViewRow row in dgvAppointments.Rows)
        {
            if (row.DataBoundItem is Appointment appointment &&
                appointment.AppointmentId.Equals(appointmentId, StringComparison.OrdinalIgnoreCase))
            {
                row.Selected = true;
                dgvAppointments.CurrentCell = row.Cells[0];
                FillForm(appointment);
                break;
            }
        }

        _suppressSelection = false;
    }

    private void RestoreSelection(string? appointmentId)
    {
        if (string.IsNullOrEmpty(appointmentId) || dgvAppointments.Rows.Count == 0)
        {
            dgvAppointments.ClearSelection();
            return;
        }

        foreach (DataGridViewRow row in dgvAppointments.Rows)
        {
            if (row.DataBoundItem is Appointment appointment &&
                appointment.AppointmentId.Equals(appointmentId, StringComparison.OrdinalIgnoreCase))
            {
                row.Selected = true;
                if (row.Cells.Count > 0 && row.Cells[0].Visible)
                {
                    dgvAppointments.CurrentCell = row.Cells[0];
                }

                return;
            }
        }

        dgvAppointments.ClearSelection();
    }

    private void mnuExportCsv_Click(object? sender, EventArgs e)
    {
        if (_bindingSource.Count == 0)
        {
            MessageBox.Show("Không có lịch hẹn nào đang hiển thị để xuất.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        using var dialog = new SaveFileDialog
        {
            Title = "Xuất danh sách lịch hẹn",
            Filter = "CSV (*.csv)|*.csv",
            FileName = $"LichHen_{DateTime.Now:yyyyMMdd_HHmm}.csv",
            OverwritePrompt = true
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            ExportVisibleToCsv(dialog.FileName);
            MessageBox.Show("Xuất CSV thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Không thể xuất CSV.\n{ex.Message}", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ExportVisibleToCsv(string fileName)
    {
        using var writer = new StreamWriter(fileName, false, new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));
        writer.WriteLine("Mã lịch hẹn,Họ tên bệnh nhân,Số điện thoại,Ngày giờ hẹn,Bác sĩ,Lý do khám,Trạng thái");

        foreach (object item in _bindingSource.List)
        {
            if (item is not Appointment appointment)
            {
                continue;
            }

            writer.WriteLine(string.Join(",",
                ToCsv(appointment.AppointmentId),
                ToCsv(appointment.PatientName),
                ToCsv(appointment.PhoneNumber),
                ToCsv(appointment.AppointmentDateTime.ToString("dd/MM/yyyy HH:mm")),
                ToCsv(appointment.Doctor),
                ToCsv(appointment.Reason),
                ToCsv(appointment.Status)));
        }
    }

    private static string ToCsv(string? value)
    {
        value ??= string.Empty;
        if (value.Contains(',') || value.Contains('"') || value.Contains('\n') || value.Contains('\r'))
        {
            return $"\"{value.Replace("\"", "\"\"")}\"";
        }

        return value;
    }

    private void mnuExit_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
