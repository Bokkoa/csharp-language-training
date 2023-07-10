using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Domain;
using MediatR;
using Microsoft.Extensions.Logging;


namespace CleanArchitecture.Application.Features.Streamers.Commands.DeleteStreamer
{
    public class DeleteStreamerCommandHandler : IRequestHandler<DeleteStreamerCommand, Unit>
    {
        private readonly IStreamerRepository _streamerRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<DeleteStreamerCommandHandler> _logger;

        public DeleteStreamerCommandHandler(IStreamerRepository streamerRepository, IMapper mapper, ILogger<DeleteStreamerCommandHandler> logger)
        {
            _streamerRepository = streamerRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Unit> Handle(DeleteStreamerCommand request, CancellationToken cancellationToken)
        {
            var streamerToDelete = await _streamerRepository.GetByIdAsync(request.Id);
            if (streamerToDelete == null) {
                _logger.LogError($"The streamer with id {request.Id} doesn't exists ");
                throw new NotFoundException(nameof(Streamer), request.Id);
            }

            var deleted = await _streamerRepository.DeleteAsync(streamerToDelete);
            _logger.LogInformation($"The streamer with id {request.Id} was successfully deleted");
            return Unit.Value;
        }
    }
}
