using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
   public class Client
    {
        RemoteFacade service;
        public Client(string serverName, int port)
        {
            service = new RemoteFacade(serverName, port);

            DoUserDialog();

            service.Close();
            
        }
        public void DoUserDialog()
        {
            Console.WriteLine("Type Q to Quit");

            bool active = true;
            do
            {
                string userKomando;
                Console.WriteLine("Enter command");
                userKomando = Console.ReadLine();  // første brugerinput
                userKomando = userKomando.Trim().ToUpper();
                switch (userKomando)
                {
                    case "DIRECTORYCATALOG":
                        {
                            Console.WriteLine("Enter directory");
                            string msg = Console.ReadLine();
                            string response = service.GetAllDirectories(msg);
                            Console.WriteLine("response:" + response);
                            break;
                        }
                    case "SUBDIRECTORYCATALOG":
                        {
                            Console.WriteLine("Enter subdirectory");
                            string msg = Console.ReadLine();
                            string response = service.GetAllSubDirectories(msg);
                            Console.WriteLine("response:" + response);
                            break;
                        }
                    case "Q":
                        {
                            active = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid command");
                            break;
                        }
                }
            }
            while (active);
        }
    }
}
