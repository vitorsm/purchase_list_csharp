﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using purchase_list_bg.Data;
using purchase_list_bg.Models;
using purchase_list_csharp.Models.ViewModels;
using purchase_list_csharp.Utils;

namespace purchase_list_csharp.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserContext _context;

        [BindProperty]
        public LoginViewModel LoginModel { get; set; }

        public LoginController(UserContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View(new LoginErrorViewModel(null, null));
        }

        public async Task<IActionResult> Authenticate() {

            if (!ModelState.IsValid)
            {
                return null;
            }
            
            string login = this.LoginModel.Login;
            string password = this.LoginModel.Password;

            User authenticatedUser = this._context.AuthenticateUser(login, PasswordUtils.EncodePassword(password, ""));

            if (authenticatedUser != null)
            {
                await SetAuthenticatedUser(authenticatedUser.Login, false);

                string returnUrl = this.LoginModel.ReturnUrl;

                string controller = "Home";
                string action = "Index";

                if (returnUrl != null && returnUrl.StartsWith("/"))
                {
                    string[] parts = returnUrl.Substring(1).Split('/');
                    controller = parts[0];

                    if (parts.Length >= 2)
                    {
                        action = parts[1];
                    }
                }

                return this.RedirectToActionPermanent(action, controller);
            }

            return View("Index", new LoginErrorViewModel("Usuário ou senha inválidos", null));
        }

        public async Task<IActionResult> Logout()
        {
            await this.UnsetAuthenticatedUser();

            return View("Index");
        }

        private async Task SetAuthenticatedUser(string login, bool isPersistent)
        {
            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Name, login));

            ClaimsIdentity claimIdentities = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal claimPrincipal = new ClaimsPrincipal(claimIdentities);
            HttpContext authenticationManager = Request.HttpContext;

            await authenticationManager.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal, new AuthenticationProperties() { IsPersistent = isPersistent });
        }

        private async Task UnsetAuthenticatedUser()
        {
            HttpContext authenticationManager = Request.HttpContext;
            await authenticationManager.SignOutAsync();
        }
    }
}