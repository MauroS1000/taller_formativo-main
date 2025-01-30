using DesignPatterns.Factories;
using DesignPatterns.Interfaces;
using DesignPatterns.Models;
using DesignPatterns.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace DesignPatterns.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly CarFactoryProvider _factoryProvider;

        public HomeController(
            IVehicleRepository vehicleRepository,
            ILogger<HomeController> logger,
            CarFactoryProvider factoryProvider)
        {
            _vehicleRepository = vehicleRepository;
            _logger = logger;
            _factoryProvider = factoryProvider;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel();
            model.Vehicles = _vehicleRepository.GetVehicles();
            ViewBag.ErrorMessage = Request.Query.ContainsKey("error")
                ? Request.Query["error"].ToString()
                : null;

            return View(model);
        }

        [HttpGet]
        public IActionResult AddVehicle(string vehicleType)
        {
            try
            {
                var factory = _factoryProvider.GetFactory(vehicleType);
                var vehicle = factory.Create();
                _vehicleRepository.AddVehicle(vehicle);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding vehicle");
                return RedirectToAction("Index", new { error = ex.Message });
            }
        }

        // Métodos originales para operaciones con vehículos (sin cambios)
        [HttpGet]
        public IActionResult StartEngine(string id)
        {
            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.StartEngine();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error starting engine");
                return RedirectToAction("Index", new { error = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult AddGas(string id)
        {
            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.AddGas();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding gas");
                return RedirectToAction("Index", new { error = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult StopEngine(string id)
        {
            try
            {
                var vehicle = _vehicleRepository.Find(id);
                vehicle.StopEngine();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error stopping engine");
                return RedirectToAction("Index", new { error = ex.Message });
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}