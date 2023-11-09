﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ChangePrice
{
    public string ChangePriceId { get; set; } = null!;

    public string? TransCode { get; set; }

    public string? UserList { get; set; }

    public string? ChangeListDate { get; set; }

    public string? ChangeListTime { get; set; }

    public string? ApproverUser { get; set; }

    public string? ApproverDate { get; set; }

    public string? ApproverTime { get; set; }

    public int? TotalCountApprover { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
