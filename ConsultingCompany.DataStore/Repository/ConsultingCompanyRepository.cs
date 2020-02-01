
namespace ConsultingCompany.DataStore
{
    using System.Collections.Generic;
    using System;
    using ConsultingCompany.Lib;

    public class ConsultingCompanyRepository : IConsultingCompanyRepository
    {

    
        public ConsultingCompanyRepository()
        {
            Initialize();
           
        }

        private List<Resource> _resources = null;

        private List<Client> _clients = null;

        public List<Resource> Resources
        {
            get
            {
                return this._resources;
            }
        }


        public List<Client> Clients
        {
            get
            {
                return this._clients;
            }
        }

        private void Initialize()
        {
            this._resources = new List<Resource>()
                                  {
                                      new Resource() { FirstName = "Chris", LastName = "Smith", Type = ResourceType.Developer },
                                      new Resource() { FirstName = "Brian", LastName = "Jones", Type = ResourceType.Developer },
                                      new Resource() { FirstName = "Mary", LastName = "Bill", Type = ResourceType.Developer },
                                      new Resource() { FirstName = "Lin", LastName = "Mayer", Type = ResourceType.Developer },
                                      new Resource() { FirstName = "Jason", LastName = "Gold", Type = ResourceType.ProjectManager },
                                      new Resource() { FirstName = "Jennifer", LastName = "Mike", Type = ResourceType.ProjectManager },
                                      new Resource() { FirstName = "Bob", LastName = "Lawrence", Type = ResourceType.Architect },
                                      new Resource() { FirstName = "Susan", LastName = "Kennedy", Type = ResourceType.QA },
                                      new Resource() { FirstName = "Jerry", LastName = "Williams", Type = ResourceType.Architect },
                                      new Resource() { FirstName = "Eric", LastName = "Hammill", Type = ResourceType.QA }
                                  };

            this._clients = new List<Client>()
                                {
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

        public List<Client> GetAllClients()
        {
            return ClientList.SelectClientList();
        }

        public void InsertClient(Client client)
        {
            ClientList.InsertClient(client);
        }

        public void UpdateClient(Client client)
        {
            ClientList.UpdateClient(client);
        }

        public void DeleteClient(int id)
        {
            ClientList.DeleteClient(id);
        }

        public List<Resource> GetAllResources()
        {
            return ResourceList.SelectResourceList();
        }

        public void InsertResource(Resource resource)
        {
            ResourceList.InsertResource(resource);
        }

        public void UpdateResource(Resource resource)
        {
            ResourceList.UpdateResorce(resource);
        }

        public void DeleteResource(int id)
        {
            ResourceList.DeleteResource(id);
        }
    }
}
