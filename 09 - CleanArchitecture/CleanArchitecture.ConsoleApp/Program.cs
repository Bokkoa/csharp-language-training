using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

StreamerDbContext dbContext = new(null);

await MultipleEntitiesQuery();
//await AddNewDirectorWithVideo();
//await AddNewActorWithVideo();
//await AddNewStreamerWithVideoId();
//await TrackingAndNotTracking();
//await QueryLinq();
//await QueryMethods();
//await QueryFilter();
//await AddNewRecords();
//QueryStreaming();

Console.WriteLine("Press any key to continue");
Console.ReadKey();


async Task MultipleEntitiesQuery()
{
    //var videoWithActores = await dbContext.Videos!.Include(x => x.Actors).FirstOrDefaultAsync( q => q.Id == 1);
    //var actor = await dbContext.Actors!.Select(x => x.Name).ToListAsync();

    var videoWithDirector = await dbContext.Videos!
                                           .Where(v => v.Director != null)
                                           .Include(q => q.Director)
                                           .Select( q =>
                                                new {
                                                    FullName_Director = $"{q.Director.Name} {q.Director.Surname}",
                                                    Movie = q.Name
                                                }
                                            ).ToListAsync();

    foreach( var film in videoWithDirector)
    {
        Console.WriteLine($"{film.Movie} - {film.FullName_Director}");
    }
}
async Task AddNewDirectorWithVideo()
{
    var director = new Director
    {
        Name = "Quentin",
        Surname = "Tarantino",
        VideoId = 1
    };

    await dbContext.AddAsync(director);
    await dbContext.SaveChangesAsync();
}

async Task AddNewActorWithVideo()
{
    var actor = new Actor
    {
        Name = "Brad",
        Surname = "Pit"
    };
    // DB Commit for actor.Id generation
    await dbContext.AddAsync(actor);
    await dbContext.SaveChangesAsync();


    var videoActor = new ActorVideo()
    {
        ActorId = actor.Id,
        VideoId = 1
    };
    // DB Commit
    await dbContext.AddAsync(videoActor);
    await dbContext.SaveChangesAsync();
}

async Task AddNewStreamerWithVideoId()
{
    var batmanForever = new Video
    {
        Name = "Batman forever",
        StreamerId = 3
    };
    await dbContext.AddAsync(batmanForever);
    await dbContext.SaveChangesAsync();

    // add streamer and video
    //var pantaya = new Streamer
    //{
    //    Name = "Pantaya"
    //};

    //var hungerGames = new Video
    //{
    //    Name = "Hunger Games",
    //    Streamer = pantaya,
    //};
    //await dbContext.AddAsync(hungerGames);
    //await dbContext.SaveChangesAsync();
}

async Task TrackingAndNotTracking()
{
    var streamerWithTracking = await dbContext.Streamers!.FirstOrDefaultAsync(x => x.Id == 1);
    // AsNoTracking can't be used with findAsync
    var streamerWithNoTracking = await dbContext.Streamers!.AsNoTracking().FirstOrDefaultAsync(x => x.Id == 2);

    streamerWithTracking.Name = "Netflix plus";
    // asnotracked entity can't be modified because notracking free it from temporary memory
    streamerWithNoTracking.Name = "Amazon Premium Prime Plus"; 

    await dbContext!.SaveChangesAsync();
}

async Task QueryLinq()
{
    Console.WriteLine("Please enter the streaming service");
    var streamerName = Console.ReadLine();

    var streamers = await (from i in dbContext.Streamers
                            where EF.Functions.Like(i.Name, $"%{streamerName}%")
                            select i).ToListAsync(); // select means return all the representative value

    foreach( var streamer in streamers)
    {
        Console.WriteLine($"{streamer.Id} - {streamer.Name}");
    }
}
async Task QueryMethods()
{
    Console.WriteLine("HI");
    var streamer = dbContext!.Streamers!;
    var firstAsync = await streamer.Where(y => y.Name.Contains("a")).FirstAsync();
    var firstOrDefaultAsync = await streamer.Where(y => y.Name.Contains("a")).FirstOrDefaultAsync(); //returns a null if not exists
    var firstOrDefault_v2 = await streamer.FirstOrDefaultAsync(y => y.Name.Contains("a")); //returns a null if not exists

    var singleAsync = await streamer.Where(y => y.Id == 1).SingleAsync(); // dispatch an execption if fails
    var singleOrDefaultAsync = await streamer.Where(y => y.Id == 1).SingleOrDefaultAsync(); // returns a null if not exists

    var result = await streamer.FindAsync(1); // returns just one record
}

async Task QueryFilter()
{
    Console.WriteLine("Please enter a streaming company: ");
    var streamingName = Console.ReadLine();

    // searching the exact match with the entered text
    var streamers = await dbContext.Streamers!.Where(x => x.Name!.Equals(streamingName)).ToListAsync();
    foreach(var streamer in streamers)
    {
        Console.WriteLine($"{streamer.Id} - {streamer.Name}");
    }

    // searching if the entered text match with some string inside db streamers names
    //var streamerPartialResults = await dbContext.Streamers!.Where(x => x.Name!.Contains(streamingName)).ToListAsync();
    // using entity framework  instead lambda functions
    var streamerPartialResults = await dbContext.Streamers!.Where(x => EF.Functions.Like(x.Name, $"%{streamingName}%")).ToListAsync();
    foreach (var streamer in streamerPartialResults)
    {
        Console.WriteLine($"{streamer.Id} - {streamer.Name}");
    }

}

void QueryStreaming()
{
    var streamers = dbContext!.Streamers!.ToList();

    foreach(var streamer in streamers)
    {
        Console.WriteLine($"{streamer.Id} - {streamer.Name}");
    }
}

async Task AddNewRecords()
{
    Streamer streamer = new()
    {
        Name = "Disney plus",
        Url = "https://www.disney.com"
    };

    dbContext!.Streamers!.Add(streamer);

    await dbContext.SaveChangesAsync();

    var movies = new List<Video>
{
    new Video
    {
        Name = "Luca",
        StreamerId = streamer.Id,
    },
    new Video
    {
        Name = "Turning Red",
        StreamerId = streamer.Id,
    },
    new Video
    {
        Name = "The simpson movie",
        StreamerId = streamer.Id,
    },
    new Video
    {
        Name = "Star wars",
        StreamerId = streamer.Id,
    },
};

    await dbContext.AddRangeAsync(movies);
    await dbContext.SaveChangesAsync();
}