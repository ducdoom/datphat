﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ReRetailTransDetail
{
    public int ItemId { get; set; }

    public string TransactionId { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public string FullGoodId { get; set; } = null!;

    public int? Quantity { get; set; }

    public string BigUnitId { get; set; } = null!;

    public string PacketId { get; set; } = null!;

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual RetailTran Transaction { get; set; } = null!;

    public virtual Transaction TransactionNavigation { get; set; } = null!;
}
