using AutoMapper;
using JobCandidateHubApi.Controllers;
using JobCandidateHubApi.Models;
using System;
using Xunit;
using JobCandidateHubApi.Dtos.Candidate;
using JobCandidateHubApi.Interfaces;

namespace JobCandidateHub.Tests
{
    public class CandidateControllerTests
    {
        private readonly ICandidateRepo _candidateRepo;
        private readonly IMapper _mapper;

        public CandidateControllerTests(ICandidateRepo candidateRepo, IMapper mapper)
        {
            _candidateRepo = candidateRepo;
            _mapper = mapper;
        }

        [Fact]
        public void CreateCandidate_Creates_A_Candidate()
        {
            // Arrange
            Candidate candidate = new Candidate()
                {
                    FirstName = "Frida",
                    LastName = "Akaro",
                    PhoneNumber = "0657360369",
                    Email = "frida1991gmail.com",
                    Date = DateTime.Now,
                    LinkedInProfileUrl = "LinkedInProfileUrl",
                    GitHubProfileUrl = "http://localhost:5000/GitHubProfileUrl",
                    Comment = "This is the first Api test",
                };
           
            var candidateController = new CandidateController(_candidateRepo, _mapper );
            //Act
            var CreateDto = _mapper.Map<CreateDto>(candidate);
            var actionResult = candidateController.CreateCandidate(CreateDto);

            //Assert
            var res = actionResult.Result as object;
            var ReadDto = _mapper.Map<ReadDto>(candidate);
            Assert.Equal(ReadDto, res);

        }
    }
}
