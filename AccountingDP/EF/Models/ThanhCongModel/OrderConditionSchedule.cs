using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class OrderConditionSchedule
{
    public string CustomerId { get; set; } = null!;

    public string? ScheduleType { get; set; }

    public string? ScheduleValue { get; set; }

    public bool? EnableSchedule { get; set; }

    public string? OrderConditionType { get; set; }

    public string OrderValues { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? SyncTime { get; set; }
}
