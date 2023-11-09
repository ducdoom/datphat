using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class AttribRange
{
    public string AttribCode { get; set; } = null!;

    public string AttribValue { get; set; } = null!;

    public string? Condition { get; set; }

    public string? AttribDisplay { get; set; }

    public string? SyncTime { get; set; }

    public virtual Attrib AttribCodeNavigation { get; set; } = null!;
}
