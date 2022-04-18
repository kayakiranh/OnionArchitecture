using AutoMapper;
using MediatR;
using OAA.Application.Interfaces.DomainRepositories;
using OAA.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OAA.Application.Cqrs.Commands.SchoolCommands
{
    public class InsertAsyncSchoolCommand : IRequest<School>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Type { get; set; }
        public DateTime Created { get; set; }

        public class InsertSchoolCommandHandler : IRequestHandler<InsertAsyncSchoolCommand, School>
        {
            private readonly ISchoolRepository schoolRepository;
            private readonly IMapper mapper;

            public InsertSchoolCommandHandler(ISchoolRepository schoolRepository, IMapper mapper)
            {
                this.schoolRepository = schoolRepository;
                this.mapper = mapper;
            }

            public Task<School> Handle(InsertAsyncSchoolCommand request, CancellationToken cancellationToken)
            {
                School school = mapper.Map<School>(request);
                Task<School> insertedSchool = schoolRepository.Insert(school);
                return insertedSchool;
            }
        }
    }
}
