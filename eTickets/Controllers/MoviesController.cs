using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using eTickets.Data.Base;
using eTickets.Data.Services;
using eTickets.Models;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
		private readonly IMoviesService _service;

		public MoviesController(IMoviesService service)
        {
            _service = service;
        }
		public async Task<IActionResult> Index()
		{
			var allMovies = await _service.GetAllAsync();
			return View(allMovies);
		}

		//Get: Movie/Create
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create([Bind("Logo,Name,Description")] Movie movie)
		{
			if (!ModelState.IsValid)
			{
				return View(movie);
			}
			await _service.AddAsync(movie);
			return RedirectToAction(nameof(Index));
		}

		//Get: Movie/Details/1
		public async Task<IActionResult> Details(int id)
		{
			var MoviesDetails = await _service.GetByIdAsync(id);
			if (MoviesDetails == null)
			{
				return View("NotFound");
			}
			return View(MoviesDetails);
		}

		//Get: Movie/Update
		public async Task<IActionResult> Edit(int id)
		{
			var MoviesDetails = await _service.GetByIdAsync(id);
			if (MoviesDetails == null) return View("NotFound");
			return View(MoviesDetails);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, Movie movie)
		{
			if (!ModelState.IsValid)
			{
				return View(movie);
			}
			await _service.UpdateAsync(movie);
			return RedirectToAction(nameof(Index));
		}

		//Get: Movie/Delete/1
		public async Task<IActionResult> Delete(int id)
		{
			var MoviesDetails = await _service.GetByIdAsync(id);
			if (MoviesDetails == null) return View("NotFound");
			return View(MoviesDetails);
		}

		[HttpPost, ActionName("Delete")]
		public async Task<IActionResult> DeleteConfirm(int id)
		{
			var MoviesDetails = await _service.GetByIdAsync(id);
			if (MoviesDetails == null)
			{
				return View("NotFound");
			}
			await _service.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
