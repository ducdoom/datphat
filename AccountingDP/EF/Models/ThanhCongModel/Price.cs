﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Price
{
    public string ZoneId { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public decimal? ExpWholePrice { get; set; }

    public decimal? ExpRetailPrice { get; set; }

    public decimal? ExpWholePriceVat { get; set; }

    public decimal? ExpRetailPriceVat { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual Good Good { get; set; } = null!;

    public virtual Zone Zone { get; set; } = null!;
}
