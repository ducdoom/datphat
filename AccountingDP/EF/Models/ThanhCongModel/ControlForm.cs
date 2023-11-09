using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ControlForm
{
    public string ControlId { get; set; } = null!;

    public string FormId { get; set; } = null!;

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual Control Control { get; set; } = null!;

    public virtual Form Form { get; set; } = null!;
}
