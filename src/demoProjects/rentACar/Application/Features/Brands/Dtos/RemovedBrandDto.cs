using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Dtos
{
    public class RemovedBrandDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
