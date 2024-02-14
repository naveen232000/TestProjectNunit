using OurLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectNunit
{
    [TestFixture]
    public class EmployeeManagTest
    {
        EmpMgmt empMgmt;
        [SetUp]
        public void SetUp() { }
        [Test]
        public void EmpNotNullTest()
        {
            foreach(var emp in EmpMgmt.AllEmp())
            {
                Assert.IsNotNull(emp.Id);
                Assert.IsNotNull(emp.Name);
                Assert.IsNotNull(emp.Desigination);
                Assert.IsNotNull(emp.Salary);
            }
        }
    }
}
