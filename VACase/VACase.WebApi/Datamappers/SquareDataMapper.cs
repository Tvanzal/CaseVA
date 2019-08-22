using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VACase.Server.Models;

namespace VACase.Server.Datamappers
{
    public class SquareDataMapper : IDataMapper<Square, long>
    {
        public Square Insert(Square entity)
        {
            using (var conn = new MySqlConnection("server=localhost;user id=root;database=vacase"))
            {
                
                return entity;
            }
        }
    }
}
