namespace App_produit.Models.Entities
{
    public class UpdateProduitDto
    {

        
        public required string Name { get; set; }

        public string? Description { get; set; }
        public required decimal Price { get; set; }
        public required DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Le temps par defaut est UTC
    }
}
