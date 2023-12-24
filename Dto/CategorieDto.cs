using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class CategorieDto : IDto
    {
        public int Id { get; set; }
        public string CategorieName { get; set; }     
    }
}
