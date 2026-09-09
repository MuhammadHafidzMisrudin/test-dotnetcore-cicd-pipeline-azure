using Dashboard.Models;

namespace Dashboard.Services;

public interface IDashboardService
{
    DashboardStats GetStats();
}
