using AutoMapper;
using Laboratorio.Application.Contracts.Persistence;
using Laboratorio.Domain;
using MediatR;

namespace Laboratorio.Application.Features.Director.Commands.CreateDirector
{
    public class CreateDirectorCommandHandler : IRequestHandler<CreateDirectorCommand, int>
    {
        //private readonly IStreamerRepository _streamerRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateDirectorCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            //_streamerRepository = streamerRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateDirectorCommand request, CancellationToken cancellationToken)
        {
            var directorEntity = _mapper.Map<Directo>(request);
            //var newStreamer = await _streamerRepository.AddAsync(streamerEntity);

            _unitOfWork.DirectorRepository.AddEntity(directorEntity);

            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception($"No se pudo insertar el record de streamer");
            }



            return directorEntity.Id;
        }

    }
}
