using BasitVeriTabanıBağlantısı.Context;
using BasitVeriTabanıBağlantısı.DataModel;
using BasitVeriTabanıBağlantısı.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BasitVeriTabanıBağlantısı.Controllers
{
    public class HomeController : Controller
    {

        public AuthenticationContext _context;
        public HomeController(AuthenticationContext context)
        {

            _context = context;
        }

        [HttpGet]
        public IActionResult Save(string hata)
        {
            return View();

        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();

        }
        [HttpPost]
        public IActionResult Login(Auth model)
        {

            bool isok =_context.Auths.Any(s => s.Email == model.Email && s.Password == model.Password);


            if (isok)
            {

                // redirect direk bir adrese yönlenmeyi sağlar.
                return Redirect("http:www.google.com");
                

            }
            else { 
                // Redirect to action metodu her hangi bir action içerisinden, farklı bir controller yada action'a yönlenmek için kullanılabilir.
                // Aynı zamanada parametre gönderimi de yapabilmektedir.
                return RedirectToAction("Save", new { hata = "Kullanıcı bulunamadı" });
            }
          

        }

        [HttpPost]
        public IActionResult Save(Auth model)
        {

            _context.Auths.Add(model);
            _context.SaveChanges();

            return View(model);

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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