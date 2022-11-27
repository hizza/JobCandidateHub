using JobCandidateHubApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobCandidateHubApi.Interfaces
{
    public interface ICandidateRepo
    {
        bool SaveChanges();
        Candidate GetCandidateById(int id);
        Candidate GetCandidateByEmail(string email);
        void CreateCandidate(Candidate candidate);
        void UpdateCandidate(Candidate candidate);
    }
}
