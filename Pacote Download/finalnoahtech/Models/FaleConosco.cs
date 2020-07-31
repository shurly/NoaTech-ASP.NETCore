using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Noahtech.Models
{
    public class FaleConosco
    {
        [Key]
        public int ContatoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Mensagem { get; set; }
}
}
