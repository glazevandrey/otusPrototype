using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otusPrototype
{
    public class Employee : Person, IMyCloneable<Employee>
    {
        public string Salary { get; set; }
        public Employee(Employee emp) : base(emp) 
        {
            this.Salary = emp.Salary;
        }
        public Employee()
        {
            
        }
        Employee IMyCloneable<Employee>.Clone()
        {
            throw new NotImplementedException();
        }
    }
}
