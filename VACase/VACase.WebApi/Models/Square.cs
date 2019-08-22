using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VACase.WebApi.Models
{
    public class Square
    {
        [Key]
        public long Id { get; set; }
        public Square Top { get; set; }
        public Square Left { get; set; }
        public Square Right { get; set; }
        public Square Bottom { get; set; }


    }
}
