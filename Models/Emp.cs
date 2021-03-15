using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExCodeFxGIT.Models
{
    public class Emp : EmpBase
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public string EDesig { get; set; }
        public DateTime EDOJ { get; set; }
    }
}