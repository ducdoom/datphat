﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class VoucherTypeCategory
{
    /// <summary>
    /// PK của bảng
    /// </summary>
    public Guid VoucherTypeId { get; set; }

    /// <summary>
    /// Mã loại chứng từ
    /// </summary>
    public string VoucherTypeCode { get; set; } = null!;

    /// <summary>
    /// Tên loại chứng từ
    /// </summary>
    public string VoucherTypeName { get; set; } = null!;

    /// <summary>
    /// Tài khoản nợ
    /// </summary>
    public string? DebitAccount { get; set; }

    /// <summary>
    /// Tài khoản nợ khả dụng, đặt cách nhau bởi dấu phẩy
    /// </summary>
    public string? DebitAvaiable { get; set; }

    /// <summary>
    /// Tài khoản có
    /// </summary>
    public string? CreditAccount { get; set; }

    /// <summary>
    /// Tài khoản có khả dụng, cách nhau bởi dấu phẩy.
    /// </summary>
    public string? CreditAvaiable { get; set; }

    /// <summary>
    /// Là dữ liệu hệ thống thì không được xóa.
    /// </summary>
    public bool IsSystem { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

    public bool Inactive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
