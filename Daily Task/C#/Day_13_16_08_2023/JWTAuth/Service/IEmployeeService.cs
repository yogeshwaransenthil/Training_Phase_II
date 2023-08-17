using JWTAuth.Models;

namespace JWTAuth.Service
{
    public interface IEmployeeService
    {
        public Task<List<Emp>> GetAllEmployee();
       // public Task<Emp> GetStudentById(int id);
        public Task<List<Emp>> AddEmployee(Emp emp);
        public Task<Emp> UpdateEmployee(int id, Emp emp);
        public Task<List<Emp>> DeleteEmployee(int id);
    }
}
