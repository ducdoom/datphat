﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class GoodServiceCalalog
{
    /// <summary>
    /// PK Mã danh mục dịch vụ
    /// </summary>
    public Guid GoodServiceId { get; set; }

    /// <summary>
    /// Kí hiệu của danh mục dịch vụ
    /// </summary>
    public string? GoodServiceSign { get; set; }

    /// <summary>
    /// Tên của Danh mục dịch vụ
    /// </summary>
    public string? GoodServiceFullName { get; set; }

    /// <summary>
    /// Mã NCC của nhà cung cấp danh mục dịch vụ
    /// </summary>
    public string? GoodServiceSupId { get; set; }

    /// <summary>
    /// Mã nhóm danh mục dịch vụ
    /// </summary>
    public string? GoodServiceGroupId { get; set; }

    public string? UnitId { get; set; }

    public string? VatId { get; set; }

    public decimal? Price { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public bool? Enable { get; set; }

    public string? SyncTime { get; set; }
}
