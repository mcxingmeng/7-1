using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    public class UEmployee:Employee 
    {
        public override void display()
        {
            salary = basesalary + workingyear * addsalary;
            salary = salary * (decimal)1.5;
            Console.WriteLine($"我今年的工资为{salary}");
        }
    }
}
