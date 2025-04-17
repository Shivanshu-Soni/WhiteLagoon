using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WhiteLagoon.Infrastructure.Data;
using WhiteLagoon.Web.Models;

namespace WhiteLagoon.Web.Controllers
{
    [Route("[controller]")]
    public class VillaController : Controller
    {
        private readonly ILogger<VillaController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public VillaController(ILogger<VillaController> logger, ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            var villas = _dbContext.Villas.ToList();
            return View(villas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        [HttpGet("Error")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}