﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class GoodServiceGroup
{
    public string GoodServiceGroupId { get; set; } = null!;

    public string? GoodServiceName { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public bool? Enable { get; set; }

    public string? SyncTime { get; set; }
}
