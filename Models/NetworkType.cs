using System;
using System.Collections.Generic;

namespace Proyecto.Models;

public partial class NetworkType
{
    public int NetworkTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<InsuranceProvider> InsuranceProviders { get; set; } = new List<InsuranceProvider>();
}
