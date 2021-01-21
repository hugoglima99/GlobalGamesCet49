namespace GlobalGamesCet49.Dados.Entidades
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Inscricoes
    {

        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Apelido")]
        public string Apelido { get; set; }

        [Display(Name = "Morada")]
        public string Morada { get; set; }

        [Display(Name = "Cartão de Cidadão")]
        public int CCidadao { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime Anos { get; set; }

        [Display(Name = "Image")]
        public string ImageFile { get; set; }




        public string Image
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImageFile))
                {
                    return null;
                }

                return $"https://localhost:44323/%7Bthis.ImageFile.Substring(1)%7D";
            }
        }



    }
}


