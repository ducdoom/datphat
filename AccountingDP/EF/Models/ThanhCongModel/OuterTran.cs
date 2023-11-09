using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class OuterTran
{
    public string ExpTranId { get; set; } = null!;

    public string ImpTranId { get; set; } = null!;

    public string? ImportId { get; set; }

    public string? ExportId { get; set; }

    /// <summary>
    /// Trạng thái điều chuyển ngoài vùng (sang kho trung chuyển) 0: chưa nhận hàng; 1: đã nhận hàng
    /// </summary>
    public string? TranStatus { get; set; }

    public string? SyncTime { get; set; }
}
