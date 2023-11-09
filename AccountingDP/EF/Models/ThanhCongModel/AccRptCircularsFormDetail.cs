using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class AccRptCircularsFormDetail
{
    public string CircularsNumber { get; set; } = null!;

    public string FormNumber { get; set; } = null!;

    public string? FormName { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }
}
