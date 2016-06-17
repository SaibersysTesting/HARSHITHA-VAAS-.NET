using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsEx
{
    class MainClass
    {
        public static void Main()
        {
            EmpClass EC = new EmpClass();
            EC.getDetails(100, "harshitha", 8000);
            EC.disply();

            EC.getDetails(200, "vaas", 9000);
            EC.disply();

            
        }
    }
}
