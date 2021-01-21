namespace GlobalGamesCet49.Dados.Entidades
{
    using System.ComponentModel.DataAnnotations;

    public class UserLogin
    {
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "Limite de 30 Caracteres")]
        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        public User User { get; set; }
    }
}
