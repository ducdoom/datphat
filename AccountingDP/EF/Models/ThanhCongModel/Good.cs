﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Good
{
    public string GoodId { get; set; } = null!;

    public string? ShortName { get; set; }

    public string? FullName { get; set; }

    public string? SupplierId { get; set; }

    public string? GoodSupId { get; set; }

    public string? BranchId { get; set; }

    public string? GroupId { get; set; }

    public string? UnitId { get; set; }

    public string? BigUnitId { get; set; }

    public string? ManufactureId { get; set; }

    public int? ConvertUnit { get; set; }

    public string? ImpVat { get; set; }

    public string? ExpVat { get; set; }

    public decimal? ImpPrice { get; set; }

    public decimal? ExpWholePrice { get; set; }

    public decimal? ExpRetailPrice { get; set; }

    public decimal? AverImpPrice { get; set; }

    public decimal? ImpPriceVat { get; set; }

    public decimal? ExpWholePriceVat { get; set; }

    public decimal? ExpRetailPriceVat { get; set; }

    public decimal? AverImpPriceVat { get; set; }

    public decimal? LastImpPrice { get; set; }

    public decimal? LastImpPriceVat { get; set; }

    public string? ImagePath { get; set; }

    public string? ImageName { get; set; }

    public string? Note { get; set; }

    public bool? Warranty { get; set; }

    public int? NumberWarrantyDay { get; set; }

    public bool? HasExpireDate { get; set; }

    public int? NumberExpireDay { get; set; }

    public bool? HasSerial { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public bool? Enable { get; set; }

    public string? SyncTime { get; set; }

    public virtual ICollection<AlertDate> AlertDates { get; set; } = new List<AlertDate>();

    public virtual AttribGood? AttribGood { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual ICollection<CheckStatisticsDetail> CheckStatisticsDetails { get; set; } = new List<CheckStatisticsDetail>();

    public virtual ICollection<DoubleCode> DoubleCodes { get; set; } = new List<DoubleCode>();

    public virtual ICollection<ExtPrice> ExtPrices { get; set; } = new List<ExtPrice>();

    public virtual ProGroup? Group { get; set; }

    public virtual ICollection<HisExpPrice> HisExpPrices { get; set; } = new List<HisExpPrice>();

    public virtual ICollection<HisImpPrice> HisImpPrices { get; set; } = new List<HisImpPrice>();

    public virtual ListVat? ImpVatNavigation { get; set; }

    public virtual ICollection<ListScale> ListScales { get; set; } = new List<ListScale>();

    public virtual ICollection<Price> Prices { get; set; } = new List<Price>();

    public virtual ICollection<QtyMinMaxDetail> QtyMinMaxDetails { get; set; } = new List<QtyMinMaxDetail>();

    public virtual Customer? Supplier { get; set; }

    public virtual Unit? Unit { get; set; }

    public virtual ICollection<UnitExchange> UnitExchanges { get; set; } = new List<UnitExchange>();
}
