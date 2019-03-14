using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
using Model;
namespace DAL
{
   public class ContractDAL:HouseFace<Contract>
    {
        public int Add(Contract t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Contract t)
        {
            throw new NotImplementedException();
        }

        public List<Contract> Show()
        {
            throw new NotImplementedException();
        }

        public Contract GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
