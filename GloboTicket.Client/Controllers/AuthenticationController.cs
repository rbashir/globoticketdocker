using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        public async Task Logout()
        {
            // signout from app
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            // singout from Identity server otherwise it auto signs again
            await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);
        }
    }
}
