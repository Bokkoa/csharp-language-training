
using FluentValidation;

namespace CleanArchitecture.Application.Features.Directors.Commands.CreateDirector
{
    public class CreateCommandValidator : AbstractValidator<CreateDirectorCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.Name).NotNull().WithMessage("Name is required");

            RuleFor(p => p.Surname).NotNull().WithMessage("Surname is required");

        }
    }
}
