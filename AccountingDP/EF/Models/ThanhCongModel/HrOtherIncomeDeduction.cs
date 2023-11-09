using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class HrOtherIncomeDeduction
{
    /// <summary>
    /// có 5 loại: tiền thiếu thu ngân (TIENTHIEUTHUNGAN), Tiền phạt vi phạm quy chế (TIENPHATQUYCHE), Trừ tiền thiếu thế chấp (TIENTHIEUTHECHAP), Tiền thưởng (TIENTHUONG), Thu nhập khác (THUNHAPKHAC)
    /// </summary>
    public string IncomeDeductionType { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    /// <summary>
    /// Ngày trong tháng
    /// </summary>
    public string IncomeDeductionMonth { get; set; } = null!;

    public decimal? IncomeDeductionValue { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string SyncTime { get; set; } = null!;
}
