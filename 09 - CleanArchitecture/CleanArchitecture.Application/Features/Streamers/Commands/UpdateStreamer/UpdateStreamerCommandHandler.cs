using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Domain;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Application.Features.Streamers.Commands.UpdateStreamer
{
    public class UpdateStreamerCommandHandler : IRequestHandler<UpdateStreamerCommand, Unit>
    {
        private readonly IStreamerRepository _streamerRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateStreamerCommandHandler> _logger;

        public UpdateStreamerCommandHandler(IStreamerRepository streamerRepository, IMapper mapper, ILogger<UpdateStreamerCommandHandler> logger)
        {
            _streamerRepository = streamerRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(UpdateStreamerCommand request, CancellationToken cancellationToken)
        {
            var streamerToUpdate = await _streamerRepository.GetByIdAsync(request.Id);

            if(streamerToUpdate == null)
            {
                _logger.LogError($"Stramer with id {request.Id} was not found.");
                throw new NotFoundException(nameof(Streamers), request.Id);
            }
            // data from request is setted in the stramerToUpdate object
            _mapper.Map(request, streamerToUpdate, typeof(UpdateStreamerCommand), typeof(Streamer));
            await _streamerRepository.UpdateAsync(streamerToUpdate);

            _logger.LogInformation($"The operation was succelful for {request.Id} streamer");

            return Unit.Value;
        }

    }
}
