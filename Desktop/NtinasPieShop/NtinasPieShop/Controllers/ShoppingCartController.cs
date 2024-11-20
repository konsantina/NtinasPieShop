using NtinasPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace NtinasPieShop.Controllers
{
    public class ShoppingCartController: Controller
    {

            private readonly IPieRepository _pieRepository;
            private readonly IShoppingCart _shoppingCart;

        public ShoppingCartController(IPieRepository pieRepository, IShoppingCart shoppingCart) 
        {
            _pieRepository = pieRepository;

            _shoppingCart = shoppingCart;
        }
    }
}
