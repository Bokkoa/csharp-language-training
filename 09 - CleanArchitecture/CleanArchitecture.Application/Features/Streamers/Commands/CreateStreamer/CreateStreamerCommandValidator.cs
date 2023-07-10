using FluentValidation;

namespace CleanArchitecture.Application.Features.Streamers.Commands.CreateStreamer
{
    public class CreateStreamerCommandValidator : AbstractValidator<CreaterStreamerCommand>
    {
        public CreateStreamerCommandValidator()
        {
            RuleFor(p => p.Name)
                    .NotEmpty().WithMessage("{Name} cant bet empty")
                    .NotNull()
                    .MaximumLength(50).WithMessage("{Name} cant be larger than 50 chars");
            RuleFor(p => p.Url)
                .NotEmpty().WithMessage("The {url} can be blank");
        }
    }
}
