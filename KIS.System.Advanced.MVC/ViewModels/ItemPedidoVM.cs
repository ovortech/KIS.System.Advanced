namespace KIS.System.Advanced.MVC.ViewModels
{
    public class ItemPedidoVM
    {
        public int IdProduto { get; set; }
        public string CodProduto { get; set; }
        public string Observacao { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double Desconto { get; set; }
        public string NomeProduto { get; set; }
    }
}