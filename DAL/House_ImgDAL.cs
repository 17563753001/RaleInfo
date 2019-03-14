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
    /// 房屋图片
    /// </summary>
   public class House_ImgDAL:HouseFace<House_Img>
    {
        public int Add(House_Img t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(House_Img t)
        {
            throw new NotImplementedException();
        }

        public List<House_Img> Show()
        {
            throw new NotImplementedException();
        }

        public House_Img GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
