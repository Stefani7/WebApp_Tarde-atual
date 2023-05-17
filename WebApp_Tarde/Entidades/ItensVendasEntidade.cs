namespace WebApp_Tarde.Entidades
{
    public class ItensVendasEntidade
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public ProdutoEntidade Produto { get; set; }
        public VendasEntidade Venda { get; set; }
        public decimal Valor { get; set;  }
    }
}
