﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class VoucherMark20190601
{
    public int Orders { get; set; }

    public Guid VoucherDetailId { get; set; }

    public string ZoneId { get; set; } = null!;

    public string DebitAccount { get; set; } = null!;

    public string CreditAccount { get; set; } = null!;

    public decimal AmountOc { get; set; }

    public decimal Amount { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? Time { get; set; }

    public string? SyncTime { get; set; }
}
