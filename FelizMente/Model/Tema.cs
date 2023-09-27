using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FelizMente.Model
{
    public class Tema
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(255)]
        public string nome { get; set; } = string.Empty;

        [Column(TypeName = "varchar")]
        [StringLength(510)]
        public string descricao { get; set; } = string.Empty;
    }
}
