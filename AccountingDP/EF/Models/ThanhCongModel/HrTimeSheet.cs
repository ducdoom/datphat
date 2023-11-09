﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class HrTimeSheet
{
    /// <summary>
    /// Ngày hạch toán
    /// </summary>
    public string TimekeepingMonth { get; set; } = null!;

    public string DepartmentId { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    /// <summary>
    /// Ngày trong tháng
    /// </summary>
    public string TimekeepingDate { get; set; } = null!;

    public string? TimeIn { get; set; }

    public string? TimeOut { get; set; }

    /// <summary>
    /// Thời gian đi muộn về sớm tính theo phút
    /// </summary>
    public int? TardinessLeaveEarly { get; set; }

    /// <summary>
    /// Thời gian đi muộn về sớm tính theo phút
    /// </summary>
    public int? TardinessLeaveEarlyForSalary { get; set; }

    public bool? CheckForSalary { get; set; }

    public string? TimeInOvertime { get; set; }

    public string? TimeOutOvertime { get; set; }

    /// <summary>
    /// Thời gian đi muộn về sớm tính theo phút
    /// </summary>
    public int? OvertimeForSalary { get; set; }

    public string? DepartmentIdOvertime { get; set; }

    public decimal? SalaryRateOvertime { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
