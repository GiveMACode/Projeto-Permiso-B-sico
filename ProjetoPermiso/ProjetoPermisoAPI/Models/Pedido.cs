namespace ProjetoPermisoAPI.Models;

public class Pedido
{
    public Pedido() =>
        CriadoEm = DateTime.Now;
    public int PedidoId { get; set; }
    public int Ordem { get; set; }
    public string NomePedido { get; set; }
    public Empresa Empresa { get; set; }
    public int IdEmpresa { get; set; }
    public DateTime CriadoEm { get; set; }
    public int CategoriaId { get; set; }
    public string? Observacao { get; set; }
    public StatusPedido StatusPedido { get; set; }

}
