﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class AccountObject
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

    public Guid ObjectId { get; set; }

    /// <summary>
    /// 0: chả làm gì  1: cảnh báo 2: bắt buộc
    /// </summary>
    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
