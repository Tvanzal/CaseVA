using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VACase.Server.Models
{
    public class Square
    {
        public Square Top { get; set; }
        public Square Left { get; set; }
        public Square Right { get; set; }
        public Square Bottom { get; set; }

        public Square()
        {

        }
    }
}
