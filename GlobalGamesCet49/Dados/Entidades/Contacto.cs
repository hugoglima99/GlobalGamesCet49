﻿using System.ComponentModel.DataAnnotations;

namespace GlobalGamesCet49.Dados.Entidades
{
    public class Contacto
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Número de Telefone")]
        public int NumeroTelefone { get; set; }
    }
}
