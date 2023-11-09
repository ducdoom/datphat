﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class HrDayOff
{
    public string IdAuto { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    /// <summary>
    /// Ngày trong tháng
    /// </summary>
    public string DayOff { get; set; } = null!;

    public string? TimeOffBegin { get; set; }

    public string? TimeOffEnd { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
