﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Stock
{
    public string StockId { get; set; } = null!;

    public string? ZoneId { get; set; }

    public int? TypeId { get; set; }

    public string? ManagerName { get; set; }

    public string? StockName { get; set; }

    public string? Address { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public string? Note { get; set; }

    /// <summary>
    /// 0: CK trước thuế; 1: CK sau thuế
    /// </summary>
    public bool? AllowAutoOrder { get; set; }

    /// <summary>
    /// 0: CK trước thuế; 1: CK sau thuế
    /// </summary>
    public bool? AllowCreateAutoOrder { get; set; }

    /// <summary>
    /// 0: CK trước thuế; 1: CK sau thuế
    /// </summary>
    public bool? AllowFilterBranch { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual ICollection<AlertDate> AlertDates { get; set; } = new List<AlertDate>();

    public virtual ICollection<ListShelf> ListShelves { get; set; } = new List<ListShelf>();

    public virtual ICollection<QtyMinMaxDetail> QtyMinMaxDetails { get; set; } = new List<QtyMinMaxDetail>();

    public virtual ICollection<Shelf> Shelves { get; set; } = new List<Shelf>();

    public virtual Zone? Zone { get; set; }
}
