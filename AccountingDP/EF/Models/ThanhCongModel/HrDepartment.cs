﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class HrDepartment
{
    public string DepartmentId { get; set; } = null!;

    public string? DepartmentName { get; set; }

    /// <summary>
    /// Số tiền nguyên tệ
    /// </summary>
    public decimal? SalaryBase { get; set; }

    /// <summary>
    /// Số tiền nguyên tệ
    /// </summary>
    public decimal? SalaryInsurance { get; set; }

    public decimal? SalaryProfitRate { get; set; }

    public decimal? MortgageProfitRate { get; set; }

    public decimal? SaleForOvertime { get; set; }

    public int? SalaryPayDay { get; set; }

    public bool? SalarySaleByWorkday { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
