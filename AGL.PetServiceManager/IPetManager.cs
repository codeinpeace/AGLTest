using AGL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGL.Pet.Manager
{
    public interface IPetManager
    {
        CatOwnershipByGender GetCatOwnershipByGender();
    }
}
