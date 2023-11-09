using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class DateCode
{
    public string ExpireDate { get; set; } = null!;

    public string ExpireCode { get; set; } = null!;

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
