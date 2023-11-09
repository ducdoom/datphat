using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class HrDepartmentCriteriaSalary
{
    public string DepartmentId { get; set; } = null!;

    public string CriteriaSalaryId { get; set; } = null!;

    public decimal? CriteriaSalaryValue { get; set; }
}
