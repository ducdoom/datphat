using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Systranscutdate
{
    public string ZoneId { get; set; } = null!;

    public string TransCut { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? FromDate { get; set; }

    public string? ToDate { get; set; }

    public string? SyncTime { get; set; }
}
