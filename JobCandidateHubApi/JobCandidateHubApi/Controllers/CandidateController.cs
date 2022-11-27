
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;
using System.Threading.Tasks;
using JobCandidateHubApi.Interfaces;
using JobCandidateHubApi.Models;
using JobCandidateHubApi.Dtos.Candidate;

namespace JobCandidateHubApi.Controllers
{
    [Route("api/candidate")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateRepo _candidateRepo;
        private readonly IMapper _mapper;

        public CandidateController(ICandidateRepo candidateRepo, IMapper mapper)
        {
            _candidateRepo = candidateRepo;
            _mapper = mapper;
        }

        [HttpGet("{id}", Name = "GetCandidateById")]
        public ActionResult<Candidate> GetCandidateById(int id)
        {
            var candidate = _candidateRepo.GetCandidateById(id);
            if (candidate != null)
            {
                return Ok(_mapper.Map<ReadDto>(candidate));
            }
            return NotFound();
        }

        //POST api/candidate
        [HttpPost]
        public ActionResult<ReadDto> CreateCandidate(CreateDto CreateDto)
        {

            var candidateModel = _mapper.Map<Candidate>(CreateDto);
            var candidate = _candidateRepo.GetCandidateByEmail(candidateModel.Email);
            if (candidate != null)
            {
                return Ok("Candidate with this email exist");
            }
            else
            {
                _candidateRepo.CreateCandidate(candidateModel);
                _candidateRepo.SaveChanges();
            }




            var ReadDto = _mapper.Map<ReadDto>(candidateModel);
            return CreatedAtRoute(nameof(GetCandidateById), new { ReadDto.Id }, ReadDto);
        }

        //PUT api/candidate{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCandidate(int id, UpdateDto UpdateDto)
        {
            var candidateModelFromRepo = _candidateRepo.GetCandidateById(id);
            if (candidateModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(UpdateDto, candidateModelFromRepo);
            _candidateRepo.UpdateCandidate(candidateModelFromRepo);
            _candidateRepo.SaveChanges();
            return Ok();
        }

    }
}


