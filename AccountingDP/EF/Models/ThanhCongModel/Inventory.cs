using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Inventory
{
    public string StockId { get; set; } = null!;

    public string ZoneId { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public string FullGoodId { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public int Quantity { get; set; }

    public decimal? AverPrice { get; set; }

    public decimal AverPriceVat { get; set; }

    public decimal? Totalvat { get; set; }

    public decimal Total { get; set; }

    public decimal? Totalamountvat { get; set; }
}
