using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnindTicMaquinas.Models
{
    [Table("Maquina")]
    public class Maquina
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Departamento")]
        [Display(Name = "Departamento")]
        public string Departamento { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Empresa")]
        [Display(Name = "Empresa")]
        public string Empresa { get; set; }

        [Column("Processador")]
        [Display(Name = "Processador")]
        public string Processador { get; set; }

        [Column("Ram")]
        [Display(Name = "Ram")]
        public string Ram {  get; set; }

        [Column("Termo")]
        [Display(Name = "Termo de Responsabilidade")]
        public string Documento{ get; set; }

        [Column("Marca")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

    }
}
