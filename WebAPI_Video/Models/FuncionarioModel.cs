using System.ComponentModel.DataAnnotations;
using WebAPI_Video.Enums;

namespace WebAPI_Video.Models
{
    public class FuncionarioModel
    {
        [Key]
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Sobrenome { get; set; }
        public DepartamentoEnum Departamento { get; set; }
        public bool Ativo { get; set; }

        public  TurnoEnum Turno { get; set; }
        public DateTime DataDeCriação { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDeAlteração { get; set; } = DateTime.Now.ToLocalTime();





    }
}
