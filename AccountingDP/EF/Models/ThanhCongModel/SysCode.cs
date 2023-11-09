using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class SysCode
{
    public string CodeType { get; set; } = null!;

    public string LastNum { get; set; } = null!;

    public string ZoneId { get; set; } = null!;

    public string Ctype { get; set; } = null!;

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual Zone Zone { get; set; } = null!;
}
