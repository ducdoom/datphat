using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Unit
{
    public string UnitId { get; set; } = null!;

    public string? UnitName { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual ICollection<Good> Goods { get; set; } = new List<Good>();

    public virtual ICollection<UnitExchange> UnitExchanges { get; set; } = new List<UnitExchange>();
}
