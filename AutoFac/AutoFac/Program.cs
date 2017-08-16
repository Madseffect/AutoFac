using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using System.Reflection;

namespace AutoFac
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<PrintService>().As<IPrintService>();

            var container = builder.Build();
            var printService = container.Resolve<IPrintService>();
            printService.PrintSomething("Hello World");
            Console.ReadKey();

            //assembly scanning
            var dataAccess = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(dataAccess)
       .Where(t => t.Name.EndsWith("Repository"))
       .AsImplementedInterfaces();


        }

    }
}
