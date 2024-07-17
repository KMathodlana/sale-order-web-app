namespace SalesOrderWebApp.Models
{
    public class OrderLine
    {
        public int OrderId { get; set; }
        public int OrderLineNumber { get; set; }
        public string? ProductCode { get; set; }
        public byte ProductType { get; set; }
        public decimal ProductCostPrice { get; set; }
        public decimal ProductSalesPrice { get; set; }
        public int Quantity { get; set; }
    }
}
