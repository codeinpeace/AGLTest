using AGL.Model;
using AGL.Pet.Manager;
using AGL.ServiceAgent;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace AGL.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                                    .AddSingleton<IPetServiceAgent, PetServiceAgent>()
                                    .AddSingleton<IPetManager, PetManager>()
                                    .BuildServiceProvider();

            //do the actual work here
            var petInfo = serviceProvider.GetService<IPetManager>().GetCatOwnershipByGender();
            PrintInfo(petInfo);

            //wait - so that the console does not close 
            System.Console.ReadLine();
        }
       



        private static void PrintInfo(CatOwnershipByGender petInfo)
        {
           
            System.Console.WriteLine("Male");
            System.Console.WriteLine("=================");
            foreach (var catWithMaleOwner in petInfo.CatsOwnedByMales) { System.Console.WriteLine(catWithMaleOwner.Name); }
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            System.Console.WriteLine("Female");
            System.Console.WriteLine("=================");
            foreach (var catWithFemaleOwner in petInfo.CatsOwnedByFemales) { System.Console.WriteLine(catWithFemaleOwner.Name); }
        }
    }
}
 