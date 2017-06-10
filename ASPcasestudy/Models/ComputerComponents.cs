using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPcasestudy.Models
{
    public class ComputerComponents
    {
        
        public int ComputerComponentsID { get; set; }
        public string Procesors { get; set; }
        public string Motherboards { get; set; }
        public string Grphicscard { get; set; }
        public string Ram { get; set; }
        public string Cooling { get; set; }

        public decimal Price { get; set; }
    }
}