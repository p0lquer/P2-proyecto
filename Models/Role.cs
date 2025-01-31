﻿using System;
using System.Collections.Generic;

namespace Proyecto.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
