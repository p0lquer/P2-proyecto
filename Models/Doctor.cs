using System;
using System.Collections.Generic;

namespace Proyecto.Models;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public short SpecialtyId { get; set; }

    public string LicenseNumber { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public int YearsOfExperience { get; set; }

    public string Education { get; set; } = null!;

    public string? Bio { get; set; }

    public decimal? ConsultationFee { get; set; }

    public string? ClinicAddress { get; set; }

    public short? AvailabilityModeId { get; set; }

    public DateOnly LicenseExpirationDate { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual AvailabilityMode? AvailabilityMode { get; set; }

    public virtual ICollection<DoctorAvailability> DoctorAvailabilities { get; set; } = new List<DoctorAvailability>();

    public virtual User DoctorNavigation { get; set; } = null!;

    public virtual ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();

    public virtual Specialty Specialty { get; set; } = null!;
}
