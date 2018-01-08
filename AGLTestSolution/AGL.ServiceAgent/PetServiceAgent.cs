using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Deserializers;
using AGL.Model;
using Newtonsoft.Json;

namespace AGL.ServiceAgent
{
    public class PetServiceAgent : IPetServiceAgent
    {
        //NOTE: in a production system this will need to go into a config file. 
        private const string _sourceUrl = @"http://agl-developer-test.azurewebsites.net/";
        private const string _resourceName = @"people.json";


        public PetServiceAgent()
        {

        }

        public IEnumerable<PetOwner> GetPetInformation()
        {
            var client = new RestClient(_sourceUrl);
            var request = new RestRequest(_resourceName, Method.GET);
            var response = client.Execute<List<PetOwner>>(request);
            return response.Data;
        }
    }
}
