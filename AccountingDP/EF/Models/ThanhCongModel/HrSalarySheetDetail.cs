﻿using System;
using System.Collections.Generic;

namespace AccountingDP.EF.Models.ThanhCongModel;

public partial class HrSalarySheetDetail
{
    public Guid SalaryDetailId { get; set; }

    public string SalarySheetId { get; set; } = null!;

    public string? TransDate { get; set; }

    public string CustomerId { get; set; } = null!;

    /// <summary>
    /// Thời gian đi muộn về sớm tính theo phút
    /// </summary>
    public int? NumOfWorkingDays { get; set; }

    /// <summary>
    /// Thời gian đi muộn về sớm tính theo phút
    /// </summary>
    public int? NumOfDayOfSalary { get; set; }

    /// <summary>
    /// Thời gian đi muộn về sớm tính theo phút
    /// </summary>
    public decimal? NumOfOtherWorkingDays { get; set; }

    /// <summary>
    /// Thời gian đi muộn về sớm tính theo phút
    /// </summary>
    public int? NumOfTardinessLeaveEarlyOrg { get; set; }

    /// <summary>
    /// Thời gian đi muộn về sớm tính theo phút
    /// </summary>
    public int? NumOfTardinessLeaveEarly { get; set; }

    /// <summary>
    /// Thời gian đi muộn về sớm tính theo phút
    /// </summary>
    public int? NumOfOverTime { get; set; }

    public decimal? BaseSalary { get; set; }

    public decimal? SaleSalary { get; set; }

    public decimal? CriteriaSalary { get; set; }

    public decimal? ResponsibilitySalary { get; set; }

    public decimal? LostGoodsSalary { get; set; }

    public decimal? OverTimeSalary { get; set; }

    public decimal? PrizeMoney { get; set; }

    public decimal? OtherIncome { get; set; }

    public decimal? SalaryProfit { get; set; }

    public decimal? MortgageProfit { get; set; }

    public decimal? TotalBenefit { get; set; }

    public decimal? SocialInsuranceEmp { get; set; }

    public decimal? UnemploymentInsuranceEmp { get; set; }

    public decimal? HealthInsuranceEmp { get; set; }

    public decimal? LostGoodsKeeping { get; set; }

    public decimal? ResponsibilityKeeping { get; set; }

    public decimal? CashShortOfCashier { get; set; }

    public decimal? RuleViolation { get; set; }

    public decimal? ShortOfMortgage { get; set; }

    public decimal? TardinessLeaveEarlyPenalty { get; set; }

    public decimal? ActuallyReceived { get; set; }

    public decimal? The13thMonthSalary { get; set; }

    public decimal? SocialInsuranceCom { get; set; }

    public decimal? UnemploymentInsuranceCom { get; set; }

    public decimal? HealthInsuranceCom { get; set; }

    public decimal? PersonalIncomeTax { get; set; }

    public decimal? TotalCostOfSalary { get; set; }

    public decimal? UnionExpenses { get; set; }

    public decimal? UnionExpensesEmp { get; set; }

    public string? Description { get; set; }

    public int? Sort { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Status { get; set; }

    public string? SynStatus { get; set; }

    public string? Time { get; set; }

    public string? SyncTime { get; set; }
}
