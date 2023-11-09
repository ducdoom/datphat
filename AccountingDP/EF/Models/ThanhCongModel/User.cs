﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Password2 { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Description { get; set; }

    public string? Idcard { get; set; }

    public bool? Enable { get; set; }

    public string? Theme { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? LogOnStation { get; set; }

    public string? SyncTime { get; set; }

    public virtual ICollection<Mpermission> Mpermissions { get; set; } = new List<Mpermission>();

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    public virtual ICollection<UserStation> UserStations { get; set; } = new List<UserStation>();

    public virtual ICollection<UserZone> UserZones { get; set; } = new List<UserZone>();
}
