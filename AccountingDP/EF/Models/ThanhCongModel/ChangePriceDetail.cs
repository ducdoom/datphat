﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ChangePriceDetail
{
    public int ItemId { get; set; }

    public int? Sort { get; set; }

    public string ChangePriceId { get; set; } = null!;

    public string TransactionId { get; set; } = null!;

    public string ImportId { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public string? BranchId { get; set; }

    public string? GroupId { get; set; }

    public int? Quantity { get; set; }

    public decimal? ImpPrice { get; set; }

    public decimal? ImpPriceVat { get; set; }

    public decimal? LastRetailPrice { get; set; }

    public decimal? LastRetailPriceVat { get; set; }

    public decimal? AutoNewRetailPrice { get; set; }

    public decimal? AutoNewRetailPriceVat { get; set; }

    public decimal? NewRetailPrice { get; set; }

    public decimal? NewRetailPriceVat { get; set; }

    public decimal? LastWholePrice { get; set; }

    public decimal? LastWholePriceVat { get; set; }

    public decimal? AutoNewWholePrice { get; set; }

    public decimal? AutoNewWholePriceVat { get; set; }

    public decimal? NewWholePrice { get; set; }

    public decimal? NewWholePriceVat { get; set; }

    public decimal? MinPercentWhole { get; set; }

    public decimal? MaxPercentWhole { get; set; }

    public decimal? MaxPercentRetailPrice { get; set; }

    public decimal? MinPercentRetailPrice { get; set; }

    public decimal? PercentWhole { get; set; }

    public decimal? PercentRetailPrice { get; set; }

    public decimal? OldWholeProfitRate { get; set; }

    public decimal? OldRetailProfitRate { get; set; }

    public decimal? NewWholeProfitRate { get; set; }

    public decimal? NewRetailProfitRate { get; set; }

    public bool? ApproverCheck { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? Time { get; set; }

    public string? SyncTime { get; set; }
}
