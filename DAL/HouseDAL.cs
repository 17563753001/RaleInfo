using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
using Model;
namespace DAL
{
    /// <summary>
    /// 房屋
    /// </summary>
    public class HouseDAL:HouseFace<HouseInfo>
    {
        public int Add(HouseInfo t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(HouseInfo t)
        {
            throw new NotImplementedException();
        }

        public List<HouseInfo> Show()
        {
            throw new NotImplementedException();
        }

        public HouseInfo GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
