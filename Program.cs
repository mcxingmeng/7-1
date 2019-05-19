using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal basesalary;
            int workingyear;
            Employee a = new Employee();
            Console.WriteLine("请输入普通工人今年的基本工资：");
            basesalary = decimal.Parse(Console.ReadLine ());
            Console.WriteLine("请输入普通工人的工龄：");
            workingyear = int.Parse(Console .ReadLine ());
            decimal addsalary;
            Console.WriteLine("请输入公司根据工龄一年加多少钱：");
            addsalary = decimal.Parse(Console .ReadLine ());
            a.setdata(basesalary ,workingyear ,addsalary );
            a.display();
            UEmployee b = new UEmployee();
            b.setdata(basesalary, workingyear, addsalary);
            b.display();
            Console.Read();
        }
    }
}
