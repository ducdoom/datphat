﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ContractAppendix
{
    public Guid ContractId { get; set; }

    /// <summary>
    /// ID phụ lục hợp đồng.
    /// </summary>
    public Guid AppendixContractId { get; set; }

    public string? AppendixName { get; set; }

    public string? ZoneId { get; set; }

    /// <summary>
    /// Số phụ lục HĐ = Số HĐ+ Số thứ tự của phụ lục (Cộng String)
    /// </summary>
    public string? AppendixNumber { get; set; }

    public string? AppendixSignDate { get; set; }

    /// <summary>
    /// Ngày hết hạn phụ lục
    /// </summary>
    public string? AppendixExpiredDate { get; set; }

    /// <summary>
    /// Ngày ra hạn
    /// </summary>
    public string? ExtentDate { get; set; }

    /// <summary>
    /// Số ngày ra hạn thêm hợp đồng
    /// </summary>
    public int? ExtentNumberDay { get; set; }

    public decimal? TotalAppendixAmount { get; set; }

    public decimal? TotalAppendixAmountOc { get; set; }

    public int? AppendixDebtDay { get; set; }

    public decimal? AppendixDebtLimit { get; set; }

    public decimal? AppendixDebtLimitOc { get; set; }

    /// <summary>
    /// Mô tả chi tiết phụ lục hợp đồng nếu có
    /// </summary>
    public string? AppendixDetail { get; set; }

    public bool? EnableSchedule { get; set; }

    public string? ScheduleType { get; set; }

    public string? ScheduleValue { get; set; }

    /// <summary>
    /// Trạng thái: 0 đã thanh lý không còn hiệu lực, 1 còn hiệu lực,2: chưa thanh lý nhưng quá hạn.
    /// </summary>
    public string? AppendixStatus { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? SyncTime { get; set; }
}
