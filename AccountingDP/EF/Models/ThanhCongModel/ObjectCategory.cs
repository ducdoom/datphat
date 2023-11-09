using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ObjectCategory
{
    public Guid ObjectId { get; set; }

    public string? ObjectCategoryName { get; set; }

    public string? ObjectCategoryCode { get; set; }

    public string? Prefix { get; set; }

    public int? LengthNumber { get; set; }

    public string? TableName { get; set; }

    public string? CategoryOnTableId { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
