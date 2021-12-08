using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class SendGrid : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public class AuthMessageSenderOptions
        {
            public string SendGridKey { get; set; }
        }
    }
}
