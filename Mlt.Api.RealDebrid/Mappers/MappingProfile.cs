using AutoMapper;
using Mlt.Api.RealDebrid.Dtos;
using Mlt.Models.Torrent;

namespace Mlt.Api.RealDebrid.Mappers;

// ReSharper disable once UnusedType.Global
public class MappingProfile : Profile
{
    public MappingProfile()
        => CreateMap<TorrentsDto, Torrent>();
}