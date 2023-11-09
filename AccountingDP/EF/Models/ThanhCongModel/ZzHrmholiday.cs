using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ZzHrmholiday
{
    public int Id { get; set; }

    public string? Hdate { get; set; }

    public string? Holiday { get; set; }

    /// <summary>
    /// YearLy hàng năm, Monthly hàng tháng, Weekly hàng tuần, Once: một lần
    /// </summary>
    public string? Type { get; set; }
}
