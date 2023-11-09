﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class AccountZone
{
    public string ZoneId { get; set; } = null!;

    /// <summary>
    /// PK Tài khoản
    /// </summary>
    public string AccountId { get; set; } = null!;

    /// <summary>
    /// Số hiệu tài khoản
    /// </summary>
    public string AccountNumber { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
