﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class VoucherDefine
{
    public int ItemId { get; set; }

    public string VoucherTypeCategory { get; set; } = null!;

    public string? Prefix { get; set; }

    public string? RefTypeCategoryName { get; set; }

    public int? Value { get; set; }

    public int? LengthOfValue { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SyncTime { get; set; }
}
