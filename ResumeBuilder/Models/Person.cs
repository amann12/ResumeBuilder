using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBuilder.Models
{
    public class Person
    {
        [Key]
        public int pId { get; set; }
        
        public string pName{ get; set; }

        public string pAddress{ get; set; }

        public states? pState { get; set; }

        public string pCity { get; set; }

        public string pEmail{ get; set; }

        public long pMobile { get; set; }
    }
}
