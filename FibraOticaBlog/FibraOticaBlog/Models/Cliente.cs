using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FibraOticaBlog.Models
{
    public class Cliente
    {
        [Required]
        public string Nome
        {
            get; set;
        }
    }
}
