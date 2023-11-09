﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Server
{
    public string ServerId { get; set; } = null!;

    public string ZoneId { get; set; } = null!;

    public string? ServerName { get; set; }

    public string? ServerIp { get; set; }

    public string? ServerType { get; set; }

    public string? Note { get; set; }

    public DateTime? TranDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public bool? Online { get; set; }

    public string? SyncTime { get; set; }

    public virtual Zone Zone { get; set; } = null!;
}
