﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ContractDetail
{
    public Guid ContractId { get; set; }

    public string GoodId { get; set; } = null!;

    public string? Hscode { get; set; }

    /// <summary>
    /// Mô tả hàng hóa
    /// </summary>
    public string? ItemtName { get; set; }

    /// <summary>
    /// ID phụ lục hợp đồng, nếu không có phụ lục thì để trống
    /// </summary>
    public Guid AppendixContractId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? ImpPrice { get; set; }

    public decimal? ImpPriceOc { get; set; }

    public decimal? ImpPriceVat { get; set; }

    public decimal? ImpPriceVatoc { get; set; }

    public string? VatId { get; set; }

    /// <summary>
    /// Thuế suất GTGT
    /// </summary>
    public decimal? TaxVatRate { get; set; }

    public decimal? TaxVatAmount { get; set; }

    public decimal? TaxVatAmountOc { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? TotalAmountOc { get; set; }

    public decimal? TotalAmountVat { get; set; }

    public decimal? TotalAmountVatoc { get; set; }

    public string? UnitId { get; set; }

    public string? BigUnitId { get; set; }

    public decimal? ExchangeRate { get; set; }

    public int? ConvertNumber { get; set; }

    /// <summary>
    /// Số Hiệu Container
    /// </summary>
    public string? ContainNumber { get; set; }

    /// <summary>
    /// Vị trí trong kho
    /// </summary>
    public string? LocationInStock { get; set; }

    /// <summary>
    /// Số lượng kiện
    /// </summary>
    public int? PackageQty { get; set; }

    /// <summary>
    /// Ngành hàng cung cấp
    /// </summary>
    public string? BranchId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
