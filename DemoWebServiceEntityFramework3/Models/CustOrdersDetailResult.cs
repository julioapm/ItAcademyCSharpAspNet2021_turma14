namespace DemoWebServiceEntityFramework3.Models;

public class CustOrdersDetailResult
{
    public string ProductName { get; set; } = null!;
    public decimal UnitPrice { get; set; }
    public short Quantity { get; set; }
    public int? Discount { get; set; }
    public decimal? ExtendedPrice { get; set; }
}