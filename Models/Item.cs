namespace trabalho2_JoaoVictorEvangelistaGomes.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int IdMarca { get; set; }
        public double Preco { get; set; }
        public int Percentual { get; set; }
        public int Quantidade { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
    
}