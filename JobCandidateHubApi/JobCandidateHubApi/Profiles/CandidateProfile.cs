using AutoMapper;
using JobCandidateHubApi.Models;
using JobCandidateHubApi.Dtos.Candidate;

namespace JobCandidateHubApi.Profiles
{
    public class CandidateProfile : Profile
    {
        public CandidateProfile()
        {
            CreateMap<Candidate, ReadDto>();
            CreateMap<CreateDto, Candidate>();
            CreateMap<UpdateDto, Candidate>();
        }
    }
}
