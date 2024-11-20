using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using NtinasPieShop.Models;
using NtinasPieShop.ViewModels;



namespace NtinasPieShop.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly IShoppingCart _shoppingCart;

        public ShoppingCartSummary(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartVieModel = new ShoppingCartViewModel(_shoppingCart,
            _shoppingCart.GetShoppingCartTotal());

            return View(shoppingCartVieModel);

        }
    }
}
