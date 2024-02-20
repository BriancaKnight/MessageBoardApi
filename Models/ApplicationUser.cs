using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace MessageBoardApi.Models
{
  public class ApplicationUser : IdentityUser
  {
    public List<Message> Messages { get; set; }
  }
}