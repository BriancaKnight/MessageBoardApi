using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace MessageBoardApi.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string FirstName { get; set; }
    public List<Message> Messages { get; set; }
  }
}