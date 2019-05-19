using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    public class Employee
    {
        public decimal basesalary;
        public int workingyear;
        public decimal addsalary;
        public decimal salary;
        public void setdata(decimal _basesalary,int _workingyear,decimal _addsalary)
        {
            this.addsalary = _addsalary;
            this.basesalary = _basesalary;
            this.workingyear = _workingyear;
        }
        public virtual void display()
        {
            salary = basesalary + workingyear * addsalary;
            Console.WriteLine($"今年我的工资为{salary}");
        }
    }
}
