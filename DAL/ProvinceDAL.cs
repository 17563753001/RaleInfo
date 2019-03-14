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
    /// 省 
    /// </summary>
    public class ProvinceDAL : HouseFace<Province>
    {
        public int Add(Province t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Province t)
        {
            throw new NotImplementedException();
        }

        public List<Province> Show()
        {
            throw new NotImplementedException();
        }

        public Province GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
