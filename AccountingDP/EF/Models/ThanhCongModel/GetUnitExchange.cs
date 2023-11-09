using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class GetUnitExchange
{
    public string GoodId { get; set; } = null!;

    public string UnitId { get; set; } = null!;

    public string? UnitName { get; set; }

    public string BigUnitId { get; set; } = null!;

    public string? BigUnitName { get; set; }

    public int ConvertUnit { get; set; }
}
