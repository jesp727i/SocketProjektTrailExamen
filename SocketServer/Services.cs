using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer
{
    static class Services
    {
        public static string DirectoryCatalog(string msg)
        {
            return "From DirectoryCatalog";
        }
        public static string SubDirectoryCatalog(string msg)
        {
            return "From SubDirectoryCatalog";
        }
    }
}
