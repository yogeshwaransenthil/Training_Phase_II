using EFCF.Context;
using EFCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EFCF
{
    internal class CRUD
    {
        public void AddNewDept()
        {
 

            using (var context = new EmployeeDataBase())
            {
                var dept = new Dept()
                {
                    DeptNo = 2,
                    DeptName = "ECE"
                };

                context.Depts.Add(dept);
                context.SaveChanges();
            }
        } 
        
        public void UpdateDept()
        {
           

            var context = new EmployeeDataBase();

            var seldept = context.Depts.FirstOrDefault(d => d.DeptNo == 2);

            seldept.DeptName = "ECE";

            context.SaveChanges();
            
        } 
        
        public void DeleteDept()
        {

            var context = new EmployeeDataBase();

            var seldept = context.Depts.FirstOrDefault(d => d.DeptNo == 1);

            context.Depts.Remove(seldept);

            context.SaveChanges();
            
        }



    }
}
