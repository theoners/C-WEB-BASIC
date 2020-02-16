using System.Threading.Tasks;
using SIS.MvcFramework;

namespace Suls
{
    using System;

    public class Program
    {
        static async Task Main(string[] args)
        {
            await WebHost.StartAsync(new Startup());
        }
    }
}
