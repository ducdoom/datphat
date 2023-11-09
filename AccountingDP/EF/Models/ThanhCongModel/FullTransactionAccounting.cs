﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class FullTransactionAccounting
{
    public string ZoneId { get; set; } = null!;

    public string? TransCode { get; set; }

    public string? DateWriteBook { get; set; }

    public string TransactionId { get; set; } = null!;

    public string TransDate { get; set; } = null!;

    public string? Description { get; set; }

    public string? WritedOnBook { get; set; }

    public int? WriteOrder { get; set; }

    public string Account { get; set; } = null!;

    public string Type { get; set; } = null!;

    public decimal DebitAmount { get; set; }

    public decimal CreditAmount { get; set; }

    public string? SyncTime { get; set; }
}
