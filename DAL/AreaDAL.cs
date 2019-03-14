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
   /// 区
   /// </summary>
   public class AreaDAL:HouseFace<Area>
    {
        public int Add(Area t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Area t)
        {
            throw new NotImplementedException();
        }

        public List<Area> Show()
        {
            throw new NotImplementedException();
        }

        public Area GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
