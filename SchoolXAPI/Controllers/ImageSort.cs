using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolXAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolXAPI.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class ImageSort : ControllerBase
    {
         private readonly ImageRepo _repo;

        public ImageSort(ImageRepo repo)
        {
            _repo = repo;
        }

        // GET: api/GetUserByOrder
        [HttpGet]
        public ActionResult GetUserByOrder(
            [FromQuery(Name ="type")] string type,
            [FromQuery(Name = "search")] string search,
            [FromQuery(Name = "sort")] string sort,
            [FromQuery(Name = "page")] int page
            )
        {
            return Ok(_repo.Query(type, search, sort, page));
        }
    }
}
