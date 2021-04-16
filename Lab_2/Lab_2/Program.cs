using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            Console.WriteLine(facade.OperationAB());
            Console.WriteLine(facade.OperationBC());

        }
    }
}
