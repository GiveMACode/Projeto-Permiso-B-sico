namespace ProjetoPermisoAPI.Models;
public class Representante
{
     public Representante() =>
        CriadoEm = DateTime.Now;
    public int IdRepresentante { get; set; }
    public string NomeRepresentante { get; set; }
    public float CPFRepresentante { get; set; }
    public DateTime DataNascimentoRepresentante { get; set; }
    public float Telefone { get; set; }
    public DateTime CriadoEm { get; set; }
    public string? Observacao { get; set; }
}
