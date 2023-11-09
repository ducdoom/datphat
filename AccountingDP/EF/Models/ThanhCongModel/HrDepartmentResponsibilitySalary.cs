using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class HrDepartmentResponsibilitySalary
{
    public string DepartmentId { get; set; } = null!;

    public string ResponsibilitySalaryId { get; set; } = null!;

    public decimal? ResponsibilitySalaryValue { get; set; }
}
