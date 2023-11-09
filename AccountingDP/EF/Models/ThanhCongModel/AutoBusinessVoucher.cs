﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

/// <summary>
/// Định khoản tự động
/// </summary>
public partial class AutoBusinessVoucher
{
    public string AutoBusinessId { get; set; } = null!;

    public string? Absign { get; set; }

    /// <summary>
    /// Tên định khoản tự động
    /// </summary>
    public string? AutoBusinessName { get; set; }

    /// <summary>
    /// Loại chứng từ: 0 = Thu tiền mặt; 1 = Chi tiền mặt; 2 = Thu tiền gửi; 3 = Chi tiền gửi
    /// </summary>
    public string? VoucherType { get; set; }

    /// <summary>
    /// Tài khoản nợ
    /// </summary>
    public string? DebitAccount { get; set; }

    /// <summary>
    /// Tài khoản có
    /// </summary>
    public string? CreditAccount { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
