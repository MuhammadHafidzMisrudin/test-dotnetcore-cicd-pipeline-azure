namespace Dashboard.Models;

public class DashboardStats
{
    public decimal TotalRevenue { get; set; }
    public int TotalOrders { get; set; }
    public int TotalCustomers { get; set; }
    public double ConversionRate { get; set; }

    public List<MonthlySales> SalesByMonth { get; set; } = new();
    public List<RecentOrder> RecentOrders { get; set; } = new();
}

public class MonthlySales
{
    public string Month { get; set; } = string.Empty;
    public decimal Amount { get; set; }
}

public class RecentOrder
{
    public int Id { get; set; }
    public string Customer { get; set; } = string.Empty;
    public string Product { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Status { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}
