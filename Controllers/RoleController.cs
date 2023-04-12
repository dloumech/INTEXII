using INTEXII.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace INTEXII.Controllers
{
    //public class AdminController : Controller
    //{
    //    private readonly ApplicationDbContext _context;
    //    private readonly IAuthenticationService _authenticationService;
    //    private readonly IAuthenticationService _authService;

    //    public AdminController(ApplicationDbContext context, IAuthenticationService authenticationService)
    //    {
    //        _context = context;
    //        _authenticationService = authenticationService;
    //    }

    //    [Authorize(Roles = "admin")]
    //    public async Task<ActionResult> AdminPage()
    //    {
    //        var userName = User.Identity.Name;
    //        var user = _context.Users.FirstOrDefault(u => u.UserName == userName);

    //        var isAdmin = await _context.Roles
    //            .Where(r => r.Name == "admin")
    //            .Join(_context.UserRoles, r => r.Id, ur => ur.RoleId, (r, ur) => ur.UserId)
    //            .ContainsAsync(user.Id);

    //        if (isAdmin)
    //        {
    //            var identity = (ClaimsIdentity)User.Identity;
    //            identity.AddClaim(new Claim(ClaimTypes.Role, "admin"));
    //            object p = await _authenticationService.SignInAsync(HttpContext,
    //                new ClaimsPrincipal(identity),
    //                new Microsoft.AspNetCore.Authentication.AuthenticationProperties { IsPersistent = false });

    //            return View();
    //        }
    //        else
    //        {
    //            return RedirectToAction("Index", "Home");
    //        }
    //    }
    //}


    //    public class AdminController : Controller
    //    {
    //        private readonly ApplicationDbContext _context;

    //        public AdminController(ApplicationDbContext context)
    //        {
    //            _context = context;
    //        }

    //        [Authorize(Roles = "admin")]
    //        public ActionResult AdminUser()
    //        {
    //            var userName = User.Identity.Name;
    //            var user = _context.Users.FirstOrDefault(u => u.UserName == userName);

    //            if (user != null)
    //            {
    //                // Retrieve the user's roles from the database
    //                var roles = _context.Roles
    //                    .Where(r => r.Users.Any(ur => ur.UserId == user.Id))
    //                    .ToList();

    //                // Check if the user has the "admin" role
    //                if (roles.Any(r => r.Name == "admin"))
    //                {
    //                    var identity = (ClaimsIdentity)User.Identity;
    //                    identity.AddClaim(new Claim(ClaimTypes.Role, "admin"));
    //                    var authManager = HttpContext.GetOwinContext().Authentication;
    //                    authManager.AuthenticationResponseGrant =
    //                        new AuthenticationResponseGrant(new ClaimsPrincipal(identity),
    //                            new AuthenticationProperties { IsPersistent = false });

    //                    return View();
    //                }
    //            }

    //            return RedirectToAction("Index", "Home");
    //        }

    //        public class AdminController : Controller
    //{
    //    private readonly ApplicationDbContext _context;

    //    public AdminController(ApplicationDbContext context)
    //    {
    //        _context = context;
    //    }

    //    [Authorize(Roles = "admin")]
    //    public ActionResult AdminPage()
    //    {
    //        var userName = User.Identity.Name;
    //        var user = _context.Users.FirstOrDefault(u => u.UserName == userName);

    //        if (user != null && user.Role == "admin")
    //        {
    //            var identity = (ClaimsIdentity)User.Identity;
    //            identity.AddClaim(new Claim(ClaimTypes.Role, "admin"));
    //            HttpContext.Authentication.SignInAsync(
    //                new ClaimsPrincipal(identity),
    //                new AuthenticationProperties { IsPersistent = false });

    //            return View();
    //        }
    //        else
    //        {
    //            return RedirectToAction("Index", "Home");
    //        }
    //    }
    //}

}


