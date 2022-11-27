using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobCandidateHubApi.Dtos.Candidate
{
    public class CreateDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime Date { get; set; }
        [DataType(DataType.Url)]
        public string LinkedInProfileUrl { get; set; }
        [DataType(DataType.Url)]
        public string GitHubProfileUrl { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Comment { get; set; }
    }
}
