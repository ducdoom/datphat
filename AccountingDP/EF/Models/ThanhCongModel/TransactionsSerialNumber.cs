using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class TransactionsSerialNumber
{
    public int ItemId { get; set; }

    public string TransactionId { get; set; } = null!;

    public string? TransCode { get; set; }

    public string FullGoodId { get; set; } = null!;

    public string? GoodId { get; set; }

    public string ImportId { get; set; } = null!;

    public string ExportId { get; set; } = null!;

    public string SerialNumber { get; set; } = null!;
}
