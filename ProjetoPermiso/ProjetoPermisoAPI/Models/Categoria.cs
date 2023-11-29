namespace ProjetoPermisoAPI.Models;

public class Categoria
{
    public int CategoriaId { get; set; }
    public string TipoCategoria { get; set; }

    public DateTime CriadoEm { get; set; }
    public string? Observacao { get; set; }

}
