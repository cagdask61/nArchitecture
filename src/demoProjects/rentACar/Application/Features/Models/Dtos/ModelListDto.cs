using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Models.Dtos
{
    public class ModelListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public bool BrandIsApproved { get; set; }
    }
}
