using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class GoodFlg
{
    public string GoodId { get; set; } = null!;

    public string FlagOnDate { get; set; } = null!;

    public string? FlagOffDate { get; set; }

    public string? Status { get; set; }

    public string? FlagOnBy { get; set; }
}
