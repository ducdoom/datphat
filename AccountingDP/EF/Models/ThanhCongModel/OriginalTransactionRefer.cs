﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class OriginalTransactionRefer
{
    public string VouchersId { get; set; } = null!;

    /// <summary>
    /// Số giao dịch liên quan
    /// </summary>
    public string TransactionId { get; set; } = null!;

    /// <summary>
    /// Loại  giao dịch liên quan.
    /// </summary>
    public string? Type { get; set; }

    public string? TransactionDate { get; set; }

    public string? Description { get; set; }

    public decimal? Value { get; set; }
}
