using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoardApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace MessageBoardApi.Controllers
{
[Route("api/[controller]")]
[ApiController]
public class MessagesController : ControllerBase
{
  private readonly MessageBoardApiContext _db;

  public MessagesController(MessageBoardApiContext db)
  {
    _db = db;
  }

  
[HttpGet]
public async Task<ActionResult<IEnumerable<Message>>> Get()
{
  return await _db.Messages.ToListAsync();
}

[HttpGet("{id}")]
public async Task<ActionResult<Message>> GetMessage(int messageId)
{
  Message message = await _db.Messages.FindAsync(messageId);

  if (message == null)
  {
    return NotFound();
  }
  return message;
}

}
}
