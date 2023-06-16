using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCS.CQRSMediator.HandlerCommands.EmployeeCommands.Commands
{
    public class CreateEmployeeCommand : IRequest<EmployeeModel>
    {
        public string? Name { get; set; }

        public string? EmailId { get; set; }

        public string? Gender { get; set; }

        public string? MobileNumber { get; set; }

        public int? Salary { get; set; }

        public CreateEmployeeCommand(string? name, string? email, string? gender, string? mobileNo, int? salary)
        {
            Name = name;
            EmailId = email;
            Gender = gender;
            MobileNumber = mobileNo;
            Salary = salary;
        }
    }
}
