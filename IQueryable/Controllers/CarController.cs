using AspNetCore.IQueryable.Extensions;
using AspNetCore.IQueryable.Extensions.Filter;
using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using IQueryable.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IQueryable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] Car query)
        {
            //var jsonData = CarRepository.GetCar().AsQueryable().Filter(query).Paginate(query).Sort(query);
            var jsonData = CarRepository.GetCar().AsQueryable().Apply(query);

            return Ok(jsonData);
        }
    }
}
