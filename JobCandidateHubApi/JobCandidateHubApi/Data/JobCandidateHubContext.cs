using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobCandidateHubApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JobCandidateHubApi.Data
{
    public class JobCandidateHubContext : DbContext
    {
        public JobCandidateHubContext(DbContextOptions<JobCandidateHubContext> opt) : base(opt)
        {

        }
        public DbSet<Candidate> Candidates { get; set; }
    }
}
