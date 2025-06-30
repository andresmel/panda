using Laboratorio.Domain;
using Microsoft.Extensions.Logging;

namespace Laboratorio.Infrastructure.Persistence
{
    public class StreamerDbContextSeed
    {
        public static async Task SeedAsync(StreamerDbContext context, ILogger<StreamerDbContextSeed> logger)
        {
            if (!context.Streamers!.Any())
            {
                context.Streamers!.AddRange(GetPreconfiguredStreamer());
                await context.SaveChangesAsync();
                logger.LogInformation("Estamos insertando nuevos records al db {context}", typeof(StreamerDbContext).Name);
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
