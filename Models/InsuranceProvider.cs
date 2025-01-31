using System;
using System.Collections.Generic;

namespace Proyecto.Models;

public partial class InsuranceProvider
{
    public int InsuranceProviderId { get; set; }

    public string Name { get; set; } = null!;

    public string ContactNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Website { get; set; }

    public string Address { get; set; } = null!;

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? ZipCode { get; set; }

    public string CoverageDetails { get; set; } = null!;

    public string? LogoUrl { get; set; }

    public bool IsPreferred { get; set; }

    public int NetworkTypeId { get; set; }

    public string? CustomerSupportContact { get; set; }

    public string? AcceptedRegions { get; set; }

    public decimal? MaxCoverageAmount { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool IsActive { get; set; }

    public virtual NetworkType NetworkType { get; set; } = null!;

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
