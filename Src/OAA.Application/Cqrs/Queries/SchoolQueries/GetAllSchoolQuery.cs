using AutoMapper;
using MediatR;
using OAA.Application.DTO.ViewModels;
using OAA.Application.Interfaces.EntityRepositories;
using OAA.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OAA.Application.Cqrs.Queries.SchoolQueries
{
    /// <summary>
    /// Get all school query
    /// </summary>
    public class GetAllSchoolQuery : IRequest<List<SchoolViewModel>>
    {
        public class GetAllSchoolQueryHandler : IRequestHandler<GetAllSchoolQuery, List<SchoolViewModel>>
        {
            private readonly ISchoolRepository schoolRepository;
            private readonly IMapper mapper;

            public GetAllSchoolQueryHandler(ISchoolRepository schoolRepository, IMapper mapper)
            {
                this.schoolRepository = schoolRepository;
                this.mapper = mapper;
            }

            public Task<List<SchoolViewModel>> Handle(GetAllSchoolQuery request, CancellationToken cancellationToken)
            {
                Task<List<School>> schoolList = schoolRepository.GetAll();
                Task<List<SchoolViewModel>> schoolViewModelList = mapper.Map<Task<List<SchoolViewModel>>>(schoolList);
                return schoolViewModelList;
            }
        }
    }
}