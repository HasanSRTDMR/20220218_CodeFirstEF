using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220218_CodeFirstEF.DAL.ORM.Entities
{
    public class Product : BaseEntity
    {

        public decimal? UnitPrice { get; set; }

        public short? UnitInStock { get; set; }
        [MaxLength(20)]
        public string QuantityPerUnit { get; set; }

    }
}
