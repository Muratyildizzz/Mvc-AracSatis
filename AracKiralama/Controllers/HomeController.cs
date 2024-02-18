using AracSatis.Business.Abstract;
using AracSatis.Entities;
using AracSatis.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AracSatis.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService<Slider> _service;
        private readonly ICarService _serviceArac;

        public HomeController(IService<Slider> service, ICarService serviceArac)
        {
            _service = service;
            _serviceArac = serviceArac;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = new HomePageViewModel()
            {
                Sliderlerr = await _service.GetAllAsync(),
                Aracs = await _serviceArac.GetCustomCarList(a=>a.Anasayfa)
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("AccesDenied")]
        public IActionResult AccesDenied()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}