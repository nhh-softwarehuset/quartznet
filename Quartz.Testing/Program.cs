using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Quartz.Examples.Example13;

namespace Quartz.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            new ClusterExample().Run().Wait();
        }
    }
}
