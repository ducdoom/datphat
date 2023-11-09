using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class CustomerPassword
{
    public string CustomerId { get; set; } = null!;

    public string? Password { get; set; }
}
