﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Order
{
    public string OrderId { get; set; } = null!;

    /// <summary>
    /// Nhân viên phụ trách
    /// </summary>
    public string? StaffInChargeId { get; set; }

    public string? TransCode { get; set; }

    public string ZoneId { get; set; } = null!;

    public string? ZoneName { get; set; }

    public string? ZoneAdress { get; set; }

    public string? OrderDate { get; set; }

    public string? DeliveryDate { get; set; }

    public string? ObjOrderId { get; set; }

    public string? ObjOrderName { get; set; }

    public string? SupplierId { get; set; }

    public string? SupplierName { get; set; }

    public string? UserId { get; set; }

    public decimal? TotalPrice { get; set; }

    public decimal? TotalVat { get; set; }

    public decimal? TotalPriceVat { get; set; }

    public decimal? TotalDiscount { get; set; }

    public string? Description { get; set; }

    public string? TransDate { get; set; }

    public string? OrdersStatus { get; set; }

    public string? OrderType { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
