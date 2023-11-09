﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class PacketDetail
{
    public int ItemId { get; set; }

    public string PacketId { get; set; } = null!;

    public string FullGoodId { get; set; } = null!;

    public string? GoodId { get; set; }

    public int? Quantity { get; set; }

    public string BigUnitId { get; set; } = null!;

    public string UnitId { get; set; } = null!;

    public decimal? ExchangeRate { get; set; }

    public decimal? RetailPrice { get; set; }

    public decimal? RetailPriceVat { get; set; }

    public decimal? Discount { get; set; }

    public decimal? WholesalePrice { get; set; }

    public decimal? WholesalePriceVat { get; set; }

    public decimal? WholesaleDiscount { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual Packet Packet { get; set; } = null!;
}
