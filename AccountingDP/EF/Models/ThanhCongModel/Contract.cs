﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Contract
{
    public Guid ContractId { get; set; }

    public string? ContractName { get; set; }

    public string? ZoneId { get; set; }

    /// <summary>
    /// Mã HS Code đối với Hải quan
    /// </summary>
    public string? CustomBranchCode { get; set; }

    public string? ContractNumber { get; set; }

    /// <summary>
    /// Loại hợp đồng, nếu là 0 là  hợp đồng bình thường, nếu là 1 là hợp đồng nguyên tắc, chi tiết hàng hóa theo phụ lục hợp đồng
    /// </summary>
    public bool? ConTractType { get; set; }

    /// <summary>
    /// Loại hợp đồng 1 HĐ Mua, 2 HĐ bán.
    /// </summary>
    public int? ConTractGroupType { get; set; }

    public string? ContractSignDate { get; set; }

    public string? ContractExpiredDate { get; set; }

    /// <summary>
    /// Ngày ra hạn
    /// </summary>
    public string? ExtentDate { get; set; }

    /// <summary>
    /// Số ngày ra hạn thêm hợp đồng
    /// </summary>
    public int? ExtentNumberDay { get; set; }

    public decimal? TotalContractAmount { get; set; }

    public decimal? TotalContractAmountOc { get; set; }

    public int? ContractDebtDay { get; set; }

    public decimal? ContractDebtLimit { get; set; }

    public decimal? ContractDebtLimitOc { get; set; }

    /// <summary>
    /// Tỉ giá hối đoái
    /// </summary>
    public decimal? ExchangeRate { get; set; }

    public string? CurrencyId { get; set; }

    public string CustomerId { get; set; } = null!;

    /// <summary>
    /// Người đại diện
    /// </summary>
    public string? AgentName { get; set; }

    /// <summary>
    /// Chức vụ Người đại diện
    /// </summary>
    public string? AgentPosition { get; set; }

    /// <summary>
    /// Mô tả chi tiết hợp đồng nếu có
    /// </summary>
    public string? ContractDetail { get; set; }

    public bool? EnableSchedule { get; set; }

    public string? ScheduleType { get; set; }

    public string? ScheduleValue { get; set; }

    /// <summary>
    /// Trạng thái: 0 đã thanh lý không còn hiệu lực, 1 còn hiệu lực,2: chưa thanh lý nhưng quá hạn.
    /// </summary>
    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    /// <summary>
    /// Số lượng phụ lục Hợp Đồng
    /// </summary>
    public int? AppendixNumber { get; set; }

    public string? SyncTime { get; set; }
}
