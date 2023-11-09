﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class OrderDetail
{
    public string OrderId { get; set; } = null!;

    public string StockId { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public int? OrderQuantity { get; set; }

    public int? ReceivedQuantity { get; set; }

    public string BigUnitId { get; set; } = null!;

    public string? UnitId { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? BranchId { get; set; }

    public string? GroupId { get; set; }

    public decimal? ImpPrice { get; set; }

    public decimal? ImpPriceVat { get; set; }

    public string? VatId { get; set; }

    public decimal? TotalImpPrice { get; set; }

    public decimal? TotalImpPriceVat { get; set; }

    public int? DiscountRate { get; set; }

    public decimal? DiscountAmount { get; set; }

    public string? TransDate { get; set; }

    public string? CheckedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? Time { get; set; }

    public string? SyncTime { get; set; }
}
