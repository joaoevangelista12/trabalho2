namespace trabalho2_JoaoVictorEvangelistaGomes.Models
{
    public class PagamentoComCartao
    {
        public int Id { get; set; }
        public int IdTipoDePagamento {get; set; }
        public int IdNotaDeVenda { get; set; }
        public int IdItem { get; set; }
        public int IdProduto { get; set; }
        public int IdMarca { get; set; }
        public string NumeroDoCartao { get; set; }
        public string Bandeira { get; set; }
    }
}