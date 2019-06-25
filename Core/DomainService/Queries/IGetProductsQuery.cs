using System.Collections.Generic;
using System.Threading.Tasks;
using max8ng.Core.Domain;

namespace max8ng.Core.Services.DomainService
{

    public interface IGetProductsQuery
    {
        Task<IEnumerable<Project>> GetAll();
        
    }

}
