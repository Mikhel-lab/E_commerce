using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_commerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Areas.Admin.Controllers
{
	[Authorize(Roles = "Admin", AuthenticationSchemes ="Admin_Schema")]
	[Area("admin")]
	[Route("admin/invoice")]
	public class InvoiceController : Controller
	{

		private DatabaseContext db = new DatabaseContext();
		public InvoiceController(DatabaseContext _db)
		{
			db = _db;
		}

		[Route("")]
		[Route("index")]
		public IActionResult Index()
		{
			ViewBag.invoices = db.Invoices.OrderByDescending(i => i.Id).ToList();
			return View();
		}


		[HttpGet]
		[Route("details/{id}")]
		public IActionResult Details(int id)
		{
			ViewBag.invoice = db.Invoices.Find(id);
			return View("Details");
		}


	}
}
