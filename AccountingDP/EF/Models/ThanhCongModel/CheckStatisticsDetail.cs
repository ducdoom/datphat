﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class CheckStatisticsDetail
{
    public int ItemId { get; set; }

    public string TranId { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public string FullGoodId { get; set; } = null!;

    public decimal? AverPrice { get; set; }

    public decimal? AverPriceVat { get; set; }

    public int? StockQty { get; set; }

    public int? InvenQty { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual Good Good { get; set; } = null!;

    public virtual CheckStatistic Tran { get; set; } = null!;
}
