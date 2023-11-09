using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class HisImpPrice
{
    public string ZoneId { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public decimal? ExpWholePrice { get; set; }

    public decimal? ExpRetailPrice { get; set; }

    public decimal? ExpWholePriceVat { get; set; }

    public decimal? ExpRetailPriceVat { get; set; }

    public string TransactionId { get; set; } = null!;

    public decimal ImpPrice { get; set; }

    public decimal ImpPriceVat { get; set; }

    public string? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? SyncTime { get; set; }

    public virtual Good Good { get; set; } = null!;

    public virtual Zone Zone { get; set; } = null!;
}
