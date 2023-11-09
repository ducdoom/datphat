using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ImpExpMethodGroup
{
    /// <summary>
    /// Mã nhóm phương thức nhập xuất.
    /// </summary>
    public string ImpExpMethodGroupId { get; set; } = null!;

    /// <summary>
    /// Tên nhóm phương thức nhập xuất.
    /// </summary>
    public string? ImpExpMethodGroupName { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
