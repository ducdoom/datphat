using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class AccRptCircular
{
    public string CircularsNumber { get; set; } = null!;

    public string? Issuedby { get; set; }

    public string? IssuedDate { get; set; }

    public string? SignerBy { get; set; }

    public string? Status { get; set; }
}
