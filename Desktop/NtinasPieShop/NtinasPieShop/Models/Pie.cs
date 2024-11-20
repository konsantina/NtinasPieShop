using System.ComponentModel;

namespace NtinasPieShop.Models
{
    public class Pie
    {
        public int PieId { get; set; }
        public string Name { get; set; } = string.Empty; // Αρχικοποιείται με κενή συμβολοσειρά για να αποφύγεις τυχόν null τιμές.
        public string? ShortDescription { get; set; } // (nullable string)

        public string? LongDescription { get; set; } // (?) σε ιδιότητες που μπορεί να μην έχουν πάντα τιμή.
        public string? AlleytgyInformation { get; set; }    
        public decimal? Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }  
        public bool IsPieOfTheWeek { get; set; }    
        public bool InStock { get; set; }   
        public int CategoryId { get; set; }
        public string AllergyInformation { get; set; }

        public Category Category { get; set; } = default!; //Αρχικοποίηση με default!: Το default! χρησιμοποιείται για να παρακάμψει
                                                           //τις προειδοποιήσεις του compiler για null. Στην ουσία,
                                                           //δηλώνεις ότι η τιμή θα αρχικοποιηθεί κάπου αλλού
                                                           //(π.χ., από το ORM όπως το Entity Framework)
                                                           //και δεν θα είναι null.


    }
}
