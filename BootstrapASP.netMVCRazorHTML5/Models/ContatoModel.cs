using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class ContatoModel
    {

        [Required(ErrorMessage = "Preencha com o seu nome.")]
        public String nome { get; set; }

        [Required(ErrorMessage = "Preencha com o nome da cidade.")]
        public String cidade { get; set; }

        [Required(ErrorMessage = "Preencha com o nome da empresa")]
        public String empresa { get; set; }

        [Required(ErrorMessage = "Preencha com o seu telefone.")]
        public String telefone { get; set; }

        [Required(ErrorMessage = "Preencha com o seu e-mail.")]
        public String email { get; set; }

        [Required(ErrorMessage = "Preencha com os seus comentários.")]
        public String comentarios { get; set; }
    }
}