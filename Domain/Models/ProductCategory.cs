namespace Domain.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ProductTypeId { get; set; }
        public int SortOrder { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ProductType ProductType { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; }
    }
}
