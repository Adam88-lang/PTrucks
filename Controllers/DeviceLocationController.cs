using Microsoft.AspNetCore.Mvc;
using PTrucks.Models;
using PTrucks.Data;
using System.Collections.Generic;
using System.Linq;
namespace PTrucks.Controllers
{
    public class DeviceLocationController : Controller
    {
        private readonly PTDbContext _context;

        public DeviceLocationController(PTDbContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult GetDeviceLocations()
        {
            var devices = _context.DeviceLocations
                                  .OrderBy(d => d.MacAddress)
                                  .Select(device => new
                                  {
                                      device.Latitude,
                                      device.Longitude,
                                      device.MacAddress
                                  })
                                  .ToList();
            return Json(devices);
        }


        public IActionResult Map()
        {
            List<DeviceLocation> devices = _context.DeviceLocations.OrderBy(d => d.MacAddress).ToList();
            return View("Map", devices);
        }
    }
}
