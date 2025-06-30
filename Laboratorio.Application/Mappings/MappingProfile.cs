using AutoMapper;
using Laboratorio.Application.Features.Streamers.Commands.CreateStreamer;
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
        }
    }
}
