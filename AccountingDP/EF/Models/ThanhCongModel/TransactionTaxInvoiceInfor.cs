﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class TransactionTaxInvoiceInfor
{
    /// <summary>
    /// Số giao dịch
    /// </summary>
    public string TransactionId { get; set; } = null!;

    /// <summary>
    /// Ngày số hóa đơn
    /// </summary>
    public string? TaxDate { get; set; }

    /// <summary>
    /// Kí hiệu hóa đơn.
    /// </summary>
    public string TaxSign { get; set; } = null!;

    /// <summary>
    /// Số hóa đơn
    /// </summary>
    public string TaxSerialNumber { get; set; } = null!;

    /// <summary>
    /// Tên loại hóa đơn
    /// </summary>
    public string? InvTypeCode { get; set; }

    /// <summary>
    /// Hóa đơn nhận từ khách hàng?
    /// </summary>
    public string? ReceivedFromCustomer { get; set; }

    /// <summary>
    /// Địa chỉ hóa đơn
    /// </summary>
    public string? TaxAddress { get; set; }

    /// <summary>
    /// Mã số thuế công ty xuất hóa đơn
    /// </summary>
    public string? TaxCode { get; set; }

    /// <summary>
    /// Ngày nhận hóa đơn
    /// </summary>
    public string? ReceivedDate { get; set; }

    /// <summary>
    /// Mô tả 
    /// </summary>
    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
