﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class RetailTransTemp
{
    public string TransactionId { get; set; } = null!;

    public string? TransCode { get; set; }

    public string ZoneId { get; set; } = null!;

    public string? StationId { get; set; }

    public string? ReceiptNo { get; set; }

    public string? VatNo { get; set; }

    public string? ImportId { get; set; }

    public string? ExportId { get; set; }

    public decimal? OrgPrice { get; set; }

    public decimal? TotalImpPrice { get; set; }

    public decimal? TotalImpPriceVat { get; set; }

    public decimal? TotalExpPrice { get; set; }

    public decimal? TotalExpPriceVat { get; set; }

    public decimal? TotalDiscount { get; set; }

    public decimal? TotalProfit { get; set; }

    public string? Description { get; set; }

    public string? TransDate { get; set; }

    public string? TransType { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public decimal? TotalCast { get; set; }

    public decimal? TotalBank { get; set; }

    public string? SyncTime { get; set; }

    public virtual ICollection<RetailTranDetailTemp> RetailTranDetailTemps { get; set; } = new List<RetailTranDetailTemp>();

    public virtual TransType? TransCodeNavigation { get; set; }

    public virtual Zone Zone { get; set; } = null!;
}
