using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoardApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace MessageBoardApi.Controllers
{
[Route("api/[controller]")]
[ApiController]
[Authorize]
public class GroupsController : ControllerBase
{
  private readonly MessageBoardApiContext _db;

  public GroupsController(MessageBoardApiContext db)
  {
    _db = db;
  }

[HttpGet]
public async Task<ActionResult<IEnumerable<Group>>> Get()
{
  return await _db.Groups.ToListAsync();
}

[HttpGet("{id}")]
public async Task<ActionResult<Group>> GetGroup(int id)
{
  Group group = await _db.Groups.FindAsync(id);

  if (group == null)
  {
    return NotFound();
  }
  return group;
}

[HttpPost]
public async Task<ActionResult<Group>> Post(Group group)
{
  _db.Groups.Add(group);
  await _db.SaveChangesAsync();
  return CreatedAtAction(nameof(GetGroup), new { id = group.GroupId }, group);
}


[HttpPut("{id}")]
public async Task<IActionResult> Put(int id, Group group)
{
  if (id != group.GroupId)
  { 
    return BadRequest();
  }

  _db.Groups.Update(group);

  try
  {
    await _db.SaveChangesAsync();
  }
  catch(DbUpdateConcurrencyException)
  {
    if (!GroupExists(id))
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
private bool GroupExists(int id)
{
  return _db.Groups.Any(e => e.GroupId == id);
}
  
[HttpDelete("{id}")]
    public async Task<IActionResult> DeleteGroup(int id)
    {
      Group group = await _db.Groups.FindAsync(id);
      if (group == null)
      {
        return NotFound();
      }

      _db.Groups.Remove(group);
      await _db.SaveChangesAsync();

      return NoContent();
    }
}
}