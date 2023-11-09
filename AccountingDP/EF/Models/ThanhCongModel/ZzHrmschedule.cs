﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ZzHrmschedule
{
    public Guid ScheduleId { get; set; }

    /// <summary>
    /// mã lịch
    /// </summary>
    public string? SchCode { get; set; }

    /// <summary>
    /// Tên lịch
    /// </summary>
    public string? Schname { get; set; }

    /// <summary>
    /// chọn kiểu lịch chấm công, weekly: theo tuần, monthly: theo tháng, yearly: theo năm
    /// </summary>
    public string? CycleMode { get; set; }

    /// <summary>
    /// Không tính vắng khi có xếp ca vào ngày lễ mà không đi làm 0 không xét vắng, 1 có xét vắng
    /// </summary>
    public bool? IsAbsentHol { get; set; }
}
