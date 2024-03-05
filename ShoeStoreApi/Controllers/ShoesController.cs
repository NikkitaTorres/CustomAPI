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

    [HttpPost]
    public async Task<ActionResult<Shoe>> Post(Shoe shoe)
    {
      _db.Shoes.Add(shoe);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetShoe), new { id = shoe.ShoeId }, shoe);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Shoe shoe)
    {
      if (id != shoe.ShoeId)
      {
        return BadRequest();
      }

      _db.Animals.Update(animal);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ShoeExists(id))
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

    private bool ShoeExists(int id)
    {
      return _db.Shoes.Any(e => e.ShoeId == id);
    }
  }
}