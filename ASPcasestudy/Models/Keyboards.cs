using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPcasestudy.Models
{
    public class Keyboards
    {
        
        public int KeyboardsID { get; set; }
        public string Mechanical { get; set; }
        public string Regular { get; set; }


        public decimal Price { get; set; }

        public virtual ICollection<Products> product { get; set; }
    }
}