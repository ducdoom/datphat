﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class TransactionImportTaxDetail
{
    public Guid TransDetailId { get; set; }

    public string TransactionId { get; set; } = null!;

    public string FullGoodId { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    /// <summary>
    /// % Thuế nhập khẩu
    /// </summary>
    public decimal ImportTaxRate { get; set; }

    /// <summary>
    /// Tiền thuế  nhập khẩu quy đổi
    /// </summary>
    public decimal ImportTaxAmount { get; set; }

    /// <summary>
    /// TK thuế  nhập khẩu
    /// </summary>
    public string? ImportTaxAccount { get; set; }

    /// <summary>
    /// Tài khoản nợ
    /// </summary>
    public string DebitAccount { get; set; } = null!;

    /// <summary>
    /// Tài khoản có
    /// </summary>
    public string CreditAccount { get; set; } = null!;
}
