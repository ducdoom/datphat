﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Voucher
{
    public string VouchersId { get; set; } = null!;

    public string ZoneId { get; set; } = null!;

    /// <summary>
    /// Mã lý do chi
    /// </summary>
    public string AutoBusinessId { get; set; } = null!;

    /// <summary>
    /// Loại phiếu
    /// </summary>
    public string VouchersType { get; set; } = null!;

    /// <summary>
    /// Mã khách hàng, nhân viên nhận, nộp
    /// </summary>
    public string CustomerId { get; set; } = null!;

    /// <summary>
    /// Người Nộp
    /// </summary>
    public string? Payers { get; set; }

    public string? Address { get; set; }

    /// <summary>
    /// Ngày hạch toán
    /// </summary>
    public string TransDate { get; set; } = null!;

    /// <summary>
    /// Hạn thanh toán (bao nhiêu ngày)
    /// </summary>
    public int? DueTime { get; set; }

    /// <summary>
    /// Ngày thanh toán
    /// </summary>
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Ngày chứng từ.
    /// </summary>
    public string? VoucherDate { get; set; }

    public string? Description { get; set; }

    public decimal Amount { get; set; }

    public string CurrencyId { get; set; } = null!;

    public decimal? ExchangeRate { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public string Status { get; set; } = null!;

    public string SynStatus { get; set; } = null!;

    public string? SyncTime { get; set; }

    /// <summary>
    /// Số tài khoản ngân hàng
    /// </summary>
    public string? SendBankAccountNumber { get; set; }

    /// <summary>
    /// Ngân hàng
    /// </summary>
    public Guid? SendBankId { get; set; }

    /// <summary>
    /// Nơi mở: ví dụ Ngân hàng VCB chi nhánh 01
    /// </summary>
    public string? SendBankName { get; set; }

    public string? SendBankBrand { get; set; }

    /// <summary>
    /// Chủ tài khoản
    /// </summary>
    public string? SendAccountHolder { get; set; }

    /// <summary>
    /// Số tài khoản ngân hàng
    /// </summary>
    public string? RecceiverBankAccountNumber { get; set; }

    /// <summary>
    /// Ngân hàng
    /// </summary>
    public Guid? RecceiverBankId { get; set; }

    /// <summary>
    /// Nơi mở: ví dụ Ngân hàng VCB chi nhánh 01
    /// </summary>
    public string? RecceiverBankName { get; set; }

    public string? RecceiverBankBrand { get; set; }

    /// <summary>
    /// Chủ tài khoản
    /// </summary>
    public string? RecceiverAccountHolder { get; set; }
}
