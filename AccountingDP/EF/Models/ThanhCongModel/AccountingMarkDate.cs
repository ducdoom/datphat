﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class AccountingMarkDate
{
    public string ZoneId { get; set; } = null!;

    public string? Fromdate { get; set; }

    public string? ToDate { get; set; }

    public string TransDate { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? SyncTime { get; set; }
}
