using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClinicAppointmentManager;

public class Appointment : INotifyPropertyChanged
{
    public const string StatusWaiting = "Chờ khám";
    public const string StatusInProgress = "Đang khám";
    public const string StatusCompleted = "Hoàn tất";
    public const string StatusCancelled = "Đã hủy";

    public static readonly string[] Statuses =
    [
        StatusWaiting,
        StatusInProgress,
        StatusCompleted,
        StatusCancelled
    ];

    public static readonly string[] Doctors =
    [
        "BS. Nguyễn Văn An",
        "BS. Trần Thị Bình",
        "BS. Lê Hoàng Cường",
        "BS. Phạm Minh Dung"
    ];

    private string _appointmentId = string.Empty;
    private string _patientName = string.Empty;
    private string _phoneNumber = string.Empty;
    private DateTime _appointmentDateTime = DateTime.Now;
    private string _doctor = string.Empty;
    private string _reason = string.Empty;
    private string _status = StatusWaiting;

    public string AppointmentId
    {
        get => _appointmentId;
        set => SetField(ref _appointmentId, value);
    }

    public string PatientName
    {
        get => _patientName;
        set => SetField(ref _patientName, value);
    }

    public string PhoneNumber
    {
        get => _phoneNumber;
        set => SetField(ref _phoneNumber, value);
    }

    public DateTime AppointmentDateTime
    {
        get => _appointmentDateTime;
        set => SetField(ref _appointmentDateTime, value);
    }

    public string Doctor
    {
        get => _doctor;
        set => SetField(ref _doctor, value);
    }

    public string Reason
    {
        get => _reason;
        set => SetField(ref _reason, value);
    }

    public string Status
    {
        get => _status;
        set => SetField(ref _status, value);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return;
        }

        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
