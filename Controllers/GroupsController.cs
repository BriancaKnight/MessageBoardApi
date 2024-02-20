using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoardApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace MessageBoardApi.Controllers
{
[Route("api/[controller]")]
[ApiController]
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
public async Task<ActionResult<Group>> GetGroup(int groupId)
{
  Group group = await _db.Groups.FindAsync(groupId);

  if (group == null)
  {
    return NotFound();
  }
  return group;
}
}

}