﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Transaction
{
    public string TransactionId { get; set; } = null!;

    public string? TransCode { get; set; }

    public string ZoneId { get; set; } = null!;

    public string? StationId { get; set; }

    public string? Deliver { get; set; }

    public string? Receiver { get; set; }

    /// <summary>
    /// Nhân viên phụ trách
    /// </summary>
    public string? StaffInChargeId { get; set; }

    /// <summary>
    /// So chung tu/ ky hieu hoa don
    /// </summary>
    public string? ReceiptNo { get; set; }

    /// <summary>
    /// Số hóa đơn VAT
    /// </summary>
    public string? VatNo { get; set; }

    /// <summary>
    /// Kí hiệu hóa đơn
    /// </summary>
    public string? TaxSign { get; set; }

    /// <summary>
    /// Mau so hoa don
    /// </summary>
    public string? FormNo { get; set; }

    /// <summary>
    /// Ngày hóa đơn
    /// </summary>
    public string? VatDate { get; set; }

    public string? ImportId { get; set; }

    public string? ExportId { get; set; }

    public string? StockId { get; set; }

    public string? OrderId { get; set; }

    /// <summary>
    /// Gia von
    /// </summary>
    public decimal? OrgPrice { get; set; }

    /// <summary>
    /// tong tien chua VAT
    /// </summary>
    public decimal? TotalPrice { get; set; }

    /// <summary>
    /// Tong Vat
    /// </summary>
    public decimal? TotalVat { get; set; }

    /// <summary>
    /// tong tien co VAT
    /// </summary>
    public decimal? TotalPriceVat { get; set; }

    /// <summary>
    /// tong ck
    /// </summary>
    public decimal? TotalDiscount { get; set; }

    /// <summary>
    /// tong lai
    /// </summary>
    public decimal? TotalProfit { get; set; }

    public string? Description { get; set; }

    public string? TransDate { get; set; }

    /// <summary>
    /// 0: CK trước thuế; 1: CK sau thuế
    /// </summary>
    public bool? DiscountType { get; set; }

    public string? TransType { get; set; }

    public string? CheckedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    /// <summary>
    /// Loại tiền
    /// </summary>
    public string? CurrencyId { get; set; }

    /// <summary>
    /// Loại tiền
    /// </summary>
    public string? CurrencyIdoc { get; set; }

    /// <summary>
    /// Tỉ giá hối đoái
    /// </summary>
    public decimal? ExchangeRate { get; set; }

    /// <summary>
    /// Hạn thanh toán (bao nhiêu ngày)
    /// </summary>
    public int? DueTime { get; set; }

    /// <summary>
    /// Ngày thanh toán
    /// </summary>
    public string? DueDate { get; set; }

    /// <summary>
    /// PK  hợp đồng bán
    /// </summary>
    public Guid? ContractId { get; set; }

    /// <summary>
    /// Key Mã phương thức nhập xuất
    /// </summary>
    public Guid? ImpExpMethodId { get; set; }

    /// <summary>
    /// Mã phương thức Nhập xuất
    /// </summary>
    public string? ImpExpMethodCode { get; set; }

    /// <summary>
    /// Tên phương thức nhập xuất.
    /// </summary>
    public string? ImpExpMethodName { get; set; }

    /// <summary>
    /// Thông tin hóa đơn, 0 là không hóa đơn, 1 là có hóa đơn
    /// </summary>
    public string? TaxInvoice { get; set; }

    /// <summary>
    /// Công thức tính giá vốn
    /// </summary>
    public string? CostFormula { get; set; }

    /// <summary>
    /// Công thức tính doanh thu
    /// </summary>
    public string? RevenueFormula { get; set; }

    public virtual ICollection<ReRetailTransDetail> ReRetailTransDetails { get; set; } = new List<ReRetailTransDetail>();

    public virtual TransType? TransCodeNavigation { get; set; }

    public virtual ICollection<TransDetail> TransDetails { get; set; } = new List<TransDetail>();

    public virtual Zone Zone { get; set; } = null!;
}
