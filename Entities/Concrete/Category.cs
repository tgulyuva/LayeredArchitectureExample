using System;
using System.Collections.Generic;
using System.Text;
using LayeredArchitectureExample.Core.Entities;

namespace LayeredArchitectureExample.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName{ get; set; }
    }
}
