namespace SalesOrderWebApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public required string OrderNumber { get; set; }
        public byte OrderType { get; set; }
        public int OrderStatus { get; set; }
        public required string CustomerName { get; set; }
        public DateTime CreatedDateTimeUtc { get; set; }
        public required OrderLine LineItem { get; set; }
    }
}
