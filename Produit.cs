namespace App_produit.Models.Entities
{
    public class Produit
    // Properties of the Produit class: Id (int)
/* Name(string) – obligatoire
 Description(string)
 Price(decimal) – obligatoire
 CreatedAt(DateTime) – obligatoire*/
    {
        public Guid Id { get; set; }
        public required string Name { get; set; } 

        public string? Description { get; set; }
        public required decimal Price { get; set; }
        public required DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Le temps par defaut est UTC
    }
}
