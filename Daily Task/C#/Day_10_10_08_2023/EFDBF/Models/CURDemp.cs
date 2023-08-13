using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDBF.Models;

namespace EFCF1
{
    internal class CURD
    {
        public void AddNewDept()
        {
            using (var context = new EmployeeMgmt())
            {
                var dept = new Dept()
                {
                    Deptno = 10,
                    Dname = "HR"
                };
                context.Depts.Add(dept);
                context.SaveChanges();
            }
        }

        public void UpdateDept()
        {
            var context = new EmployeeMgmt();
            var seldept = context.Depts.FirstOrDefault(d => d.Depno == 10);
            seldept.Dname = "Database Admin";
            context.SaveChanges();


        }
        public void DeleteDept()
        {

            var context = new EmployeeMgmt();
            var seldept = context.Depts.FirstOrDefault(d => d.Depno == 10);
            context.Depts.Remove(seldept);
            context.SaveChanges();
        }
    }
}
