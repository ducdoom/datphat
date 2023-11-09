﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class RetailTranDetail
{
    public int ItemId { get; set; }

    public Guid TransDetailId { get; set; }

    public string TransactionId { get; set; } = null!;

    public string AuTranId { get; set; } = null!;

    public string? ZoneId { get; set; }

    public string FullGoodId { get; set; } = null!;

    public string? GoodId { get; set; }

    public string? BranchId { get; set; }

    public string? GroupId { get; set; }

    public string? CustomerId { get; set; }

    public int? Quantity { get; set; }

    public string BigUnitId { get; set; } = null!;

    public string? UnitId { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal? ImpPrice { get; set; }

    public decimal? ImpPriceVat { get; set; }

    public decimal? ExpPrice { get; set; }

    public decimal? ExpPriceVat { get; set; }

    public string? VatId { get; set; }

    public decimal? TotalVat { get; set; }

    public decimal? TotalImpPrice { get; set; }

    public decimal? TotalImpPriceVat { get; set; }

    public decimal? TotalExpPrice { get; set; }

    public decimal? TotalExpPriceVat { get; set; }

    public decimal? Profit { get; set; }

    public string? Description { get; set; }

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

    public int? NegativeQuatity { get; set; }

    public int? Nqtyimp { get; set; }

    public string? NegativeStatus { get; set; }

    public int? OrginalQty { get; set; }

    /// <summary>
    /// TK Nợ
    /// </summary>
    public string? DebitAccount { get; set; }

    /// <summary>
    /// TK Có
    /// </summary>
    public string? CreditAccount { get; set; }

    /// <summary>
    /// Thuế suất GTGT
    /// </summary>
    public decimal? TaxVatRate { get; set; }

    public decimal TaxVatAmount { get; set; }

    /// <summary>
    /// TK Nợ thuế GTGT
    /// </summary>
    public string? DebitTaxVataccount { get; set; }

    /// <summary>
    /// TK có thuế GTGT
    /// </summary>
    public string? CreditTaxVataccount { get; set; }

    /// <summary>
    /// Số Lô
    /// </summary>
    public string? LotNumber { get; set; }

    /// <summary>
    /// Hạn Sử dụng
    /// </summary>
    public string? ExpiredDate { get; set; }

    public string ImportId { get; set; } = null!;

    public string ExportId { get; set; } = null!;

    public decimal? PriceOrg { get; set; }

    public decimal? PriceVatOrg { get; set; }

    /// <summary>
    /// TK Nợ thuế GTGT
    /// </summary>
    public string? CostDebitAccount { get; set; }

    /// <summary>
    /// TK có thuế GTGT
    /// </summary>
    public string? CostCreditAccount { get; set; }

    public decimal? FeeAmount { get; set; }

    public decimal? FeeAmountVat { get; set; }

    public decimal? TotalPriceOrg { get; set; }

    public decimal? TotalPriceVatorg { get; set; }

    public virtual RetailTran Transaction { get; set; } = null!;
}
