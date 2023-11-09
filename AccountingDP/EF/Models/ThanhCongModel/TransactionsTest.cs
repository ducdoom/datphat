﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class TransactionsTest
{
    public string TransactionId { get; set; } = null!;

    public string? TransCode { get; set; }

    public string ZoneId { get; set; } = null!;

    public string? StationId { get; set; }

    public string? Deliver { get; set; }

    public string? Receiver { get; set; }

    public string? StaffInChargeId { get; set; }

    public string? ReceiptNo { get; set; }

    public string? VatNo { get; set; }

    public string? TaxSign { get; set; }

    public string? FormNo { get; set; }

    public string? VatDate { get; set; }

    public string? ImportId { get; set; }

    public string? ExportId { get; set; }

    public string? StockId { get; set; }

    public string? OrderId { get; set; }

    public decimal? OrgPrice { get; set; }

    public decimal? TotalPrice { get; set; }

    public decimal? TotalVat { get; set; }

    public decimal? TotalPriceVat { get; set; }

    public decimal? TotalDiscount { get; set; }

    public decimal? TotalProfit { get; set; }

    public string? Description { get; set; }

    public string? TransDate { get; set; }

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

    public string? CurrencyId { get; set; }

    public string? CurrencyIdoc { get; set; }

    public decimal? ExchangeRate { get; set; }

    public int? DueTime { get; set; }

    public string? DueDate { get; set; }

    public Guid? ContractId { get; set; }

    public Guid? ImpExpMethodId { get; set; }

    public string? ImpExpMethodCode { get; set; }

    public string? ImpExpMethodName { get; set; }

    public string? TaxInvoice { get; set; }

    public string? CostFormula { get; set; }

    public string? RevenueFormula { get; set; }
}
