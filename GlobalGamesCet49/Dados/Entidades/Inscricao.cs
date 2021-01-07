using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCet49.Dados.Entidades
{
    public class Inscricao
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Número de Telefone")]
        public int NumeroTelefone { get; set; }

        [Display(Name = "Morada")]
        public int Morada { get; set; }
    }
}
