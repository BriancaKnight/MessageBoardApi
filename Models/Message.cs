using System.ComponentModel.DataAnnotations;

namespace MessageBoardApi.Models
{
  public class Message
  {
    public int MessageId { get; set; }
    
    public string UserId { get; set; }
    public int GroupId { get; set; }
    [Required(ErrorMessage = "Text is required.")]
    public string Text { get; set; }
    public DateTime Date { get; set; }

    public ApplicationUser User { get; set; }
    public Group Group { get; set; }

  }
}