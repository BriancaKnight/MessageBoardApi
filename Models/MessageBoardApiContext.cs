using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MessageBoardApi.Models
{
  public class MessageBoardApiContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Message> Messages { get; set; }

    public DbSet<Group> Groups { get; set; }

    public MessageBoardApiContext(DbContextOptions<MessageBoardApiContext> options) : base(options)
    {
      
    }

 protected override void OnModelCreating(ModelBuilder builder)
  {
    var hasher = new PasswordHasher<IdentityUser>();


   base.OnModelCreating(builder);


   builder.Entity<ApplicationUser>()
    .HasData(
     new ApplicationUser { Id = "abc", UserName = "Jimothy", Email = "jimothy@proton.me", PasswordHash = hasher.HashPassword(null, "password")},
     new ApplicationUser { Id = "def", UserName = "Timmet", Email = "Timmet@tutanota.com", PasswordHash = hasher.HashPassword(null, "password")},
     new ApplicationUser { Id = "ghi", UserName = "Woxanda", Email = "Woxanda@soverin.net", PasswordHash = hasher.HashPassword(null, "password")}
     );


   builder.Entity<Group>()
    .HasData(
      new Group { GroupId = 1, Topic = "Hellos"},
      new Group { GroupId = 2, Topic = "Goodbyes"},
      new Group { GroupId = 3, Topic = "Nonsense"}
     );


    builder.Entity<Message>()
      .HasData(
        new Message {MessageId = 1, UserId = "abc", GroupId = 1,Text = "Hi I need more discount hogs!", Date = new DateTime(2024, 02, 20, 0, 0, 0)},
        new Message {MessageId = 2, UserId = "def", GroupId = 2, Text = "Goodbye, thank you for teaching me how to shave my cat ", Date = new DateTime(2023, 03, 30, 0, 0, 0)},
        new Message {MessageId = 3, UserId = "ghi", GroupId = 3, Text = "Kim Jong Un is so dreamy!!",   Date = new DateTime(1924, 01, 10, 0, 0, 0)}
      );


    }
  }
}
