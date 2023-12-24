using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class ProductDto : IDto
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }

    }
}
