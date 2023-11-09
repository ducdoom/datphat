using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class HrSaleSalary
{
    public string SaleSalaryId { get; set; } = null!;

    public string? SaleSalaryName { get; set; }

    public decimal? SaleSalaryRate { get; set; }

    public decimal? SaleSalaryValue { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
