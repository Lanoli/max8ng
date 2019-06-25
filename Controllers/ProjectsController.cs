using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using max8ng.Core.Services.DomainService;
using Microsoft.AspNetCore.Mvc;
using max8ng.Api.Projects;
using AutoMapper;

namespace max8ng.Controllers
{
    [Route("api/[controller]")]
    public class ProjectsController : Controller
    {

        private IGetProductsQuery _getProductsQuery;
        private IMapper _mapper;
      
        public ProjectsController(IGetProductsQuery getProductsQuery, IMapper mapper)
        {
                _mapper = mapper;
                _getProductsQuery = getProductsQuery;
        }

        [HttpGet]
        public async Task<IEnumerable<Project>> GetAll()
        {
            return _mapper.Map<List<Project>>(await _getProductsQuery.GetAll());
        }

    }
}
