using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
 

namespace AGL.Model
{
    public class CatOwnershipByGender
    {
        public List<Pet> CatsOwnedByMales { get; set; }
        public List<Pet> CatsOwnedByFemales { get; set; } 
    }
}
 