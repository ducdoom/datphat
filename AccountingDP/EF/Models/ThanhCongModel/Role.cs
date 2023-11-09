﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Role
{
    public string RoleId { get; set; } = null!;

    public string? RoleName { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual ICollection<Rmpermission> Rmpermissions { get; set; } = new List<Rmpermission>();

    public virtual ICollection<RoleZone> RoleZones { get; set; } = new List<RoleZone>();

    public virtual ICollection<Rpermission> Rpermissions { get; set; } = new List<Rpermission>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
