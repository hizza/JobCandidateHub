# JobCandidateHubApi
For the sake of below requirements i decided to change some few things
# Requirement 1. It is suppose to store information of dozen of thousands of candidates in the system
    This will be heavy for a csv file to handle large amount of data. And in order to update a record we are going to pull all the records and update a single record this is expensive in terms of speed so i saw a need to use Sql server database with Entity framework.

# Requirement 2. It should not be needed to install any extension to run the project
    I order to simplify the activity i had to use the following, you must install
# For JobCandidateHubApi Nuget packages to install
    AutoMapper.Extensions.Microsoft.DependencyInjection" Version="7.0.0"
    Microsoft.AspNetCore.JsonPatch"  Version="3.1.5"
    Microsoft.AspNetCore.Mvc.NewtonsoftJson" Version="3.1.5"
    Microsoft.EntityFrameworkCore" Version="3.1.5"
    Microsoft.EntityFrameworkCore.Design" Version="3.1.5"
    Microsoft.EntityFrameworkCore.SqlServer" Version="3.1.5"
    Microsoft.EntityFrameworkCore.Tools" Version="3.1.3"

# For JobCandidateHub.Tests Nuget packages to install
    Moq (4.18.2)
    xunit (2.4.0)
    xunit.extensibility.core (2.4.0)


# Database Migragration commands
    dotnet ef migrations add InitialMigrationCandidate
    dotnet ef database update

# Sql server
Change appsettings.json file (Server, User ID and Password) according to you sql server settings
  "ConnectionStrings": {
    "JobCandidateHubConnection": "Server=DESKTOP-914FJHV;Initial Catalog=JobCandidateHubDB;User ID=sa;Password=herman2824"
  }



