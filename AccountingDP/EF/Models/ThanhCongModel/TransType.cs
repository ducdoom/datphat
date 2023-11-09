using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class TransType
{
    public string TransCode { get; set; } = null!;

    public string? TransName { get; set; }

    public string? Description { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual ICollection<RetailTran> RetailTrans { get; set; } = new List<RetailTran>();

    public virtual ICollection<RetailTransTemp> RetailTransTemps { get; set; } = new List<RetailTransTemp>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
