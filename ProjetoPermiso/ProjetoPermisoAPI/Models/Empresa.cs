namespace ProjetoPermisoAPI;

public class Empresa
{
    public Empresa() =>
        CriadoEm = DateTime.Now;
    public int EmpresaId { get; set; }
    public string NomeEmpresa { get; set; }
    public Representante? Representante { get; set; }
    public string RepresentanteId { get; set; }
    public float CNPJ { get; set; }
    public float Telefone { get; set; }
    public DateTime CriadoEm { get; set; }
    public TipoPessoa TipoPessoa { get; set; }
    public int TipoPessoaId { get; set; }
    public string Email { get; set; }
    public string Observacao { get; set; }
}
