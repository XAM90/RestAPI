using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPITask.Models
{
    public class ProductsCreateDto : ProductForManipulationDto
    {
        public Guid Id { get; set; }

    }
}
