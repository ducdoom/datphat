﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class HrWorkSchedule
{
    public string WorkScheduleId { get; set; } = null!;

    public string? WorkScheduleName { get; set; }

    public string? WorkScheduleIn { get; set; }

    public string? WorkScheduleOut { get; set; }

    public string? BreakTimeStart { get; set; }

    public string? BreakTimeEnd { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
