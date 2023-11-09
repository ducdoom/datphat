﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class TransactionObjectRelateMark20180810
{
    public Guid ObjectMarkId { get; set; }

    public string? ZoneId { get; set; }

    /// <summary>
    /// Mã  loại đối tượng
    /// </summary>
    public string? ObjectCategoryCode { get; set; }

    /// <summary>
    /// Tài khoản có
    /// </summary>
    public string? CreditAccount { get; set; }

    /// <summary>
    /// Tài khoản nợ
    /// </summary>
    public string? DebitAccount { get; set; }

    /// <summary>
    /// Mã đối tượng ghi nợ
    /// </summary>
    public string? ObjectValueDebit { get; set; }

    /// <summary>
    /// Mã đối tượng ghi có
    /// </summary>
    public string? ObjectValueCredit { get; set; }

    /// <summary>
    /// Giá trị của đối tượng được chọn, ví dụ đối tượng là Khách Hàng CustomerID thì giá trị là mã khách hàng
    /// </summary>
    public decimal? Value { get; set; }
}
