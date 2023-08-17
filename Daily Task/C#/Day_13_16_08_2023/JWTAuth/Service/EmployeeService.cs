using JWTAuth.Models;
using Microsoft.EntityFrameworkCore;

namespace JWTAuth.Service
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeMgmtContext _employeeMgmtContext;

        public EmployeeService(EmployeeMgmtContext employeeMgmtContext)
        {
            _employeeMgmtContext = employeeMgmtContext;
        }
        public async Task<List<Emp>> AddEmployee(Emp emp)
        {
            _employeeMgmtContext.Emps.Add(emp);
            await _employeeMgmtContext.SaveChangesAsync();
            return await _employeeMgmtContext.Emps.ToListAsync();

        }
        public async Task<List<Emp>> DeleteEmployee(int rollno)
        {
            var emp = await _employeeMgmtContext.Emps.ToListAsync();
            if (emp == null)
            {
                throw new Exception("Not found");
            }
            else
            {
                _employeeMgmtContext.Remove(emp);
                await _employeeMgmtContext.SaveChangesAsync();
                var emps = await _employeeMgmtContext.Emps.ToListAsync();
                return emps;
            }
        }
        public async Task<List<Emp>> GetAllEmployee()
        {
            var emp = await _employeeMgmtContext.Emps.ToListAsync();
            return emp;
        }
        public async Task<Emp> UpdateEmployee(int Empno, Emp emp)
        {
            var emps = await _employeeMgmtContext.Emps.FindAsync(Empno);
            if (emp == null)
            {
                throw new Exception("not found");
            }
            else
            {
                emps.Ename = emp.Ename;
                emps.Address = emp.Address;
                emps.Deptno = emp.Deptno;
                await _employeeMgmtContext.SaveChangesAsync();
                emp = await _employeeMgmtContext.Emps.FindAsync(Empno);
                return emp;
            }
        }

    }
}
