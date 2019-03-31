using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HostingTest.Models;
using HostingTest.Data.HostingTest.Model;
using Microsoft.AspNetCore.Identity;
using HostingTest.Data.Models;

namespace HostingTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly TesthostingContext Db;

        public HomeController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager, TesthostingContext _db)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            this.Db = _db;
        }

        public async Task<IActionResult> Index()
        {
            //IdentityResult result = null;
            //    var user = new ApplicationUser { UserName = "waseem@theta.com", Email = "waseem@theta.com", PhoneNumber = "03067488949" };
            //    result = await userManager.CreateAsync(user, "GCuf@6221");
            //    if (result.Succeeded)
            //    {

            //        var code = await userManager.GenerateEmailConfirmationTokenAsync(user);

            //    }
            Student s = new Student();
            s.Name = "Waseem";
            await Db.Student.AddAsync(s);
            Db.SaveChanges();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
