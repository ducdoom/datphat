﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class TransByPacket
{
    public string TransactionId { get; set; } = null!;

    public string FullGoodId { get; set; } = null!;

    public string? GoodId { get; set; }

    public string PacketId { get; set; } = null!;

    public int? Quantity { get; set; }

    public int? PacketQuantity { get; set; }

    public decimal? ExpPrice { get; set; }

    public decimal? ExpPriceVat { get; set; }

    public decimal? Discount { get; set; }

    public string BigUnitId { get; set; } = null!;

    public string? UnitId { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? TotalExpPrice { get; set; }

    public decimal? TotalExpPriceVat { get; set; }

    public string Status { get; set; } = null!;

    public string SynStatus { get; set; } = null!;

    public string? SyncTime { get; set; }

    public virtual Packet Packet { get; set; } = null!;
}
