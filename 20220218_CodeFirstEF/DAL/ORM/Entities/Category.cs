using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220218_CodeFirstEF.DAL.ORM.Entities
{
    public class Category:BaseEntity
    {
        
        [MaxLength(255)]
        public string Description { get; set; }



    }
}
