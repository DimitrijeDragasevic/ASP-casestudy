using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPcasestudy.Models
{
    public class Tablets
    {
        
        public int TabletsID { get; set; }
        public string Brand { get; set; }
        public  decimal Price { get; set; }

        public virtual ICollection<Products> product { get; set; }

    }
}