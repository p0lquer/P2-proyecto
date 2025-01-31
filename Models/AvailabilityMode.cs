using System;
using System.Collections.Generic;

namespace Proyecto.Models;

public partial class AvailabilityMode
{
    public short SavailabilityModeId { get; set; }

    public string AvailabilityMode1 { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
}
