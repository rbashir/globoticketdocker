using GloboTicket.Web.Models;
using GloboTicket.Web.Models.View;
using GloboTicket.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly Settings settings;

        public OrderController(Settings settings, IOrderService orderService)
        {
            this.settings = settings;
            this.orderService = orderService;
        }

        public async Task<IActionResult> Index()
        {
            var guid = Guid.Parse(User.Claims.FirstOrDefault(c => c.Type == "http://schemes.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value);
            var orders = await orderService.GetOrdersForUser(guid);

            return View(new OrderViewModel { Orders = orders });
        }
    }
}
