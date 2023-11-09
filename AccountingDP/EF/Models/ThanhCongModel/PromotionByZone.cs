using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class PromotionByZone
{
    public string PromotionId { get; set; } = null!;

    public string ZoneId { get; set; } = null!;
}
