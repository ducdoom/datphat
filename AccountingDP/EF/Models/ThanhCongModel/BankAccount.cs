﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

/// <summary>
/// Danh mục Tài khoản ngân hàng
/// </summary>
public partial class BankAccount
{
    /// <summary>
    /// Mã ngân hàng của Khách hàng, nếu trống thì là mã của đơn vị đang sử dụng phần mềm.
    /// </summary>
    public string? CustomerId { get; set; }

    /// <summary>
    /// Số tài khoản ngân hàng
    /// </summary>
    public string BankAccountNumber { get; set; } = null!;

    /// <summary>
    /// Chủ tài khoản
    /// </summary>
    public string? AccountHolder { get; set; }

    /// <summary>
    /// Ngân hàng
    /// </summary>
    public Guid? BankId { get; set; }

    /// <summary>
    /// Nơi mở: ví dụ Ngân hàng VCB chi nhánh 01
    /// </summary>
    public string? BankName { get; set; }

    public string? BankBrand { get; set; }

    /// <summary>
    /// Địa chỉ nơi mở
    /// </summary>
    public string? Address { get; set; }

    public string? ProvinceOrCity { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Ngừng theo dõi
    /// </summary>
    public bool Inactive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }

    /// <summary>
    /// Cờ báo là tài khoản của hệ thống công ty đang sử dụng phần mềm 0 là của khách hàng, 1 là của hệ thống
    /// </summary>
    public bool? SystemFlag { get; set; }

    /// <summary>
    /// Cờ báo là tài khoản chính mặc định được sử dụng cho đơn vị tổ chức đó.
    /// </summary>
    public bool? MainFlag { get; set; }

    public virtual Bank? Bank { get; set; }
}
