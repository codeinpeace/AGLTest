using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
 

namespace AGL.Model
{
    public class PetOwner
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("pets")]
        public List<Pet> Pets { get; set; }
    }
}
 