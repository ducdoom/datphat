﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class HrSaleRate
{
    /// <summary>
    /// Ngày hạch toán
    /// </summary>
    public string SaleTime { get; set; } = null!;

    public string DepartmentId { get; set; } = null!;

    /// <summary>
    /// Số tiền nguyên tệ
    /// </summary>
    public decimal? SaleContract { get; set; }

    public decimal? SaleActual { get; set; }

    public decimal? SaleRate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
