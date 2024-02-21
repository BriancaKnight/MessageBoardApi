using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoardApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace MessageBoardApi.Controllers
{
[Route("api/[controller]")]
[ApiController]
[Authorize]
public class MessagesController : ControllerBase
{
  private readonly MessageBoardApiContext _db;

  public MessagesController(MessageBoardApiContext db)
  {
    _db = db;
  }

[HttpGet]
public async Task<ActionResult<IEnumerable<Message>>> Get(int groupId)
{
  IQueryable<Message> query = _db.Messages.AsQueryable();
  if (groupId != 0)
  {
    query = query.Where(entry => entry.GroupId == groupId);
  }
  return await query.ToListAsync();
}

[HttpGet("{id}")]
public async Task<ActionResult<Message>> GetMessage(int id)
{
  Message message = await _db.Messages.FindAsync(id);

  if (message == null)
  {
    return NotFound();
  }
  return message;
}

[HttpPost]
public async Task<ActionResult<Message>> Post(Message message)
{
  _db.Messages.Add(message);
  await _db.SaveChangesAsync();
  return CreatedAtAction(nameof(GetMessage), new { id = message.MessageId }, message);
}


[HttpPut("{id}")]
public async Task<IActionResult> Put(int id, Message message)
{
  if (id != message.MessageId)
  { 
    return BadRequest();
  }

  _db.Messages.Update(message);

  try
  {
    await _db.SaveChangesAsync();
  }
  catch(DbUpdateConcurrencyException)
  {
    if (!MessageExists(id))
    {
      return NotFound();
    }
    else
    {
      throw;
    }
  }
  return NoContent();

  
}
private bool MessageExists(int id)
{
  return _db.Messages.Any(e => e.MessageId == id);
}

[HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMessage(int id)
    {
      Message message = await _db.Messages.FindAsync(id);
      if (message == null)
      {
        return NotFound();
      }

      _db.Messages.Remove(message);
      await _db.SaveChangesAsync();

      return NoContent();
    }

}
}
