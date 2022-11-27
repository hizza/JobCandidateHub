using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobCandidateHubApi.Interfaces;
using JobCandidateHubApi.Models;

namespace JobCandidateHubApi.Data
{
    public class SqlCandidateRepo : ICandidateRepo
    {
        private readonly JobCandidateHubContext _jobCandidateHubContext;

        public SqlCandidateRepo(JobCandidateHubContext jobCandidateHubContext)
        {
            _jobCandidateHubContext = jobCandidateHubContext;
        }
        public void CreateCandidate(Candidate candidate)
        {
            if (candidate == null)
            {
                throw new ArgumentNullException(nameof(candidate));
            }
            _jobCandidateHubContext.Candidates.Add(candidate);

        }

        public Candidate GetCandidateByEmail(string email)
        {
            return _jobCandidateHubContext.Candidates.FirstOrDefault(p => p.Email == email);
        }

        public Candidate GetCandidateById(int id)
        {
            return _jobCandidateHubContext.Candidates.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_jobCandidateHubContext.SaveChanges() >= 0);
        }

        public void UpdateCandidate(Candidate candidate)
        {
            //Nothing
        }
    }
}
