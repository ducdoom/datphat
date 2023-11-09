using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ListVat
{
    public string VatId { get; set; } = null!;

    public int VatValue { get; set; }

    public string VatName { get; set; } = null!;

    public string? SyncTime { get; set; }

    public virtual ICollection<Good> Goods { get; set; } = new List<Good>();
}
