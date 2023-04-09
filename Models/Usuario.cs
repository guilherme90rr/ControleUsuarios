using CRUDLogin.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDLogin.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("idUsuario")]
        [Key]
        public int idUsuario { get; set; }
        [Column("idEmpresa")]
        [ForeignKey("Empresa")]
        public int empresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
        [Column("nomeUsuario")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string nomeUsuario { get; set; }
        [Column("senha")]
        [Required(ErrorMessage ="Campo Obrigatório")]
        public string senha { get; set; }
        [Column("documentoUsuario")]
        public string documentoUsuario { get; set; }
        [Column("dataCriação")]
        public DateTime dataCriacao { get; set; } = DateTime.Now;
    }
}
