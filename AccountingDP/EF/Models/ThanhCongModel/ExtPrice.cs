using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ExtPrice
{
    public string GoodId { get; set; } = null!;

    public string TypeId { get; set; } = null!;

    public decimal ExtPrice1 { get; set; }

    public decimal ExtPriceVat { get; set; }

    public string SynStatus { get; set; } = null!;

    public string? SyncTime { get; set; }

    public virtual Good Good { get; set; } = null!;
}
