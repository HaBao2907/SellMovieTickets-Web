using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using eTickets.Data.Base;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Authorization;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
		private readonly IMoviesService _service;

		public MoviesController(IMoviesService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
		{
			var allMovies = await _service.GetAllAsync(n => n.Cinema);
            return View(allMovies);
		}
	}
}
