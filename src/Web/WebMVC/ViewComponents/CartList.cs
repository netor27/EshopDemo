using Microsoft.AspNetCore.Mvc;
using Demo.WebMVC.ViewModels;
using Demo.WebMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.WebMVC.ViewComponents
{
    public class CartList : ViewComponent
    {
        private readonly IBasketService _cartSvc;

        public CartList(IBasketService cartSvc) => _cartSvc = cartSvc;

        public async Task<IViewComponentResult> InvokeAsync(ApplicationUser user)
        {
            var item = await GetItemsAsync(user);
            return View(item);
        }
        
        private Task<Basket> GetItemsAsync(ApplicationUser user) => _cartSvc.GetBasket(user);
    }
}
