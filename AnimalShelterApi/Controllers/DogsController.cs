using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DogsController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;

    public DogsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    // [HttpGet]
    // public async Task<ActionResult<PagedList<Dog>>> Get(int dogId, int pageNumber = 1, int pageSize = 10)
    // {
    
    //   var dogs = _db.Dogs.Where(m => m.DogId == dogId);

    //   var pagedDogs = await PagedList<Dog>.ToPagedListAsync(dogs, pageNumber, pageSize);

    //   if (pagedDogs.Count == 0)
    //   {
    //     return NotFound();
    //   }

    //   return pagedDogs;
    // }

    [HttpGet]
    public async Task<List<Dog>> Get(string name, string size, string sex, int minimumAge)
    {
      IQueryable<Dog> query = _db.Dogs.AsQueryable();

      if (name != null)
      {
        query = query.Where(e => e.Name == name);
      }

      if (size != null)
      {
        query = query.Where(e => e.Size == size);
      }

      if (sex != null)
      {
        query = query.Where(e => e.Sex == sex);
      }

      if (minimumAge > 0)
      {
        query = query.Where(e => e.Age >= minimumAge);
      }
      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Dog>> GetDog(int id)
    {
      Dog dog = await _db.Dogs.FindAsync(id);

      if (dog == null)
      {
        return NotFound();
      }

      return dog;
    }

    [HttpPost]
    public async Task<ActionResult<Dog>> Post(Dog dog)
    {
      _db.Dogs.Add(dog);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetDog), new { id = dog.DogId }, dog);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put (int id, Dog dog)
    {
      if (id != dog.DogId)
      {
        return BadRequest();
      }

      _db.Dogs.Update(dog);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!DogExists(id))
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

    private bool DogExists(int id)
    {
      return _db.Dogs.Any(e => e.DogId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDog(int id)
    {
      Dog dog = await _db.Dogs.FindAsync(id);
      if (dog == null)
      {
        return NotFound();
      }

      _db.Dogs.Remove(dog);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}