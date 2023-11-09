﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class TransactionDiscountDetail
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

    public decimal? DiscountRate { get; set; }

    /// <summary>
    /// %Thuế tiêu thụ đặc biệt
    /// </summary>
    public decimal DiscountAmount { get; set; }

    public string? DiscountName { get; set; }

    /// <summary>
    /// KIỂU GIẢM GIÁ, IMP CHO GD NHẬP, EXP CHO GIAO DỊCH XUẤT
    /// </summary>
    public string? DiscountType { get; set; }
}
