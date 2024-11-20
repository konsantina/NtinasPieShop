using Microsoft.Identity.Client;
using NtinasPieShop.Models;

namespace NtinasPieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }  

        public HomeViewModel(IEnumerable<Pie> piesOfTheWeek) 
        {
            PiesOfTheWeek = piesOfTheWeek;
        } 
        

    }
}
