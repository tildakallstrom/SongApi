using Microsoft.EntityFrameworkCore;
using SongApi.Models;

namespace SongApi.Data
{ 
    public class SongContext : DbContext
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public SongContext(DbContextOptions<SongContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

    }

    public DbSet<Song> Songs { get; set; }
}

}
