using DecoratorPattern.ConcreteComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.ClientClass;
using DecoratorPattern.ConcreteDecorator;

namespace DecoratorPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();

            var expresso = new Expresso();

            //Only Expresso
            client.ClientCode(expresso);
            Console.WriteLine();
            //Expresso with caramel
            var test = new Caramel(expresso);

            //Expresso with caramel and chocolate
            var test2 = new Chocolate(new Caramel(expresso));

            client.ClientCode(test);
            Console.WriteLine();

            client.ClientCode(test2);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

