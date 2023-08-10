using Microsoft.AspNetCore.Mvc;
using Person.Data;
using Person.Models;

namespace Person.Controllers
{
	public class FamilyController : Controller
	{
		private readonly ApplicationDbContext _Context;

		public FamilyController(ApplicationDbContext Context)
		{
			_Context = Context;
		}
		public IActionResult Index()
		{
			var l = _Context.Families.ToList();
			return View(l);
		}
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Family model)
		{
            var hobbies = Request.Form["Hobbies"];
            model.Hobbies = hobbies;


            _Context.Families.Add(model);
			_Context.SaveChanges();

			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult Edit(int id)
		{
			var E = _Context.Families.Find(id);
			return View(E);
		}
		[HttpPost]
		public IActionResult Edit(Family Ed)
		{
			_Context.Families.Update(Ed);
			_Context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult Delete(int id)
		{
			var Del= _Context.Families.Find(id);
			return View(Del);
		}
		[HttpPost]
		public IActionResult Delete(Family del)
		{
			_Context.Families.Remove(del);
			_Context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}

