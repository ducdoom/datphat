﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ProGroup
{
    public string GroupId { get; set; } = null!;

    public string PgroupId { get; set; } = null!;

    public string? BranchId { get; set; }

    public string? GroupName { get; set; }

    public string? Note { get; set; }

    public decimal? MinPercentWhole { get; set; }

    public decimal? MaxPercentWhole { get; set; }

    public decimal? MinPercentRetailPrice { get; set; }

    public decimal? MaxPercentRetailPrice { get; set; }

    public decimal? PercentWhole { get; set; }

    public decimal? PercentRetailPrice { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual ICollection<Good> Goods { get; set; } = new List<Good>();
}
