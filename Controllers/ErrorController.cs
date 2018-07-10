using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetapi.Models;

namespace dotnetapi.Controllers
{
    // [ApiController]
    public class ErrorController : Controller
    {
        public ActionResult<IEnumerable<string>> MethodNotFound()
        {
            // string[] = 
            return new string[] { "API Method doesnt exist" };
        }
    }
}