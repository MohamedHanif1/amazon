namespace MVC_projet.Models
{
    public class LignePanier
    {
        public int LignePanierId { get; set; }
        public int Quantite { get; set; }
        public int PanierId { get; set; }
        public int ProduitId { get; set; }
    }
}
