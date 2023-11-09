﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class TransactionFeeDetail
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
    /// %Thuế tiêu thụ đặc biệt
    /// </summary>
    public decimal FeeAmount { get; set; }

    /// <summary>
    /// %Thuế tiêu thụ đặc biệt
    /// </summary>
    public decimal FeeAmountVat { get; set; }

    public Guid? FeeId { get; set; }

    public string? FeeNote { get; set; }

    /// <summary>
    /// Tài khoản nợ
    /// </summary>
    public string DebitAccount { get; set; } = null!;

    /// <summary>
    /// Tài khoản có
    /// </summary>
    public string CreditAccount { get; set; } = null!;

    public string? CustomerId { get; set; }

    public string? FeeVatId { get; set; }

    /// <summary>
    /// Thuế suất GTGT
    /// </summary>
    public decimal? FeeTaxVatRate { get; set; }

    public decimal FeeTaxVatAmount { get; set; }

    /// <summary>
    /// TK Nợ thuế GTGT
    /// </summary>
    public string? DebitFeeTaxVataccount { get; set; }

    /// <summary>
    /// TK có thuế GTGT
    /// </summary>
    public string? CreditFeeTaxVataccount { get; set; }
}
