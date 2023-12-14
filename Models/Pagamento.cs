namespace trabalho2_JoaoVictorEvangelistaGomes.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int IdNotaDeVenda { get; set; }
        public int IdItem { get; set; }
        public int IdProduto { get; set; }
        public int IdMarca { get; set; }
        public DateTime DataLimite { get; set; }
        public double Valor { get; set; }
        public bool Pago { get; set; }
    }
}