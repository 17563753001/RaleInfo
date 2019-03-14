using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterFace;
namespace DAL
{
    /// <summary>
    /// 员工
    /// </summary>
   public class EmpDAL:HouseFace<Employee>
    {

        public int Add(Employee t)
        {
            throw new NotImplementedException();
        }

        public int Del<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }

        public int Upt(Employee t)
        {
            throw new NotImplementedException();
        }

        public List<Employee> Show()
        {
            throw new NotImplementedException();
        }

        public Employee GetShowById<I>(I id) where I : struct
        {
            throw new NotImplementedException();
        }
    }
}
