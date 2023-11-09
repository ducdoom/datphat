﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Customer
{
    public string CustomerId { get; set; } = null!;

    public string? TypeId { get; set; }

    public string? ZoneId { get; set; }

    public string? CusCardNo { get; set; }

    public string? IdcardNo { get; set; }

    public string? IdcardDate { get; set; }

    public string? IdcardLocation { get; set; }

    public string? Birthday { get; set; }

    public string? CustomerName { get; set; }

    public string? Agent { get; set; }

    public string? Taxcode { get; set; }

    public string? BankAccount { get; set; }

    public string? BankAddress { get; set; }

    public string? Address { get; set; }

    public string? Mobile { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Note { get; set; }

    public int? DebtDay { get; set; }

    public decimal? DebtLimit { get; set; }

    public string? ScheduleType { get; set; }

    public string? ScheduleValue { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public bool? EnableSchedule { get; set; }

    public string? ScheduleDetail { get; set; }

    /// <summary>
    /// Là khách hàng? 0 no  1 Yes
    /// </summary>
    public bool? IsCustomers { get; set; }

    /// <summary>
    /// Là Nhà cung cấp hàng hóa 0 - No,1 Yes
    /// </summary>
    public bool? IsSupply { get; set; }

    /// <summary>
    /// Là Nhân viên công ty, 0 - No, 1 Yes
    /// </summary>
    public bool? IsStaff { get; set; }

    /// <summary>
    /// Nếu IsStaff =1 thì có thể có UserID
    /// </summary>
    public string? UserId { get; set; }

    /// <summary>
    /// Nếu IsStaff =1 thì khai thêm ngày Bắt đầu làm việc
    /// </summary>
    public string? DateStartWorking { get; set; }

    /// <summary>
    /// Nếu IsStaff =1 thì điền thêm số chấm công
    /// </summary>
    public string? AttendanceId { get; set; }

    /// <summary>
    /// Số hợp đồng lao động
    /// </summary>
    public string? LaborContractNo { get; set; }

    public string? DepartmentId { get; set; }

    public bool? Gender { get; set; }

    public string? Title { get; set; }

    public int? NoOfDependentPeople { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    public virtual ICollection<Good> Goods { get; set; } = new List<Good>();

    public virtual CustomersType? Type { get; set; }
}
