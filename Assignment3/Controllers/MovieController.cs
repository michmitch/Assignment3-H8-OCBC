using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment3.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;

        public MovieController(MovieContext context)
        {
            this._context = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public ActionResult<IEnumerable<MovieItem>> GetAllMovies()
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.GetAllMovies();
        }

        // GET api/<controller>/5
        [HttpGet("{id}", Name ="Get")]
        public ActionResult<IEnumerable<MovieItem>> GetMovie(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.GetMovie(id);
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult<IEnumerable<MovieItem>> InsertMovie(MovieItem movie)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            // DateTime releasedateconvert = Convert.ToDateTime(releasedate);
            return _context.InsertMovie(movie);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<MovieItem>> UpdateMovie(string id, MovieItem movie)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.UpdateMovie(id, movie);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<MovieItem>> DeleteMovie(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(MovieContext)) as MovieContext;
            return _context.DeleteMovie(id);
        }
    }
}
