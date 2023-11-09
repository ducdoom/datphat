﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Zone
{
    public string ParentId { get; set; } = null!;

    public string ZoneId { get; set; } = null!;

    public string? ZoneName { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual ICollection<HisExpPrice> HisExpPrices { get; set; } = new List<HisExpPrice>();

    public virtual ICollection<HisImpPrice> HisImpPrices { get; set; } = new List<HisImpPrice>();

    public virtual ICollection<Mpermission> Mpermissions { get; set; } = new List<Mpermission>();

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();

    public virtual ICollection<Price> Prices { get; set; } = new List<Price>();

    public virtual ICollection<QtyMinMaxDetail> QtyMinMaxDetails { get; set; } = new List<QtyMinMaxDetail>();

    public virtual ICollection<RetailTran> RetailTrans { get; set; } = new List<RetailTran>();

    public virtual ICollection<RetailTransTemp> RetailTransTemps { get; set; } = new List<RetailTransTemp>();

    public virtual ICollection<Rmpermission> Rmpermissions { get; set; } = new List<Rmpermission>();

    public virtual ICollection<RoleZone> RoleZones { get; set; } = new List<RoleZone>();

    public virtual ICollection<Rpermission> Rpermissions { get; set; } = new List<Rpermission>();

    public virtual ICollection<Server> Servers { get; set; } = new List<Server>();

    public virtual ICollection<Station> Stations { get; set; } = new List<Station>();

    public virtual ICollection<Stock> Stocks { get; set; } = new List<Stock>();

    public virtual ICollection<SysCode> SysCodes { get; set; } = new List<SysCode>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual ICollection<UserZone> UserZones { get; set; } = new List<UserZone>();
}
