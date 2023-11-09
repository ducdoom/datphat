using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class CustomersType
{
    public string TypeId { get; set; } = null!;

    public string? TypeName { get; set; }

    public int? CusType { get; set; }

    public string? SyncTime { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
