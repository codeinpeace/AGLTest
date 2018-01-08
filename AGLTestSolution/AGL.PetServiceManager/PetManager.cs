using AGL.Model;
using AGL.Pet.Manager;
using AGL.ServiceAgent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Pet.Manager
{
    public class PetManager : IPetManager
    {
        IPetServiceAgent _petServiceAgent;
         
        public PetManager(IPetServiceAgent petServiceAgent)
        {
            _petServiceAgent = petServiceAgent;
        }


        /// <summary>
        /// NOTE: Food for thought - we would need a different approach if we ever had to cater for 
        /// more than the typical male and female gender types. For the purpose of this 
        /// expercise and sample dataset, this is fine.
        /// </summary>
        /// <returns></returns>
        public CatOwnershipByGender GetCatOwnershipByGender()
        {
            var petOwners = _petServiceAgent.GetPetInformation();

            var petsOwnedByFemales = petOwners.Where(x => x.Gender.ToLower().Trim() == "female").ToList();
            var petsOwnedByMales =   petOwners.Where(x => x.Gender.ToLower().Trim() == "male").ToList();

            return new CatOwnershipByGender
            {
                CatsOwnedByFemales = petsOwnedByFemales.Where(z => z.Pets != null)
                                        .SelectMany(x => x?.Pets
                                        .Where(y => y?.Type?.Trim()?.ToLower() == "cat"))?.ToList(),
                
                CatsOwnedByMales = petsOwnedByMales.Where(y => y.Pets != null)
                                        .SelectMany(x => x?.Pets).ToList()
                                        .Where(x => x.Type.ToLower() == "cat")?.ToList()
            };
        }
       

    }
}
