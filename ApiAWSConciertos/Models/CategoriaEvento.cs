using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAWSConciertos.Models
{
    [Table("categoriaevento")]
    public class CategoriaEvento
    {
        [Key]
        [Column("IDCATEGORIA")]
        public int IdCategoria {get;set;}
        [Column("NOMBRE")]
        public string Nombre {get;set;}
    }
}
