﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _425ShowWebsite.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public bool IsProd{ get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
