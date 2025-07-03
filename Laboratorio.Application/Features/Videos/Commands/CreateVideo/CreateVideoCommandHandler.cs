using AutoMapper;
using Laboratorio.Application.Contracts.Persistence;
using Laboratorio.Domain;
using MediatR;

namespace Laboratorio.Application.Features.Videos.Commands.CreateVideo
{
    public class CreateVideoCommandHandler : IRequestHandler<CreateVideoCommand, int>
    {
        //private readonly IStreamerRepository _streamerRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateVideoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            //_streamerRepository = streamerRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateVideoCommand request, CancellationToken cancellationToken)
        {
            var videoEntity = _mapper.Map<Video>(request);
           

            _unitOfWork.VideoRepository.AddEntity(videoEntity);

            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception($"No se pudo insertar el record de streamer");
            }



            return videoEntity.Id;
        }

    }
}
