﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class UnitExchange
{
    public string GoodId { get; set; } = null!;

    public string UnitId { get; set; } = null!;

    public string BigUnitId { get; set; } = null!;

    public int ConvertUnit { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual Good Good { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;
}
