using AutoMapper;
using Laboratorio.Application.Features.Categorias.Commands.CreateCategoria;
using Laboratorio.Application.Features.Director.Commands.CreateDirector;
using Laboratorio.Application.Features.Streamers.Commands.CreateStreamer;
using Laboratorio.Application.Features.Videos.Commands.CreateVideo;
using Laboratorio.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<Video, VideosVm>();
            CreateMap<CreateStreamerCommand, Streamer>();

            CreateMap<CreateCategoriaCommand, Categoria>();

            CreateMap<CreateVideoCommand, Video>();

            CreateMap<CreateDirectorCommand, Director>();
                
        }
    }
}
