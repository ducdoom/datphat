﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ZzHrmcheckInOut
{
    /// <summary>
    /// Số chấm công
    /// </summary>
    public int UserEnrollNumber { get; set; }

    /// <summary>
    /// Ngày giờ chấm công
    /// </summary>
    public DateTime TimeStr { get; set; }

    /// <summary>
    /// Ngày giờ
    /// </summary>
    public DateTime? TimeDate { get; set; }

    /// <summary>
    /// Loại lần chấm công, I là vào O là ra
    /// </summary>
    public string? OriginType { get; set; }

    /// <summary>
    /// Chuyển đổi từ loại I, O sang.
    /// </summary>
    public string? NewType { get; set; }

    /// <summary>
    /// Nguồn dữ liệu, FP là từ máy chấm công, MN là chấm công bằng tay.
    /// </summary>
    public string? Source { get; set; }

    /// <summary>
    /// Số máy chấm công
    /// </summary>
    public byte? MachineNo { get; set; }
}
