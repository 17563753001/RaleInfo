using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
using Model;
namespace DAL
{
   public class PositionDAL:HouseFace<Position>
    {
        public int Add(Position t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Position t)
        {
            throw new NotImplementedException();
        }

        public List<Position> Show()
        {
            throw new NotImplementedException();
        }

        public Position GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
