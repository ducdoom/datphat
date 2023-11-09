using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class AttribGood
{
    public string GoodId { get; set; } = null!;

    public string? AttribCode { get; set; }

    public string? AttribValue { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual Attrib? AttribCodeNavigation { get; set; }

    public virtual Good Good { get; set; } = null!;
}
