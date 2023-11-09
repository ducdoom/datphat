using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Sysmarkdate
{
    public string ZoneId { get; set; } = null!;

    public string TransDate { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? Tablename { get; set; }

    public string? SyncTime { get; set; }

    public string Type { get; set; } = null!;
}
