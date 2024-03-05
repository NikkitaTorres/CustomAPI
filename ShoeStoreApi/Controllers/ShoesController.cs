using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoeStoreApi.Models;

namespace ShoeStoreApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShoesController : ControllerBase
  {
    private readonly ShoeStoreApiContext _db;

    public ShoesController(ShoeStoreApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Shoe>>> Get()
    {
      return await _db.Shoes.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Shoe>> GetShoe(int id)
    {
      Shoe shoe = await _db.Shoes.FindAsync(id);

      if (shoe == null)
      {
        return NotFound();
      }

      return shoe;
    }
  }
}