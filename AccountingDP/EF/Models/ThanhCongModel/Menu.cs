﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Menu
{
    public string MenuId { get; set; } = null!;

    public string? MenuName { get; set; }

    public string? Icon { get; set; }

    public string? PmenuId { get; set; }

    public int? Sort { get; set; }

    public string? Note { get; set; }

    public string? SyncTime { get; set; }

    public virtual ICollection<Form> Forms { get; set; } = new List<Form>();

    public virtual ICollection<Mpermission> Mpermissions { get; set; } = new List<Mpermission>();

    public virtual ICollection<Rmpermission> Rmpermissions { get; set; } = new List<Rmpermission>();
}
