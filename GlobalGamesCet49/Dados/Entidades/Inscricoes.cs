using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCet49.Dados.Entidades
{
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
        
    }
}
