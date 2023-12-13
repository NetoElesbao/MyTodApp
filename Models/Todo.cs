using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public Todo()
        {
            CreatedAt = DateTime.Now;
            LastUpdateDate = DateTime.Now;
        }

        public int Id { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Title { get; set; }

        [DisplayName("Concluído")]
        public bool Done { get; set; }

        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Última atualização")]
        public DateTime LastUpdateDate { get; set; }

        [DisplayName("Usuário")]
        public string User { get; set; }
    }
}