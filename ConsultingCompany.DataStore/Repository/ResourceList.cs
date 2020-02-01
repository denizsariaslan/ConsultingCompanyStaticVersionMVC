
using ConsultingCompany.Lib;
using System.Collections.Generic;

namespace ConsultingCompany.DataStore
{
    public static class ResourceList
    {
        static List<Resource> resourceList = null;
        static ResourceList()
        {
            resourceList = new List<Resource>(){
                                      new Resource() { Id=0, FirstName = "Chris", LastName = "Smith", YearsofExperience=3, Type = ResourceType.Developer },
                                      new Resource() { Id=1,  FirstName = "Brian", LastName = "Jones", YearsofExperience=2, Type = ResourceType.Developer },
                                      new Resource() { Id=2, FirstName = "Mary", LastName = "Bill", YearsofExperience=13, Type = ResourceType.Developer },
                                      new Resource() { Id=3, FirstName = "Lin", LastName = "Mayer", YearsofExperience=6, Type = ResourceType.Developer },
                                      new Resource() { Id=4, FirstName = "Jason", LastName = "Gold", YearsofExperience=7,  Type = ResourceType.ProjectManager },
                                      new Resource() { Id=5, FirstName = "Jennifer", LastName = "Mike", YearsofExperience=9,  Type = ResourceType.ProjectManager },
                                      new Resource() { Id=6, FirstName = "Bob", LastName = "Lawrence", YearsofExperience=6,  Type = ResourceType.Architect },
                                      new Resource() { Id=7, FirstName = "Susan", LastName = "Kennedy", YearsofExperience=4, Type = ResourceType.QA },
                                      new Resource() { Id=8, FirstName = "Jerry", LastName = "Williams", YearsofExperience=6, Type = ResourceType.Architect },
                                      new Resource() { Id=9, FirstName = "Eric", LastName = "Hammill", YearsofExperience=11, Type = ResourceType.QA }
            };
        }

     

        public static List<Resource> SelectResourceList()
        {
            return resourceList;
        }

        public static void InsertResource(Resource resource)
        {
            int countresourceList = resourceList.Count;
            resource.Id = countresourceList + 1;
            resourceList.Add(resource);
        }
        public static void UpdateResorce(Resource resource)
        {
            Resource resourceUpdate = resourceList.Find(x => x.Id == resource.Id);
            resourceUpdate.FirstName = resource.FirstName;
            resourceUpdate.LastName = resource.LastName;
            resourceUpdate.YearsofExperience = resource.YearsofExperience;
            resourceUpdate.Type = resource.Type;
          

        }
        public static void DeleteResource(int id)
        {
            Resource resourceDelete = resourceList.Find(x => x.Id == id);
            resourceList.Remove(resourceDelete);
        }




    }
}