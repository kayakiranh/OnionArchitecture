using AutoMapper;
using MediatR;
using OAA.Application.Interfaces.EntityRepositories;
using OAA.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OAA.Application.Cqrs.Commands.SchoolCommands
{
    public class InsertSchoolCommand : IRequest<School>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Type { get; set; }
        public DateTime Created { get; set; }

        public class InsertSchoolCommandHandler : IRequestHandler<InsertSchoolCommand, School>
        {
            private readonly ISchoolRepository schoolRepository;
            private readonly IMapper mapper;

            public InsertSchoolCommandHandler(ISchoolRepository schoolRepository, IMapper mapper)
            {
                this.schoolRepository = schoolRepository;
                this.mapper = mapper;
            }

            public Task<School> Handle(InsertSchoolCommand request, CancellationToken cancellationToken)
            {
                School school = mapper.Map<School>(request);
                Task<School> insertedSchool = schoolRepository.Insert(school);
                return insertedSchool;
            }
        }
    }
}
