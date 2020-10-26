﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using E_commerce.Models;
using E_commerce.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.Controllers
{
	[Route("customer")]
	public class CustomerController : Controller
	{
		private DatabaseContext db = new DatabaseContext();
		private SecurityManager security = new SecurityManager();

		public CustomerController(DatabaseContext _db)
		{
			db = _db;
		}


		[HttpGet]
		[Route("register")]
		public IActionResult Register()
		{
			var account = new Account();
			return View("Register", account);
		}


		[HttpPost]
		[Route("register")]
		public IActionResult Register(Account account)
		{
			var exist = db.Account.Count(a => a.Username.Equals(account.Username)) > 0;
			if (!exist)
			{
				account.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
				account.Status = true;
				db.Account.Add(account);
				db.SaveChanges();

				//Add Role Customer to New Account
				var roleAccount = new RoleAccount()
				{
					RoleId = 2,
					AccountId = account.Id,
					Status = true
				};
				db.RoleAccounts.Add(roleAccount);
				db.SaveChanges();
				return RedirectToAction("Login", "Account");
			}
			else
			{
				ViewBag.error = "Username has been taken already";
				return View("Register", account);
			}
			
		}

		[HttpGet]
		[Route("login")]
		public IActionResult Login()
		{	
			return View("Login");
		}

		[HttpPost]
		[Route("login")]
		public IActionResult Login(string username, string password)
		{
			var account = processLogin(username, password);
			if (account != null)
			{
				security.SignIn(this.HttpContext, account, "User_Schema");
				return RedirectToAction("dashboard", "customer");
			}
			else
			{
				ViewBag.error = "Invalid Account";
				return View("Login");
			}
		
		}

		private Account processLogin(string username, string password)
		{
			var account = db.Account.SingleOrDefault(a => a.Username.Equals(username) && a.Status == true);
			if (account != null)
			{
				var roleOfAccount = account.RoleAccounts.FirstOrDefault();
				if (roleOfAccount.RoleId == 2 && roleOfAccount.Status == true && BCrypt.Net.BCrypt.Verify(password, account.Password))
				{
					return account;
				}
			}
			return null;
		}

		[Route("signout")]
		public IActionResult SignOut()
		{
			security.SignOut(this.HttpContext, "User_Schema");
			return RedirectToAction("login", "customer");
		}

		[Authorize(Roles = "Customer", AuthenticationSchemes = "User_Schema")]
		[HttpGet]
		[Route("profile")]
		public IActionResult Profile()
		{
			var user = User.FindFirst(ClaimTypes.Name);
			var customer = db.Account.SingleOrDefault(a => a.Username.Equals(user.Value));
			return View("Profile", customer);
		}

		[Authorize(Roles = "Customer", AuthenticationSchemes = "User_Schema")]
		[HttpPost]
		[Route("profile")]
		public IActionResult Profile(Account account)
		{
			var currentCustomer = db.Account.Find(account.Id);
			if (!string.IsNullOrEmpty(account.Password))
			{
				currentCustomer.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
			}
			currentCustomer.FullName = account.FullName;
			currentCustomer.Email = account.Email;
			db.SaveChanges();
			return View("Profile", currentCustomer);
		}



		[Authorize(Roles = "Customer", AuthenticationSchemes = "User_Schema")]
		[HttpGet]
		[Route("dashboard")]
		public IActionResult DashBoard()
		{
			
			return View("DashBoard");
		}

		[HttpGet]
		[Route("accessdenied")]
		public IActionResult AccessDenied()
		{

			return View("AccessDenied");
		}



		[Authorize(Roles = "Customer", AuthenticationSchemes = "User_Schema")]
		[HttpGet]
		[Route("history")]
		public IActionResult History()
		{
			var user = User.FindFirst(ClaimTypes.Name);
			var customer = db.Account.SingleOrDefault(a => a.Username.Equals(user.Value));
			ViewBag.invoices = customer.Invoices.OrderByDescending(i => i.Id).ToList();
			return View("History");
		}



		[Authorize(Roles = "Customer", AuthenticationSchemes = "User_Schema")]
		[HttpGet]
		[Route("details/{id}")]
		public IActionResult Details(int id)
		{
			ViewBag.invoiceDetails = db.InvoiceDetailses.Where(i => i.InvoiceId == id).ToList();
			return View("Details");
		}
	}
}
