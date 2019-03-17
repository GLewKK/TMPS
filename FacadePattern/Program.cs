using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class Facade
    {
        protected Subsystem1 _subsystem1;

        protected Subsystem2 _subsystem2;

        protected Subsystem3 _subsystem3;

        public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2, Subsystem3 subsystem3)
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;
            _subsystem3 = subsystem3;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:...\n";

            result += _subsystem1.Operation1();
            result += _subsystem2.Operation1();
            result += _subsystem3.Operation1();
            result += _subsystem1.OperationN();
            result += _subsystem2.OperationZ();
            result += _subsystem3.OperationW();
            return result;
        }
    }

    public class Subsystem1
    {
        public string Operation1()
        {
            return "Subsystem1: Ready!\n";
        }

        public string OperationN()
        {
            return "Subsystem1: Go!\n";
        }
    }

    public class Subsystem2
    {
        public string Operation1()
        {
            return "Subsystem2: Get ready!\n";
        }

        public string OperationZ()
        {
            return "Subsystem2: Fire!\n";
        }
    }
    public class Subsystem3
    {
        public string Operation1()
        {
            return "Subsystem3: Step Ahead!\n";
        }

        public string OperationW()
        {
            return "Subsystem3: Fire in he hole!\n";
        }
    }


    class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var subsystem1 = new Subsystem1();
            var subsystem2 = new Subsystem2();
            var subsystem3 = new Subsystem3();
            Facade facade = new Facade(subsystem1, subsystem2, subsystem3);
            Client.ClientCode(facade);
        }
    }
}
