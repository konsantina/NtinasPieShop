namespace NtinasPieShop.Models
{                           //Αυτή η διεπαφή ICategoryRepository είναι πολύ χρήσιμη, καθώς ορίζει μια τυπική μέθοδο για την πρόσβαση
                            //σε όλες τις κατηγορίες, διασφαλίζοντας ότι οποιαδήποτε κλάση την υλοποιεί θα έχει μια κοινή δομή για
                            //την ανάκτηση των κατηγοριών.
    public  interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; } //Η AllCategories είναι
                                                     //μια συλλογή από αντικείμενα Category.
                                                     //Η χρήση του IEnumerable επιτρέπει την απλή επανάληψη
                                                     //(iteration) στα στοιχεία της συλλογής.
                                                     //Η AllCategories χρησιμοποιείται για να πάρουμε
                                                     //όλες τις κατηγορίες από το αποθετήριο.
    }

}
