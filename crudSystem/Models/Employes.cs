using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace crudSystem.Models
{
    public class Employes
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "*First Name can't be blank*")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "*Last Name can't be blank*")]
        public string lastName { get; set; }
        public bool Status { get; set; }
        [Required(ErrorMessage = "*State can't be blank*")]
        public string State { get; set; }

        //public bool Checkbox { get; set; }

    }
}