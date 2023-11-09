﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class VouchersObjectRelateMark20190601
{
    public int Orders { get; set; }

    public Guid VouchersObjectRelateId { get; set; }

    public string ZoneId { get; set; } = null!;

    public Guid? VoucherDetailId { get; set; }

    public string ObjectCategoryCode { get; set; } = null!;

    public string CreditAccount { get; set; } = null!;

    public string DebitAccount { get; set; } = null!;

    public decimal Value { get; set; }

    public string? ObjectValueDebit { get; set; }

    public string? ObjectValueCredit { get; set; }
}
