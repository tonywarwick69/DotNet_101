using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientOfSelfHosting;
using ClientOfSelfHosting.SelfHostingWCFService;
namespace ClientOfSelfHosting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorServiceClient client = new CalculatorServiceClient("BasicHttpBinding_ICalculatorService");
            int a = 5;
            int b = 7;
            int result = client.Addition(a, b);
            Console.WriteLine("Total of {0} + {1} = {2}", a, b, result);
            Console.Read();
        }
    }
}
