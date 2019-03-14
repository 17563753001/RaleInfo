using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
using Model;
namespace DAL
{
   public class UserInfoDAL:HouseFace<UserInfo>
    {
        public int Add(UserInfo t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(UserInfo t)
        {
            throw new NotImplementedException();
        }

        public List<UserInfo> Show()
        {
            throw new NotImplementedException();
        }

        public UserInfo GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
