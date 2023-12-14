namespace trabalho2_JoaoVictorEvangelistaGomes.Models
{
    public class PagamentoComCheque
    {
        public int Id { get; set; }
        public int IdTipoDePagamento {get; set; }
        public int IdNotaDeVenda { get; set; }
        public int IdItem { get; set; }
        public int IdProduto { get; set; }
        public int IdMarca { get; set; }
        public int Banco { get; set; }
        public string NomeDoBanco { get; set; }
    }
}