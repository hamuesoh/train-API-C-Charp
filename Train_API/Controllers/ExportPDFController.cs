using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Train_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportPDFController : Controller
    {
        // GET: ExportPDFController
        [HttpGet]
        [Route("gett")]
        public String Index()
        {
            return "55555555555";
        }
    }
}
