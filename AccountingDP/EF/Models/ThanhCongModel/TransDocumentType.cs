﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class TransDocumentType
{
    /// <summary>
    /// PK
    /// </summary>
    public int InvTypeId { get; set; }

    /// <summary>
    /// Tên loại hóa đơn
    /// </summary>
    public string InvTypeCode { get; set; } = null!;

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string InvTypeName { get; set; } = null!;

    /// <summary>
    /// Tiền tố mẫu số hóa đơn
    /// </summary>
    public string? InvoiceTemplatePrefix { get; set; }

    /// <summary>
    /// 0=Loại hóa đơn bán hàng;1=Loại hóa đơn xuất chuyển kho
    /// </summary>
    public int InvoiceType { get; set; }

    public bool Inactive { get; set; }

    public bool IsSystem { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? SyncTime { get; set; }
}
