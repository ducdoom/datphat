using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class DoubleCode
{
    public string GoodId { get; set; } = null!;

    public string Barcode { get; set; } = null!;

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual Good Good { get; set; } = null!;
}
