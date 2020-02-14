using System;
using SIS.MvcFramework;

namespace Panda.Web
{
    public class Program
    {
        static void Main(string[] args)
        {
            WebHost.Start(new Startup());
        }
    }
}
