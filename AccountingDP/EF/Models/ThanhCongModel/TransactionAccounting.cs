﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class TransactionAccounting
{
    public string TransactionId { get; set; } = null!;

    public string? TransCode { get; set; }

    public Guid TransactionAccountingId { get; set; }

    public string ZoneId { get; set; } = null!;

    public string ImpExpMethodCode { get; set; } = null!;

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Tài khoản nợ
    /// </summary>
    public string DebitAccount { get; set; } = null!;

    /// <summary>
    /// Tài khoản có
    /// </summary>
    public string CreditAccount { get; set; } = null!;

    /// <summary>
    /// Tên người gửi, nhận
    /// </summary>
    public Guid? AccountItemAliasId { get; set; }

    /// <summary>
    /// Số tiền nguyên tệ
    /// </summary>
    public decimal AmountOc { get; set; }

    /// <summary>
    /// Số tiền quy đổi
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Thứ tự sắp xếp
    /// </summary>
    public int? SortOrder { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? Time { get; set; }

    public string? TransDate { get; set; }

    public string? SyncTime { get; set; }

    public string ImportId { get; set; } = null!;

    public string ExportId { get; set; } = null!;
}
