using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>() {
              new Client(new CocaColaFactory()),
              new Client(new PepsiFactory()),
              new Client(new FantaFactory())
            };

            foreach (Client client in clients)
            {
                client.Run();
            }
        }
    }
}
