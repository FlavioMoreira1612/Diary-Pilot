using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace diary_pilot.Models
{
    [Table("Tarefas")]
    public class Tarefas
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome da tarefa!")]
        public string Tarefa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data de início da tarefa!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição da tarefa!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Categoria da Tarefa")]
        public TipoCategoria Tipo { get; set; }
    }

    public enum TipoCategoria
    {
        Estudo,
        Trabalho,
        Pessoal,
        Financeiro,
        Universidade,
        Projeto,
        Outros
    }
}