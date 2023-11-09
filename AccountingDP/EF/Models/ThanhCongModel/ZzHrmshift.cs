﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ZzHrmshift
{
    public int ShiftId { get; set; }

    /// <summary>
    /// Mã kí hiệu ca
    /// </summary>
    public string? ShiftCode { get; set; }

    /// <summary>
    /// Giờ vào làm việc
    /// </summary>
    public string? Onduty { get; set; }

    /// <summary>
    /// Giờ kết thúc làm việc
    /// </summary>
    public string? Offduty { get; set; }

    /// <summary>
    /// Đếm công theo số ngày
    /// </summary>
    public byte? DayCount { get; set; }

    /// <summary>
    /// Số phút trước giờ vào bắt đầu tính checkin
    /// </summary>
    public int? OnTimeIn { get; set; }

    /// <summary>
    /// Số phút sau giờ vào bắt đầu tính checkin
    /// </summary>
    public int? OnTimeOut { get; set; }

    /// <summary>
    /// Số phút trước giờ ra bắt đầu tính checkOut
    /// </summary>
    public int? CutIn { get; set; }

    /// <summary>
    /// Số phút sau giờ ra bắt đầu tính checkOut
    /// </summary>
    public int? CutOut { get; set; }

    /// <summary>
    /// Giờ ra ăn trưa nếu có
    /// </summary>
    public string? OnLunch { get; set; }

    /// <summary>
    /// Giờ kết thúc ăn trưa nếu có
    /// </summary>
    public string? OffLunch { get; set; }

    /// <summary>
    /// Tổng thời gian làm việc được tính
    /// </summary>
    public float? WorkingTime { get; set; }

    /// <summary>
    /// đếm số công
    /// </summary>
    public float? Workingday { get; set; }

    /// <summary>
    /// Là ca qua đêm 0 là không phải 1 là có.
    /// </summary>
    public bool? IsNightTime { get; set; }

    /// <summary>
    /// Ca qua đêm tách giờ đêm từ giờ này.
    /// </summary>
    public string? StartNt { get; set; }

    /// <summary>
    /// Ca qua đêm tách giờ đêm đến giờ này.
    /// </summary>
    public string? EndNt { get; set; }
}
