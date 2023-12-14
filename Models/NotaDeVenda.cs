namespace trabalho2_JoaoVictorEvangelistaGomes.Models
{
    public class NotaDeVenda
    {
        public int Id { get; set; }
        public int IdItem { get; set; }
        public int IdProduto { get; set; }
        public int IdMarca { get; set; }
        public DateTime Data { get; set; }
        public bool Tipo { get; set; } 
        public virtual ICollection<Item> Items { get; set; }
    }
    
}