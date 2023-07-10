using CleanArchitecture.Domain;
using Microsoft.Extensions.Logging;
using System.Xml.Linq;
using System;


namespace CleanArchitecture.Infrastructure.Persistence
{
    public class StreamerDbContextSeed
    {
        public static async Task SeedAsync(StreamerDbContext context, ILogger<StreamerDbContext> logger)
        {
            if (!context.Streamers!.Any())
            {
                context.Streamers!.AddRange(GetPreconfiguredStreamer());
                await context.SaveChangesAsync();
                logger.LogInformation("Inserting new rows to db {context}", typeof(StreamerDbContext).Name);
            }
        }

        private static IEnumerable<Streamer> GetPreconfiguredStreamer() {
            return new List<Streamer>
            {
                new Streamer
                {
                    CreatedBy = "Konejo",
                    Name = "Maxi BHP",
                    Url = "http://www.hbp/com"
                },
                new Streamer
                {
                    CreatedBy = "Konejo",
                    Name = "Armazon",
                    Url = "http://www.armazon/com"
                },

            };
        }
    }
}
