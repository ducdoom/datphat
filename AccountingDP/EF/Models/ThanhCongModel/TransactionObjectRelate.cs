﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class TransactionObjectRelate
{
    public Guid TransactionObjectRelateId { get; set; }

    public string TransactionId { get; set; } = null!;

    public Guid TransactionAccountingId { get; set; }

    public string ZoneId { get; set; } = null!;

    /// <summary>
    /// Mã  loại đối tượng
    /// </summary>
    public string ObjectCategoryCode { get; set; } = null!;

    /// <summary>
    /// Tài khoản có
    /// </summary>
    public string CreditAccount { get; set; } = null!;

    /// <summary>
    /// Tài khoản nợ
    /// </summary>
    public string DebitAccount { get; set; } = null!;

    /// <summary>
    /// Giá trị của đối tượng được chọn, ví dụ đối tượng là Khách Hàng CustomerID thì giá trị là mã khách hàng
    /// </summary>
    public decimal Value { get; set; }

    /// <summary>
    /// Mã đối tượng ghi nợ
    /// </summary>
    public string? ObjectValueDebit { get; set; }

    /// <summary>
    /// Mã đối tượng ghi có
    /// </summary>
    public string? ObjectValueCredit { get; set; }

    public int? SortOrder { get; set; }

    public int? OrderColunm { get; set; }
}
