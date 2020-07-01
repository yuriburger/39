using System;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_csharp.Controllers
{
    [ApiController]
    [Route("/")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            return "Hello World!";
        }
    }
}
