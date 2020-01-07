using Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        // GET: /<controller>/
        public List<ProductDto> Get()
        {
            return new List<ProductDto>
            {
                new ProductDto
                {
                    Name = "Test"
                }
            };
        }
    }
}
