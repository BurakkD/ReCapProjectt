using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFrame;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
   
    public class CarsController : ControllerBase
    {


        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            return Ok(result);

            
        }
        [HttpGet("brandId")]
        public IActionResult BrandId()
        {
            var result = _carService.GetCarsByBrandId(2);
            return Ok(result);
        }

        [HttpGet("colorId")]
        public IActionResult ColorId()
        {
            var result = _carService.GetCarsByColorId(3);
            return Ok(result);

        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            return Ok(result);

        }
        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            return Ok(result);

        }

    }
}
