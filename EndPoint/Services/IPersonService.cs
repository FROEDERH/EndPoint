using SimpleRestfulAPIWithAspNetCore.Models;
using System.Collections.Generic;

namespace SimpleRestfulAPIWithAspNetCore.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(string personId);
        List<person> FindAll();
        Person Update(Person person);
        void Delete(string personId);
    }
}