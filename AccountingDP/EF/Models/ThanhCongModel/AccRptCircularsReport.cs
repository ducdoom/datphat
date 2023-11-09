﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class AccRptCircularsReport
{
    public Guid CircularsKey { get; set; }

    public string? CircularsNumber { get; set; }

    public string? FormNumber { get; set; }

    public string? DescriptionDetail { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public string? FormulaCurrent { get; set; }

    public string? FormulaLast { get; set; }

    public string? ConditionAcount { get; set; }

    public string? IncidentSign { get; set; }

    public string? ValueSign { get; set; }

    public string? Negative { get; set; }

    public string? TypeOper { get; set; }

    public string? SyncTime { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public decimal? RptOrder { get; set; }

    /// <summary>
    /// N là bình thường, I là nghiêng, B là đậm, U là gạch chân
    /// </summary>
    public string? FontStyle { get; set; }

    /// <summary>
    /// Cỡ font chữ
    /// </summary>
    public int? FontSize { get; set; }

    /// <summary>
    /// Màu chữ
    /// </summary>
    public string? FontColor { get; set; }
}
