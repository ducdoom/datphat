﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class ZzHrmstaffInfor
{
    public string CustomerId { get; set; } = null!;

    public Guid? DepartmentId { get; set; }

    /// <summary>
    /// Giới tính, 0 Nữ, 1 Nam,2 Không xác định
    /// </summary>
    public string? Gender { get; set; }

    /// <summary>
    /// Lương theo bảo hiểm, nếu =0 thì không có bảo hiểm
    /// </summary>
    public decimal? SalaryByInsurance { get; set; }

    /// <summary>
    /// tỉ lệ cùng đóng tiền bảo hiểm với công ty.
    /// </summary>
    public decimal? SalaryByInsRate { get; set; }

    /// <summary>
    /// Lương theo hợp đồng với công ty theo tháng.
    /// </summary>
    public decimal? Salary { get; set; }

    /// <summary>
    /// Chức vụ
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// Lương theo doanh số,mặc định là không 0, 1 thì ăn theo doanh số quy định tại bảng StaffSalaryBySale
    /// </summary>
    public bool? SalaryBySale { get; set; }

    /// <summary>
    /// Lương ăn theo tiêu chí, nếu 1 thỉ ăn theo tiêu chí ở bảng StaffSalaryByCriteria,0 thì không theo tiêu chí
    /// </summary>
    public bool? SalaryByCriteria { get; set; }

    /// <summary>
    /// Các khoản giảm trừ lương
    /// </summary>
    public bool? SalaryDeductions { get; set; }

    /// <summary>
    /// Quốc tịch
    /// </summary>
    public string? Nationality { get; set; }

    /// <summary>
    /// Quê quán
    /// </summary>
    public string? Domicile { get; set; }

    /// <summary>
    /// tỉ lệ lương tăng khi đi làm ngày lễ
    /// </summary>
    public decimal? SalaryRateHoliday { get; set; }

    /// <summary>
    /// tỉ lệ lương tăng khi đi làm cuối tuần
    /// </summary>
    public decimal? SalaryRateEndWeek { get; set; }

    /// <summary>
    /// Số ngày nghỉ trên từng tháng
    /// </summary>
    public int? WorkOffPerMonth { get; set; }

    /// <summary>
    /// Công thức tính lương
    /// </summary>
    public string? PayrollFormula { get; set; }

    /// <summary>
    /// Mô tả vụ việc
    /// </summary>
    public string? Description { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
