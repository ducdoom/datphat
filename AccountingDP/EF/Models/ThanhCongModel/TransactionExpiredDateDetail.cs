using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class TransactionExpiredDateDetail
{
    public string ZoneId { get; set; } = null!;

    public string TransactionId { get; set; } = null!;

    public string FullGoodId { get; set; } = null!;

    /// <summary>
    /// Hạn Sử dụng
    /// </summary>
    public string ExpiredDate { get; set; } = null!;

    public string? SyncTime { get; set; }
}
