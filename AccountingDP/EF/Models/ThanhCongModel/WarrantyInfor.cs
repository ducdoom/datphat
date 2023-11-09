﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class WarrantyInfor
{
    public int ItemId { get; set; }

    public Guid WarrantyId { get; set; }

    public string TransactionId { get; set; } = null!;

    public string GoodId { get; set; } = null!;

    public string? SerialNumber { get; set; }

    public string? TransDate { get; set; }

    public string? WarrantyEndDate { get; set; }

    public int? Quantity { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? SyncTime { get; set; }
}
