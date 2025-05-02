using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace diary_pilot.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o perfil")]
        public Perfil Perfil { get; set; }

        public ICollection<Tarefa> Tarefas { get; set; } 

    }

    public enum Perfil
    {
        Profissional,
        Estudante
    }
}
