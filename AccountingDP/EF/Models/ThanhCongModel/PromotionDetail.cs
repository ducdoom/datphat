﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class PromotionDetail
{
    public string PromotionId { get; set; } = null!;

    /// <summary>
    /// có các giá trị: KM theo Mã hàng, Ngành Hàng, Nhóm Hàng, Nhà cung cấp
    /// </summary>
    public string? PromoTypeDetail { get; set; }

    /// <summary>
    /// giá trị mã hàng hoặc mã nhóm, mã ngành, mã NCC được khuyến mại
    /// </summary>
    public string PromoCode { get; set; } = null!;

    /// <summary>
    /// Nội dung được Khuyến mại, nếu là khyến mại bằng tiền thì điền số tiền nếu đạt sẽ được khuyến mại, nếu là khuyến mại bằng hàng thì điền số lượng hàng đạt sẽ được khuyến mại
    /// </summary>
    public string? PromoValues { get; set; }

    /// <summary>
    /// Nếu là KM bằng hàng thì mã hàng sẽ được tặng.
    /// </summary>
    public string PromoPayCode { get; set; } = null!;

    /// <summary>
    /// Số lượng hàng được tặng nếu là KM hàng tặng hàng, giá trị tiền hoặc % giảm giá nếu là hàng tặng tiền.
    /// </summary>
    public string? PromoPayValues { get; set; }

    /// <summary>
    /// Số lượng hoặc giá trị tối đa được tặng nếu để là 0 nghĩa là không giới hạn.
    /// </summary>
    public string? PromoPayMaxValues { get; set; }

    /// <summary>
    /// Mã kho xuất hàng khuyến mại ở trường PromoPayCode nếu là khuyến mại hàng tặng hàng.
    /// </summary>
    public string? PromoPayStock { get; set; }

    public string? SyncTime { get; set; }
}
