using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class SysParam
{
    public string SysParamName { get; set; } = null!;

    public string? SysParamDefaultValue { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public int? SysParamType { get; set; }

    public string? SyncTime { get; set; }

    public virtual ICollection<SysParamValue> SysParamValues { get; set; } = new List<SysParamValue>();
}
