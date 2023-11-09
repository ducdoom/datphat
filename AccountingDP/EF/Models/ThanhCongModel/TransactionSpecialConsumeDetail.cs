﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class TransactionSpecialConsumeDetail
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
    public decimal SpecialConsumeTaxRate { get; set; }

    /// <summary>
    /// Thuế tiêu thụ đặc biệt quy đổi
    /// </summary>
    public decimal SpecialConsumeTaxAmount { get; set; }

    /// <summary>
    /// Tài khoản thuế tiêu thụ đặc biệt
    /// </summary>
    public string? SpecialConsumeTaxAccount { get; set; }

    /// <summary>
    /// Tài khoản nợ
    /// </summary>
    public string DebitAccount { get; set; } = null!;

    /// <summary>
    /// Tài khoản có
    /// </summary>
    public string CreditAccount { get; set; } = null!;
}
