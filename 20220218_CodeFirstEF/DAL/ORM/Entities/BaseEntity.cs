using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _20220218_CodeFirstEF.DAL.ORM.Entities
{
    public class BaseEntity
    {
        [Key]
        [Column(Order=1)]//Sütün sırasını belirtebilirsiniz.
        public int ID { get; set; }



        [Column(Order = 2)]
        [MaxLength(25)]
        public virtual string Name { get; set; }
        [Column (TypeName="datetime2")]
        public DateTime? Added_Date { get; set; }

        public bool? isActive { get; set; }

        
    }
}
