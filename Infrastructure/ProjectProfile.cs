using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace max8ng.Infrastructure
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile()
        {
            CreateMap<Infrastructure.Externalservice.Project, Core.Domain.Project>()
                .ForMember(x => x.Title, x => x.MapFrom(y => y.Name));
        }

    }
}
