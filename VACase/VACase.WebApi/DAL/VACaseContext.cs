using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VACase.Server.DAL
{
    class VACaseContext : DbContext
    {
        public VACaseContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }
    }
}
