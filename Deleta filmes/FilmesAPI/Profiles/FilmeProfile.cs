using AutoMapper;
using FilmesApi.Models;
using FilmesAPI.Data.DTOs;

namespace FilmesAPI.Profiles;

public class FilmeProfile : Profile
{

    public FilmeProfile() {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>();
    }
}
