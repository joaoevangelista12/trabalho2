namespace trabalho2_JoaoVictorEvangelistaGomes.Models
{
    public class TipoDePagamento
    {
        public int Id { get; set; }
        public int IdNotaDeVenda { get; set; }
        public int IdItem { get; set; }
        public int IdProduto { get; set; }
        public int IdMarca { get; set; }
        public string NomeDoCobrado { get; set; }
        public string InformacoesAdicionais { get; set; }
    }
}