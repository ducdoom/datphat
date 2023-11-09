﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class VoucherDetail
{
    public Guid VoucherDetailId { get; set; }

    public string ZoneId { get; set; } = null!;

    public string VouchersId { get; set; } = null!;

    public string AutoBusinessId { get; set; } = null!;

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
    /// Đối tượng
    /// </summary>
    public string? AccountObjectId { get; set; }

    /// <summary>
    /// Tên người gửi, nhận
    /// </summary>
    public string? ReceiverName { get; set; }

    /// <summary>
    /// Số CMT
    /// </summary>
    public string? ReceiverIdnumber { get; set; }

    /// <summary>
    /// Tài khoản ngân hàng
    /// </summary>
    public string? BankAccountId { get; set; }

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

    public string? CustomField1 { get; set; }

    public string? CustomField2 { get; set; }

    public string? CustomField3 { get; set; }

    public string? CustomField4 { get; set; }

    public string? CustomField5 { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? Time { get; set; }

    public string? SyncTime { get; set; }
}
