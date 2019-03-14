using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
using Model;
namespace DAL
{
   public class ApartMentDAL:HouseFace<Apartment>
    {
        public int Add(Apartment t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Apartment t)
        {
            throw new NotImplementedException();
        }

        public List<Apartment> Show()
        {
            throw new NotImplementedException();
        }

        public Apartment GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
