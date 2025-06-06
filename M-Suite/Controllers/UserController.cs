﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using M_Suite.Data;
using M_Suite.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace M_Suite.Controllers
{
    public class UserController : Controller
    {
        private readonly MSuiteContext _context;

        public UserController(MSuiteContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
       
            // FirstOrDefault: It fetches the first element from the collection that matches the specified condition
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UsLogin == username);
            if (user == null || user.UsPassword != password)
            {
                ViewBag.Error = "Invalid username or password";
                return View();
            }

            //store user-related data for authentication and authorization.
            var claims = new List<Claim>
         {
             new Claim(ClaimTypes.Name, user.UsLogin),
             new Claim("FullName", $"{user.UsFirstName} {user.UsLastName}"),
             new Claim(ClaimTypes.Role, user.UsType ?? string.Empty)

         };
            //handling user authentication using cookie-based authentication
            //ClaimsIdentity is an identity object that holds a collection of claims
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);


            var authProperties = new AuthenticationProperties();

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);


            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "User");

        }

        // GET: User
        public async Task<IActionResult> Index(string searchString)
        {
            var maliaContext = _context.Users.Include(u => u.UsUs).AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                maliaContext = maliaContext.Where(n =>
                    n.UsLogin.Contains(searchString) ||
                    n.UsFirstName.Contains(searchString)
                );
            }

            return View(await maliaContext.ToListAsync());
        }


        // GET: User/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.UsUs)
                .FirstOrDefaultAsync(m => m.UsId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: User/Create
        public IActionResult Create()
        {
            ViewData["Title"] = "Create";
            ViewData["UsUsId"] = new SelectList(_context.Users, "UsId", "UsId");
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UsId,UsUsId,UsThpId,UsCdIdGen,UsCdIdTtl,UsCode,UsFirstName,UsLastName,UsShortName,UsLogin,UsPassword,UsEmail,UsReceiveNotification,UsExpiryDate,UsActive,UsDeleted,UsDbUser,UsImported,UsReadonly,UsToken,UsRoute,UsPrefix,UsType")] User user)
        {
            //This checks whether the form data is valid
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsUsId"] = new SelectList(_context.Users, "UsId", "UsId", user.UsUsId);
            return View(user);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["UsUsId"] = new SelectList(_context.Users, "UsId", "UsId", user.UsUsId);
            return View(user);
        }

        // POST: User/Edit/5
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UsId,UsUsId,UsThpId,UsCdIdGen,UsCdIdTtl,UsCode,UsFirstName,UsLastName,UsShortName,UsLogin,UsPassword,UsEmail,UsReceiveNotification,UsExpiryDate,UsActive,UsDeleted,UsDbUser,UsImported,UsReadonly,UsToken,UsRoute,UsPrefix,UsType")] User user)
        {
            if (id != user.UsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UsId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsUsId"] = new SelectList(_context.Users, "UsId", "UsId", user.UsUsId);
            return View(user);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.UsUs)
                .FirstOrDefaultAsync(m => m.UsId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UsId == id);
        }
    }
}
