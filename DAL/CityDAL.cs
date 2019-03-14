using InterFace;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 市
    /// </summary>
    public class CityDAL : HouseFace<City>
    {
        public int Add(City t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(City t)
        {
            throw new NotImplementedException();
        }

        public List<City> Show()
        {
            throw new NotImplementedException();
        }

        public City GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
