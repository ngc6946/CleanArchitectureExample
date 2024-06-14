using MediatR;
using System.Collections.Generic;

namespace Employee.Application.Queries
{
    public class GetAllEmployeeQuery : IRequest<List<Employee.Core.Entities.Employee>>
    {

    }
}
