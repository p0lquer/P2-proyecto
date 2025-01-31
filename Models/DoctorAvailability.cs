using System;
using System.Collections.Generic;

namespace Proyecto.Models;

public partial class DoctorAvailability
{
    public int AvailabilityId { get; set; }

    public int DoctorId { get; set; }

    public DateOnly AvailableDate { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public virtual Doctor Doctor { get; set; } = null!;
}
