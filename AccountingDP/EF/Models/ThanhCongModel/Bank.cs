﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

/// <summary>
/// Danh mục ngân hàng
/// </summary>
public partial class Bank
{
    /// <summary>
    /// Khoá chính
    /// </summary>
    public Guid BankId { get; set; }

    /// <summary>
    /// Tên viết tắt
    /// </summary>
    public string BankCode { get; set; } = null!;

    /// <summary>
    /// Tên ngân hàng đầy đủ
    /// </summary>
    public string? BankName { get; set; }

    /// <summary>
    /// Tên ngân hàng đầy đủ tiếng anh
    /// </summary>
    public string? BankNameEnglish { get; set; }

    /// <summary>
    /// Địa điểm hội sở chính
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Diễn giải
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Icon
    /// </summary>
    public byte[]? Icon { get; set; }

    /// <summary>
    /// Ngừng theo dõi
    /// </summary>
    public bool Inactive { get; set; }

    /// <summary>
    /// Người tạo
    /// </summary>
    public string? CreatedBy { get; set; }

    /// <summary>
    /// Ngày tạo
    /// </summary>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Người sửa
    /// </summary>
    public string? UpdatedBy { get; set; }

    /// <summary>
    /// Ngày sửa
    /// </summary>
    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();
}
