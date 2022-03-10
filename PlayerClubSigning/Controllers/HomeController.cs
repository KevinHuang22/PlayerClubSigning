using Microsoft.AspNetCore.Mvc;
using PlayerClubSigning.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using PlayerClubSigning.Models;
using Microsoft.EntityFrameworkCore;

namespace PlayerClubSigning.Controllers
{
    public class HomeController : Controller
    {
        private readonly PlayerClubContext _context;
        public HomeController(PlayerClubContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}
