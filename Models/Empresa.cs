using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDLogin.Models
{
    [Table("Empresa")]
    public class Empresa
    {
        [Column("idEmpresa")]
        [Key]
        public int idEmpresa { get; set; }
        [Column("nomeUsuario")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string nomeEmpresa { get; set; }
        [Column("documentoUsuario")]
        public string documentoEmpresa { get; set; }
        [Column("dataCriação")]
        public DateTime dataCriacao { get; set; } = DateTime.Now;
    }
}
