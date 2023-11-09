﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Barcode
{
    public string GoodId { get; set; } = null!;

    public string Barcode1 { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
