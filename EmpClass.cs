using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsEx
{
    class EmpClass
    {
        public int empno;
        public string empname;
        public double sal;

        public void getDetails(int no,string name,double salary)
        {
            empno = no;
            empname = name;
            sal = salary;
        }
        public void disply()
        {
        Console.WriteLine("Employee ID number:"+empno +"\nEmployee name:"+empname +"\nsalary:"+sal);
        }
    }
}
