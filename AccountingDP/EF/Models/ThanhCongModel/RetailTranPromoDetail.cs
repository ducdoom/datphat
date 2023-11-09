﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class RetailTranPromoDetail
{
    public int ItemId { get; set; }

    public string TransactionId { get; set; } = null!;

    public string PromotionId { get; set; } = null!;

    public string? ZoneId { get; set; }

    public string FullGoodId { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public string? CustomerId { get; set; }

    public int? MainQty { get; set; }

    public string? UnitId { get; set; }

    public decimal? ExpPriceVat { get; set; }

    public decimal? ExpPrice { get; set; }

    public string? VatId { get; set; }

    public decimal? TotalVat { get; set; }

    public decimal? TotalExpPrice { get; set; }

    public decimal? TotalExpPriceVat { get; set; }

    /// <summary>
    /// có 4 loại 1 là hàng tặng hàng, 2 là hàng tặng tiền, 3 là đơn đạt một giá trị nào đó (PromoValues) tặng tiền, 4 là đơn đạt một giá trị nào đó (PromoValues) tặng hàng
    /// </summary>
    public string? PromotionType { get; set; }

    /// <summary>
    /// có các giá trị: KM theo Mã hàng, Ngành Hàng, Nhóm Hàng, Nhà cung cấp
    /// </summary>
    public string PromoTypeDetail { get; set; } = null!;

    public int? PromoValue { get; set; }

    public string PromoGoodId { get; set; } = null!;

    public int? Sort { get; set; }

    public string? TransDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? Time { get; set; }

    public string? SyncTime { get; set; }
}
