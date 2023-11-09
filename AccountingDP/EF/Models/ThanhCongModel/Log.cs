﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Log
{
    /// <summary>
    /// gom: DDMMYYYYHHMMSSMLS
    /// </summary>
    public string LogId { get; set; } = null!;

    public string? ZoneId { get; set; }

    public string? StationId { get; set; }

    public string? UserId { get; set; }

    public string? FormId { get; set; }

    public string? ControlId { get; set; }

    public DateTime? DateLog { get; set; }

    public string? SyncTime { get; set; }

    public virtual LogDetail? LogDetail { get; set; }
}
