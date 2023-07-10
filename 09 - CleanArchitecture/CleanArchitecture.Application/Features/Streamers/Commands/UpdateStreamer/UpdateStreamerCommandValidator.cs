using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Streamers.Commands.UpdateStreamer
{
    public class UpdateStreamerCommandValidator : AbstractValidator<UpdateStreamerCommand>
    {
        public UpdateStreamerCommandValidator() {
            RuleFor(p => p.Name)
                    .NotNull().WithMessage("{Name} can't be null");
            RuleFor(p => p.Url)
                    .NotNull().WithMessage("{Url} can't be null");
        }
    }
}
