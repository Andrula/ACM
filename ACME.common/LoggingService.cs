using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.common
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> itemsLogged)
        {
            foreach (var item in itemsLogged)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
