using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject.Data
{
    public class Features
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FeatureName { get; set; }
        [Required]
        public bool HasWeapon { get; set; }
        [Required]
        public bool HasArmor { get; set; }
    }
}