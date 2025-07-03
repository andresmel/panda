using AutoMapper;
using Laboratorio.Application.Contracts.Persistence;
using Laboratorio.Domain;
using MediatR;

namespace Laboratorio.Application.Features.Categorias.Commands.CreateCategoria
{
    public class CreateCategoriaCommandHandler : IRequestHandler<CreateCategoriaCommand, int>
    {
        //private readonly IStreamerRepository _streamerRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCategoriaCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            //_streamerRepository = streamerRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateCategoriaCommand request, CancellationToken cancellationToken)
        {
            // Mapear correctamente a Categoria
            var categoriaEntity = _mapper.Map<Categoria>(request);

            // Usar UnitOfWork de forma genérica
            _unitOfWork.CategoriaRepository.AddEntity(categoriaEntity);

            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception($"No se pudo insertar el record de categoria");
            }

            return categoriaEntity.Id;
        }

    }
}
