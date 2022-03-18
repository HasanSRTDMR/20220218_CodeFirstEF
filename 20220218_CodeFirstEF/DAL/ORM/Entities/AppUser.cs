using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220218_CodeFirstEF.DAL.ORM.Entities
{
    [Table("Users")]
    public class AppUser : BaseEntity
    {
       
        [MaxLength(30)]
        public string LastName { get; set; }
        [MaxLength(50)]
        [NotMapped]
        public string FullName {
            get
            {
                if (string.IsNullOrWhiteSpace(LastName))
                {
                    return Name;
                }
                else
                {
                    return Name + " " + LastName;
                }
            }            
        }
        [MaxLength(25)]
        [Required,Index(IsUnique =true)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage ="Password must be 10 characters or less"),MinLength(5)]
        public string Password { get; set; }

        public DateTime Birth_Date { get; set; }

        public bool? Gender { get; set; }

        



    }
}
