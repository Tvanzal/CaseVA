using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VACase.WebApi.Models;

namespace VACase.WebApi.Datamappers
{
    public class SquareDataMapper : IDataMapper<Square, long>
    {
        public IEnumerable<Square> GetAll()
        {
            using(var context = new VACaseWebApiContext())
            {
                return context.Squares;
            }
        }

        public Square Insert(Square entity)
        {
            using (var context = new VACaseWebApiContext())
            {
                context.Squares.Add(entity);
                context.SaveChanges();
                return entity;
            }
        }
    }
}
