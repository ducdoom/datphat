﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ZzHrmstaffCriteriaInfor
{
    public string CustomerId { get; set; } = null!;

    public Guid CriteriaId { get; set; }

    /// <summary>
    /// Mã tiêu chí
    /// </summary>
    public string? CriteriaCode { get; set; }

    /// <summary>
    /// Nếu là tiêu chí thông thường thì TC, nếu là tiêu chí doanh số thì DS, với tiêu chí doanh số thì sẽ chỉ có một lựa chọn khi sử dụng.
    /// </summary>
    public string? CriteriaType { get; set; }

    /// <summary>
    /// Tỉ lệ hoàn thành tiêu chí
    /// </summary>
    public decimal? PercentComplete { get; set; }

    public decimal? Value { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
