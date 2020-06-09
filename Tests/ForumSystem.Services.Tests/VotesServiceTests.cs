namespace ForumSystem.Services.Tests
{
    using System.Threading.Tasks;

    using ForumSystem.Data;
    using ForumSystem.Data.Models;
    using ForumSystem.Data.Repositories;
    using ForumSystem.Services.Data;

    using Microsoft.EntityFrameworkCore;
    using Xunit;

    public class VotesServiceTests
    {
        [Fact]
        public async Task TwoDownVotesShouldCountAsMinusTwo()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                                .UseInMemoryDatabase("ForumSystem");

            var repository = new EfRepository<Vote>(new ApplicationDbContext(options.Options));

            var service = new VotesService(repository);
            await service.VoteAsync(1, "1", false);
            await service.VoteAsync(1, "2", false);
            var votes = service.GetVotes(1);
            Assert.Equal(-2, votes);
        }

        [Fact]
        public async Task TwoUpVotesShouldCountAsTwo()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                                .UseInMemoryDatabase("ForumSystem");

            var repository = new EfRepository<Vote>(new ApplicationDbContext(options.Options));

            var service = new VotesService(repository);
            await service.VoteAsync(1, "1", true);
            await service.VoteAsync(1, "2", true);
            var votes = service.GetVotes(1);
            Assert.Equal(2, votes);
        }
        [Fact]
        public async Task TwoDifferentVotesShouldCountAsZero()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                                .UseInMemoryDatabase("ForumSystem");

            var repository = new EfRepository<Vote>(new ApplicationDbContext(options.Options));

            var service = new VotesService(repository);
            await service.VoteAsync(1, "1", false);
            await service.VoteAsync(1, "2", true);
            var votes = service.GetVotes(1);
            Assert.Equal(0, votes);
        }

    }
}
