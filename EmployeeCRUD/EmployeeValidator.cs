using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace EmployeeCRUD
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator() 
        {
            RuleFor(e => e.Name).NotEmpty().WithMessage("Name is Requires")
                .MaximumLength(50).WithMessage("Name cannot exceed 50 Characters");

            RuleFor(e => e.Age).GreaterThan(0).WithMessage("Invalid Age")
                .LessThanOrEqualTo(120).WithMessage("Age must be real");

            RuleFor(e => e.RollNumber).GreaterThan(0).WithMessage("Roll Number must be positive");

            RuleFor(e => e.Mark).GreaterThanOrEqualTo(0).WithMessage("Mark cannot be negative")
                .LessThanOrEqualTo(100).WithMessage("Mark Cannot exceed 100");

            RuleFor(e => e.Salary).GreaterThanOrEqualTo(0).WithMessage("Invalid Entry type");
        }
    }
}
