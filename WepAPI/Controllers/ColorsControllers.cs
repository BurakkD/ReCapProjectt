using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrame;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsControllers : ControllerBase
    {
        IColorService _colorService;
        
        public ColorsControllers(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet]
        public IActionResult Getall()
        {

            var result = _colorService.GetAll();

            return Ok(result);



        }
    }
}

