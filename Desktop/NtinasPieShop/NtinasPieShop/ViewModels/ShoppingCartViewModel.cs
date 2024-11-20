using NtinasPieShop.Models;

namespace NtinasPieShop.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCartViewModel(IShoppingCart shoppingCart, decimal shoppingCartTotal)
        {
            ShoppingCart = shoppingCart;
            ShoppingCartTotal = ShoppingCartTotal;

        }
        public IShoppingCart ShoppingCart { get; }

        public decimal ShoppingCartTotal { get; }
    }
}
