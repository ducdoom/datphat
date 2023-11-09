﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ContractTermsOfPayment
{
    public int ItemId { get; set; }

    public Guid ContractId { get; set; }

    /// <summary>
    /// ID phụ lục hợp đồng, nếu không có phụ lục thì = ContractID
    /// </summary>
    public Guid AppendixContractId { get; set; }

    public string? TermsPaymentName { get; set; }

    /// <summary>
    /// Số lần thanh toán, mặc định là 1 lần và PaymentPercentage =100%
    /// </summary>
    public int NumberPayments { get; set; }

    public decimal? PaymentAmount { get; set; }

    public decimal? PaymentAmountOc { get; set; }

    public int? PaymentPercentage { get; set; }

    public string? PaymentDate { get; set; }

    /// <summary>
    /// Số ngày thanh toán sau khi nhập hàng, 0 - Thanh toán ngay, &gt;0 số ngày sẽ thanh toán sau khi nhập hàng.
    /// </summary>
    public int? DayPaymentByImp { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? SyncTime { get; set; }
}
