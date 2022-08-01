using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BlazorCrud.Shared.Models
{
    public class User
    {
        public int Userid { get; set; }

        [Required(ErrorMessage="Informe o nome do usuário")]
        public string Username { get; set; }
        public string? Address { get; set; }
        public string? Cellnumber { get; set; }
        public string? Emailid { get; set; }
    }
}