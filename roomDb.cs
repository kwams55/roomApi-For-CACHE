using Microsoft.EntityFrameworkCore;

class RoomDb : DbContext
{
    public RoomDb(DbContextOptions<RoomDb> options)
        : base(options) { }

    public DbSet<Room> Todos => Set<Room>();
} 