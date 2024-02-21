using System.ComponentModel.DataAnnotations;

namespace MessageBoardApi.Models
{
  public class Group
  {
    public int GroupId { get; set; }
    [Required(ErrorMessage = "Topic is required.")]
    [StringLength(20, ErrorMessage = "Topic length must be between 0 and 20 characters.")]
    public string Topic { get; set; }

    // [JsonIgnore]
    public List<Message> Messages { get; set; } // One to Many
  }
}
