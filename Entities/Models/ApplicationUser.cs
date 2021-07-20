using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [MaxLength(50)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [PersonalData]
        [MaxLength(40)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [PersonalData]
        [MaxLength(9)]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [PersonalData]
        [MaxLength(255)]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
    }
}
