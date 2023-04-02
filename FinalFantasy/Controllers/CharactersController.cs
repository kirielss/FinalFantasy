using FinalFantasy.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FinalFantasy.Models;

namespace FinalFantasy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly FinalFantasyDbContext _dbContext;

        public CharactersController(FinalFantasyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var characters = _dbContext.Characters.ToList();
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var character = _dbContext.Characters.SingleOrDefault(c => c.Id == id);
            if (character == null)
            {
                return NotFound();
            }
            return Ok(character);
        }

        [HttpPost]
        public IActionResult Create(Character character)
        {
            _dbContext.Characters.Add(character);
            _dbContext.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = character.Id }, character);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Character character)
        {
            var existingCharacter = _dbContext.Characters.SingleOrDefault(c => c.Id == id);
            if (existingCharacter == null)
            {
                return NotFound();
            }
            existingCharacter.Name = character.Name;
            existingCharacter.GameId = character.GameId;
            _dbContext.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var character = _dbContext.Characters.SingleOrDefault(c => c.Id ==id);
            if (character == null)
            {
                return NotFound();
            }
            _dbContext.Characters.Remove(character);
            _dbContext.SaveChanges();
            return NoContent();
        }
    }
}
