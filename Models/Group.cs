namespace MessageBoardApi.Models
{
  public class Group
  {
    public int GroupId { get; set; }
    public string Topic { get; set; }

    // [JsonIgnore]
    public List<Message> Messages { get; set; } // One to Many
  }
}