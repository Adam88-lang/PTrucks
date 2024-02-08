using Microsoft.AspNetCore.Mvc;
using PTrucks.Models;
using PTrucks.Data;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace PTrucks.Controllers
{
    public class DeviceLocationController : Controller
    {
        private readonly PTDbContext _context;

        public DeviceLocationController(PTDbContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Map()
        {
            List<DeviceLocation> devices = _context.DeviceLocations.OrderBy(d => d.MacAddress).ToList();
            return View("Map", devices);
        }
    }
}
