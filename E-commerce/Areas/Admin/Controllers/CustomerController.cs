using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_commerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Areas.Admin.Controllers
{
	[Authorize(Roles ="Admin", AuthenticationSchemes = "Admin_Schema")]
	[Area("admin")]
	[Route("admin/customer")]
	public class CustomerController : Controller
	{
		private DatabaseContext db = new DatabaseContext();
		public CustomerController(DatabaseContext _db)
		{
			db = _db;
		}

		[Route("")]
		[Route("index")]
		public IActionResult Index()
		{
			ViewBag.customers = db.Account.Where(a => a.RoleAccounts.FirstOrDefault().RoleId == 2).ToList();
			return View();
		}
	}
}
