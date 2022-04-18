using AutoMapper;
using MediatR;
using OAA.Application.DTO.ViewModels;
using OAA.Application.Interfaces.DomainRepositories;
using OAA.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OAA.Application.Cqrs.Queries.SchoolQueries
{
    /// <summary>
    /// Get all school query
    /// </summary>
    public class GetAllAsyncSchoolQuery : IRequest<List<SchoolViewModel>>
    {
        public class GetAllSchoolQueryHandler : IRequestHandler<GetAllAsyncSchoolQuery, List<SchoolViewModel>>
        {
            private readonly ISchoolRepository schoolRepository;
            private readonly IMapper mapper;

            public GetAllSchoolQueryHandler(ISchoolRepository schoolRepository, IMapper mapper)
            {
                this.schoolRepository = schoolRepository;
                this.mapper = mapper;
            }

            public Task<List<SchoolViewModel>> Handle(GetAllAsyncSchoolQuery request, CancellationToken cancellationToken)
            {
                Task<List<School>> schoolList = schoolRepository.GetAll();
                Task<List<SchoolViewModel>> schoolViewModelList = mapper.Map<Task<List<SchoolViewModel>>>(schoolList);
                return schoolViewModelList;
            }
        }
    }
}