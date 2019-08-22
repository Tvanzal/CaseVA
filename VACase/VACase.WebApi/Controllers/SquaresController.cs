using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using VACase.WebApi.Datamappers;
using VACase.WebApi.Models;

namespace VACase.WebApi.Controllers
{
    public class SquaresController : ApiController
    {
        IDataMapper<Square, long> SquareDataMapper { get; }

        public SquaresController()
        {
            //Rather do with DI
            SquareDataMapper = new SquareDataMapper();
        }
        // GET: api/Squares
        public IEnumerable<Square> GetSquares()
        {
            return SquareDataMapper.GetAll();
        }

        // GET: api/Squares/5
        //[ResponseType(typeof(Square))]
        //public IHttpActionResult GetSquare(long id)
        //{
        //    Square square = db.Squares.Find(id);
        //    if (square == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(square);
        //}

        // PUT: api/Squares/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutSquare(long id, Square square)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != square.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(square).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SquareExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        // POST: api/Squares
        [ResponseType(typeof(Square))]
        public IHttpActionResult PostSquare(Square square)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            SquareDataMapper.Insert(square);

            return CreatedAtRoute("DefaultApi", new { id = square.Id }, square);
        }

        //// DELETE: api/Squares/5
        //[ResponseType(typeof(Square))]
        //public IHttpActionResult DeleteSquare(long id)
        //{
        //    Square square = db.Squares.Find(id);
        //    if (square == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Squares.Remove(square);
        //    db.SaveChanges();

        //    return Ok(square);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool SquareExists(long id)
        //{
        //    return db.Squares.Count(e => e.Id == id) > 0;
        //}
    }
}