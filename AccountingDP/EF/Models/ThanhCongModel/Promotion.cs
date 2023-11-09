﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class Promotion
{
    public string PromotionId { get; set; } = null!;

    public string? PromotionName { get; set; }

    public string? FromDate { get; set; }

    public string? ToDate { get; set; }

    public string? FromTime { get; set; }

    public string? ToTime { get; set; }

    /// <summary>
    /// có 4 loại 1 là hàng tặng hàng, 2 là hàng tặng tiền, 3 là đơn đạt một giá trị nào đó (PromoValues) tặng tiền, 4 là đơn đạt một giá trị nào đó (PromoValues) tặng hàng
    /// </summary>
    public string? PromotionType { get; set; }

    /// <summary>
    /// 1 cho bán lẻ, 2 cho bán buôn, 3 cho cả bán lẻ và bán buôn
    /// </summary>
    public string? PromoApplyForSale { get; set; }

    /// <summary>
    /// 1 là bao gồm với các khuyến mại khác nếu có, 1 là không tính cùng các KM khác nếu đồng thời có nhiều chương trình Khuyến mại
    /// </summary>
    public bool? PromoInclude { get; set; }

    public int? Priority { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? SyncTime { get; set; }
}
