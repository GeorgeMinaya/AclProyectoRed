using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Acl.RedModerno.Web.Controllers
{
    public class DinamicaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}