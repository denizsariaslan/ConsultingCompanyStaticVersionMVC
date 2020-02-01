
using ConsultingCompany.Lib;
using System.Collections.Generic;

namespace ConsultingCompany.DataStore
{
    public static class ClientList
    {
        static List<Client> clientList = null;
        static ClientList()
        {
            clientList = new List<Client>(){
                                            new Client()
                                                {
                                                Id = 0,
                                                    CompanyName = "Microsoft",
                                                    ContactFirstName = "Bill",
                                                    ContactLastName = "Gates",
                                            
                                                },
                                            new Client()
                                                {
                                                Id = 1,
                                                    CompanyName = "Facebook",
                                                    ContactFirstName = "Mark",
                                                    ContactLastName = "Zuckerberg"
                                                },
                                            new Client()
                                                {
                                                Id = 2,
                                                    CompanyName = "Amazon",
                                                    ContactFirstName = "Jeff",
                                                    ContactLastName = "Bezos"
                                                },
            };
        }

     

        public static List<Client> SelectClientList()
        {
            return clientList;
        }

      

        public static void InsertClient(Client client)
        {
            int contClient = clientList.Count;
            client.Id = contClient + 1;
            clientList.Add(client);
        }
        public static void UpdateClient(Client client)
        {
            Client clientUpdate = clientList.Find(x => x.Id == client.Id);
            clientUpdate.CompanyName = client.CompanyName;
            clientUpdate.ContactFirstName = client.ContactFirstName;
            clientUpdate.ContactLastName = client.ContactLastName;
            clientUpdate.City = client.City;
            clientUpdate.State = client.State;
            clientUpdate.Zip = client.Zip;

        }
        public static void DeleteClient(int id)
        {
            Client clientDelete = clientList.Find(x => x.Id == id);
            clientList.Remove(clientDelete);
        }




    }
}