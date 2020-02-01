using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultingCompany.Lib
{
    public interface IConsultingCompanyRepository
    {

      
        List<Resource> Resources { get; }

        List<Client> Clients { get;  }

        
    }
}
