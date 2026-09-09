using Dashboard.Models;
using Dashboard.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dashboard.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IDashboardService _dashboardService;

    public IndexModel(ILogger<IndexModel> logger, IDashboardService dashboardService)
    {
        _logger = logger;
        _dashboardService = dashboardService;
    }

    public DashboardStats Stats { get; set; } = new();

    public void OnGet()
    {
        Stats = _dashboardService.GetStats();
    }
}
