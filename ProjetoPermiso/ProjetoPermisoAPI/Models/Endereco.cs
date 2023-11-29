namespace ProjetoPermisoAPI.Models;

public class Endereco
{
    public int Cep { get; set; }   
    public string TipoCep { get; set; }
    public string SubTipoCep { get; set; }
    public string Uf { get; set; }
    public string Cidade { get; set; }
    public string Bairro { get; set; }
    public string Logradouro { get; set; }
    public string Complemento { get; set; }
    public string CodigoIBGE { get; set; }

}
