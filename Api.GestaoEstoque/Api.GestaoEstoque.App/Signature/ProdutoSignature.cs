
namespace Api.GestaoEstoque.App.Signature
{
    public class ProdutoSignature
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int FornecedorId { get; set; }
        public int Quantidade { get; set; }
        public decimal Compra { get; set; }
    }
}
