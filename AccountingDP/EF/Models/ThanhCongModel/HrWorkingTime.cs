﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class HrWorkingTime
{
    /// <summary>
    /// Ngày hạch toán
    /// </summary>
    public string WorkingTime { get; set; } = null!;

    public string DepartmentId { get; set; } = null!;

    /// <summary>
    /// Số tiền nguyên tệ
    /// </summary>
    public int? NumOfWorkingDay { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
