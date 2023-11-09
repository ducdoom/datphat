using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ImpExpMethodType
{
    /// <summary>
    /// Loại phương thức nhập xuất.
    /// </summary>
    public string ImpExpMethodType1 { get; set; } = null!;

    public string? ImpExpMethodName { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
