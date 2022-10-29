namespace Domain.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductId { get; set; } = null!;
        public int? OldProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string ShortName { get; set; } = null!;
        public string? Description { get; set; }
        public long StartDate { get; set; }
        public long? EndDate { get; set; }
        public string VersionNo { get; set; } = null!;
        public string Status { get; set; } = null!;
        public double? SavingPercentage { get; set; }
        public int MaxDisburseNumber { get; set; }
        public bool IsIncludedInCollectionSheet { get; set; }
        public bool IsIncludedInLoanCycleCounter { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsSupplimentary { get; set; }
        public DateTime? StatusChangedDate { get; set; }
        public bool IsVaryingRate { get; set; }
        public int? InterestCalculationPeriod { get; set; }
        public string? InterestCalculationMethod { get; set; }
        public int? InterestRatePeroid { get; set; }
        public string? Amortization { get; set; }
        public int StrategyId { get; set; }
        public int MinimumMemberLoanCycle { get; set; }
        public double? MaxOverdueOfOtherLoan { get; set; }
        public double? MaxOutstandingOfOtherLoan { get; set; }
        public string? Notes { get; set; }
        public double? DefaultDeclineInterestRate { get; set; }
        public double? DefaultFlatInterestRate { get; set; }
        public double? MinimumPrincipal { get; set; }
        public double? MaximumPrincipal { get; set; }
        public double? DefaultPrincipal { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public double? RequiredPercentageSavingsBalance { get; set; }
        public string? SavingsProductsId { get; set; }
        public int? PrincipleAmountMultipleOf { get; set; }
        public bool? IsRebatable { get; set; }
        public double? RebatePercentage { get; set; }
        public double? RequiredPercentageSavingsBalanceWithDisburse { get; set; }

        public virtual ProductCategory ProductCategory { get; set; } = null!;
    }
}
