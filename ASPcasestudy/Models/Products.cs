using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPcasestudy.Models
{
    public class Products
    {
        
        public int ProductsID { get; set; }
        //public int DesktopComputersID { get; set; }
        //public int LaptopsID { get; set; }
        //public int TabletsID { get; set; }
        //public int KeyboardsID { get; set; }
        //public int MouseID { get; set; }
        //public int ComputerComponentsID { get; set; }





        //ostali modeli
        public virtual DesktopComputers DesktopComputers { get; set; }
        public virtual Laptops Laptops { get; set; }
        public virtual Tablets Tablets { get; set; }
        public virtual Keyboards Keyboards { get; set; }
        public virtual Mouse Mouse { get; set; }
        public virtual ComputerComponents ComputerComponents { get; set; }
    }
}