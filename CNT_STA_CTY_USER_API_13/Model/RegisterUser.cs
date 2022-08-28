using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CNT_STA_CTY_USER_API_13.Model
{
    public class RegisterUser 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        [NotMapped]  
        [Display(Name ="State")]
        public int StateId { get; set; }
        [NotMapped]
        [Display(Name ="Country")]
        public int CountyId { get; set; } 
    }
}
