﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class CheckStatistic
{
    public string TransactionId { get; set; } = null!;

    public string? StockId { get; set; }

    public string? StationId { get; set; }

    public string? Condition { get; set; }

    public string? Note { get; set; }

    public bool? AllowTran { get; set; }

    public string? RealFile { get; set; }

    public string? TransDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual ICollection<CheckStatisticsDetail> CheckStatisticsDetails { get; set; } = new List<CheckStatisticsDetail>();
}
