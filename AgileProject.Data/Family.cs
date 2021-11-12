using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject.Data
{
    public class Family
    {
        [Key]
        public int FamilyId { get; set; }
        public string Name { get; set; }
    }
}
