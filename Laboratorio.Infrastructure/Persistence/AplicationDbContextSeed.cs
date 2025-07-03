using Laboratorio.Domain;
using Microsoft.Extensions.Logging;

namespace Laboratorio.Infrastructure.Persistence
{
    public class AplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context, ILogger<AplicationDbContextSeed> logger)
        {
            if (!context.Streamers!.Any())
            {
                context.Streamers!.AddRange(GetPreconfiguredStreamer());
                await context.SaveChangesAsync();
                logger.LogInformation("Estamos insertando nuevos records al db {context}", typeof(ApplicationDbContext).Name);
            }

        }

        private static IEnumerable<Streamer> GetPreconfiguredStreamer()
        {
            return new List<Streamer>
            {
                new Streamer {CreatedDate = DateTime.Now, Nombre = "Netflix", Url = "http://www.netflix.com" },
                new Streamer {CreatedDate = DateTime.Now, Nombre = "Amazon VIP", Url = "http://www.amazonvip.com" },
            };

        }
    }
}
