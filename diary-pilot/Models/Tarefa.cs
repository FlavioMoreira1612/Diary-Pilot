using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace diary_pilot.Models
{
    [Table("Tarefas")]  
    public class Tarefa
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar nome da tarefa")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data da tarefa")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar descrição da tarefa")]
        [Display(Name = "Descrição")]   
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar categoria da tarefa")]
        public TipoCategoria Tipo { get; set; }

        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "Obrigatório informar o usuario")]
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        public  Usuario Usuario { get; set; }  

    }

    public enum TipoCategoria
    {
        Trabalho,
        Estudo,
        Lazer,
        Outros
    }   
}
