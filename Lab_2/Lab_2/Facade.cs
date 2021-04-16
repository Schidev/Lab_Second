using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Facade
    {
        SubSystemA subSystemA = new SubSystemA();
        SubSystemB subSystemB = new SubSystemB();
        SubSystemC subSystemC = new SubSystemC();

        public string OperationAB()
        {
            return subSystemA.OperationA() + "\n" + subSystemB.OperationB();
        }

        public string OperationBC()
        {
            return subSystemB.OperationB() + "\n" + subSystemC.OperationC();
        }
    }
}
