using AracSatis.Business.Abstract;
using AracSatis.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AracSatis.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly IService<Kullanici> _service;
        private readonly IService<Rol> _serviceRol;

        public LoginController(IService<Kullanici> service, IService<Rol> serviceRol)
        {
            _service = service;
            _serviceRol = serviceRol;
        }

        public  IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Admin/Login");
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(string email,string password)
        {
            try
            {
                var account=_service.Get(k=>k.Email==email && k.Sifre==password && k.AktifMi==true);
                if(account==null)
                {
                    TempData["Mesaj"] = "Giriş Başarısız!";
                }
                else
                {
                    var rol=_serviceRol.Get(r=>r.Id==account.RolId);
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name,account.Adi)
                        
                    };
                    if(rol is not null)
                    {
                        claims.Add(new Claim("Role",rol.Adi));
                        claims.Add(new Claim(ClaimTypes.Role, rol.Adi));
                    }
                    var userIdentity=new ClaimsIdentity(claims,"Login");
                    ClaimsPrincipal principal=new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);
                    return Redirect("/Admin");
                }
            }
            catch (Exception)
            {
                TempData["Mesaj"] = "Hata Oluştu!";
             
            }
            return View();
        }
    }
}
