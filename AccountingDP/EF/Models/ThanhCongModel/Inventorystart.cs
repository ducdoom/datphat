﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Inventorystart
{
    public string StockId { get; set; } = null!;

    public string ZoneId { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public string FullGoodId { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string? BranchId { get; set; }

    public string? GroupId { get; set; }

    public int Quantity { get; set; }

    public decimal? AverPrice { get; set; }

    public decimal AverPriceVat { get; set; }

    public decimal Total { get; set; }

    public decimal? Totalvat { get; set; }

    public decimal? Totalamountvat { get; set; }

    public string Datestart { get; set; } = null!;

    public string? SyncTime { get; set; }
}
