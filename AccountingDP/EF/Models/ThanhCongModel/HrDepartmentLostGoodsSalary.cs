using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class HrDepartmentLostGoodsSalary
{
    public string DepartmentId { get; set; } = null!;

    public string LostGoodsSalaryId { get; set; } = null!;

    public decimal? LostGoodsSalaryValue { get; set; }
}
