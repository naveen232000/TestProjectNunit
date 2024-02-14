using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurLib
{
    public class EmpMgmt
    {
        static List<Emp> EmpList = new List<Emp>() { 
        new Emp(){Id=1,Name="Sam",Desigination="Tester",Salary=65329},
        new Emp(){Id=2,Name="Jon",Desigination="Developer",Salary=56236},
        new Emp(){Id=3,Name="Keen",Desigination="HR",Salary=36562},
        new Emp(){Id=4,Name="Joo",Desigination="Manager",Salary=75238},
        new Emp(){Id=5,Name="Len",Desigination="Tester",Salary=45563},
        }; 

        public static List<Emp> AllEmp()
        {
            return EmpList;
        }
        public static List<Emp>EmpById(int id)
        {
            List<Emp> searchList =EmpList.FindAll(emp=>emp.Id==id);
            return searchList;
        }
    }
}
