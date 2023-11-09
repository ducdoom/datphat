using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ListShelf
{
    public string ShelfId { get; set; } = null!;

    public string StockId { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public string ZoneId { get; set; } = null!;

    public string? SyncTime { get; set; }

    public virtual Stock Stock { get; set; } = null!;
}
