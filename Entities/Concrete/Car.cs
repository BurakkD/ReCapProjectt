
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Car:IEntity
    {

        public int Id { get; set; }
        public int BrandsId { get; set; }
        public int ColorsId { get; set; }
        public string Description { get; set; }
    }
}
