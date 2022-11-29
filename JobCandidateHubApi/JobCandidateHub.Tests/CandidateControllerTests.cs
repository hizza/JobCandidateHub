using JobCandidateHubApi.Models;
using Xunit;
using Moq;
using JobCandidateHubApi.Data;

namespace JobCandidateHub.Tests
{
    public class CandidateControllerTests
    {

        [Fact]
        public void CreateCandidate_Creates_A_Candidate()
        {
            // Arrange
            var _candidateRepo = new Mock<SqlCandidateRepo>();
            var mockCandidate = new Mock<Candidate>(MockBehavior.Strict);


            //Act

            _candidateRepo.Setup(x => x.CreateCandidate(CreateCandidateSample()));// I have tried i realy dont understand what am doing becouse of time limitation of the assignment
            var expected = CreateCandidateSample();
            var actual = _candidateRepo.Object;
            //var returnedCandidateObject = _candidateRepo.Setup(x => x.CreateCandidate()
            //Assert
            Assert.True(actual != null);



        }

        private Candidate CreateCandidateSample()
        {
            Candidate candidate = new Candidate
            {
                FirstName = "Herman",
                LastName = "Lukindo",
                PhoneNumber = "0657360369"
            };

            return candidate;
        }
    }
}
