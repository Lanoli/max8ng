using AutoMapper;
using max8ng.Core.Domain;
using max8ng.Core.Services.DomainService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace max8ng.Infrastructure.Externalservice
{
    public class ProjectService : IGetProductsQuery
    {
        private HttpClient _client;
        private IMapper _mapper;

        public ProjectService(HttpClient client, IMapper mapper)
        {
            _mapper = mapper;
            _client = client;
        }

        public async Task<IEnumerable<Core.Domain.Project>> GetAll()
        {
            var response = await _client.GetAsync("http://www.max8.be/api/Project.asp");

            var deserialized = JsonConvert.DeserializeObject<ProjectsGetResponse>(await response.Content.ReadAsStringAsync());

            return _mapper.Map<List<Core.Domain.Project>>(deserialized.Projects);
        }
    
    }
}
