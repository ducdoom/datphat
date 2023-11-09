using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ListScale
{
    public string Itemcode { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public int? Weight { get; set; }

    public decimal? ExpPrice { get; set; }

    public decimal? ExpPriceVat { get; set; }

    public bool? ScaleType { get; set; }

    public string? StorageTemp { get; set; }

    public int? UseIn { get; set; }

    public string? SyncTime { get; set; }

    public virtual Good Good { get; set; } = null!;
}
