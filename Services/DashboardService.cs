using Dashboard.Models;

namespace Dashboard.Services;

// Returns in-memory sample data so the dashboard has something to render
// out of the box. Swap this out for a real data source later.
public class DashboardService : IDashboardService
{
    public DashboardStats GetStats()
    {
        return new DashboardStats
        {
            TotalRevenue = 128450.75m,
            TotalOrders = 842,
            TotalCustomers = 356,
            ConversionRate = 3.42,
            SalesByMonth = new List<MonthlySales>
            {
                new() { Month = "Apr", Amount = 14200 },
                new() { Month = "May", Amount = 16800 },
                new() { Month = "Jun", Amount = 15100 },
                new() { Month = "Jul", Amount = 19400 },
                new() { Month = "Aug", Amount = 21900 },
                new() { Month = "Sep", Amount = 24050 },
            },
            RecentOrders = new List<RecentOrder>
            {
                new() { Id = 1041, Customer = "Ayu Lestari", Product = "Wireless Mouse", Amount = 129.99m, Status = "Completed", Date = DateTime.Today.AddDays(0) },
                new() { Id = 1040, Customer = "Budi Santoso", Product = "Mechanical Keyboard", Amount = 349.00m, Status = "Processing", Date = DateTime.Today.AddDays(-1) },
                new() { Id = 1039, Customer = "Citra Wijaya", Product = "USB-C Hub", Amount = 89.50m, Status = "Completed", Date = DateTime.Today.AddDays(-1) },
                new() { Id = 1038, Customer = "Dedi Rahman", Product = "27\" Monitor", Amount = 899.00m, Status = "Shipped", Date = DateTime.Today.AddDays(-2) },
                new() { Id = 1037, Customer = "Eka Putri", Product = "Laptop Stand", Amount = 59.90m, Status = "Cancelled", Date = DateTime.Today.AddDays(-3) },
                new() { Id = 1036, Customer = "Fajar Nugroho", Product = "Webcam 1080p", Amount = 149.00m, Status = "Completed", Date = DateTime.Today.AddDays(-4) },
            }
        };
    }
}
