﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Form
{
    public string FormId { get; set; } = null!;

    public string? FormName { get; set; }

    public string? MenuId { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual ICollection<ControlForm> ControlForms { get; set; } = new List<ControlForm>();

    public virtual Menu? Menu { get; set; }

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();

    public virtual ICollection<Rpermission> Rpermissions { get; set; } = new List<Rpermission>();
}
