﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ZzHrmdepartment
{
    public string ZoneId { get; set; } = null!;

    public Guid DepartmentId { get; set; }

    public Guid? ScheduleId { get; set; }

    public string? DepartmentCode { get; set; }

    public string? DepartmentName { get; set; }

    /// <summary>
    /// tỉ lệ lương tăng khi đi làm ngày lễ
    /// </summary>
    public decimal? SalaryRateHoliday { get; set; }

    /// <summary>
    /// tỉ lệ lương tăng khi đi làm cuối tuần
    /// </summary>
    public decimal? SalaryRateEndWeek { get; set; }

    /// <summary>
    /// Số ngày nghỉ trên từng tháng
    /// </summary>
    public int? WorkOffPerMonth { get; set; }

    /// <summary>
    /// Lương định mức tính doanh số
    /// </summary>
    public decimal? SalaryOnsale { get; set; }

    /// <summary>
    /// Định mức Phụ cấp mất hàng tính theo tỉ lệ
    /// </summary>
    public decimal? OtherSupport { get; set; }

    /// <summary>
    /// Phụ cấp khác
    /// </summary>
    public decimal? OtherSalary { get; set; }

    public string? PayrollFormula { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
