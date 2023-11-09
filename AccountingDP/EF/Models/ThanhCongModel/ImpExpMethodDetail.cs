﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ImpExpMethodDetail
{
    /// <summary>
    /// Key Mã phương thức nhập xuất
    /// </summary>
    public Guid ImpExpMethodId { get; set; }

    /// <summary>
    /// Mã phương thức Nhập xuất
    /// </summary>
    public string ImExpMethodCode { get; set; } = null!;

    /// <summary>
    /// Tài khoản có
    /// </summary>
    public string CreditAccount { get; set; } = null!;

    /// <summary>
    /// Tài khoản nợ
    /// </summary>
    public string DebitAccount { get; set; } = null!;

    /// <summary>
    /// Tài khoản có
    /// </summary>
    public string CreditAccountList { get; set; } = null!;

    /// <summary>
    /// Tài khoản có
    /// </summary>
    public string DebitAccountList { get; set; } = null!;

    public string? AccountItemName { get; set; }

    /// <summary>
    /// Định Danh khoản mục hạch toán
    /// </summary>
    public Guid? AccountItemAliasId { get; set; }

    public string AccountItemAlias { get; set; } = null!;

    public string? ColumnName { get; set; }

    /// <summary>
    /// thứ tự tài khoản
    /// </summary>
    public int? Orders { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    /// <summary>
    /// Tài khoản chính: 1 là tài khoản chính,0 Không phải
    /// </summary>
    public string? IsMainAccount { get; set; }

    /// <summary>
    /// Tài khoản chính: 1 là tài khoản chính,0 Không phải
    /// </summary>
    public string? IsCostAccount { get; set; }
}
