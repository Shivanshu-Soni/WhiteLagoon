using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;
using WhiteLagoon.Web.Models;

namespace WhiteLagoon.Web.Controllers
{
    [Route("[controller]")]
    public class VillaController(ILogger<VillaController> logger, ApplicationDbContext dbContext) : Controller
    {
        private readonly ILogger<VillaController> _logger = logger;
        private readonly ApplicationDbContext _dbContext = dbContext;

        [HttpGet("Index")]
        public IActionResult Index()
        {
            var villas = _dbContext.Villas.ToList(); 
            return View(villas);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Villa villa)
        {
            ArgumentNullException.ThrowIfNull(villa);
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Name", "Name must not be empty");
            }
            else 
            {
                _dbContext.Villas.Add(villa);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(villa);
        }

        }
}