using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNT_STA_CTY_USER_API_13.Model
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public State State { get; set; } 
    }
}
