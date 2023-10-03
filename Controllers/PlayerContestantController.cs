using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContestantsApi.Models;

namespace ContestantsApi.Controllers{
    [Route("api/[controller]")]
    [ApiController]

    public class PlayerContestantController : ControllerBase{
        private readonly ContestantsApiContext _db;

        public PlayerContestantController(ContestantsApiContext db){
            _db = db;
        }

        // Get api/playerContestant
        // Add email and weekNumber endpoint
        [HttpGet]
        public async Task<List<PlayerContestant>> Get(string email, int weekNumber){
            IQueryable<PlayerContestant> query = _db.PlayersContestants.AsQueryable();

            if (email != null){
                query = query.Where(entry => entry.Email == email);
            }

            if (weekNumber ! == null){
                query = query.Where(entry => entry.WeekNumber == weekNumber);
            }
            return await _db.PlayersContestants.ToListAsync();
        }

        // Get api/playerContestant/id
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerContestant>> GetPlayerContestant(int id){
            PlayerContestant playerContestant = await _db.PlayersContestants.FindAsync(id);

            if (playerContestant == null){
                return NotFound();
            }

            return playerContestant;
        }


        // Create entries for playerContestant
        // POST api/playerContestant
        [HttpPost]
        public async Task<ActionResult<PlayerContestant>> Post([FromBody] PlayerContestant playerContestant){
            _db.PlayersContestants.Add(playerContestant);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetPlayerContestant", new { id = playerContestant.PlayerContestantID }, playerContestant);
        }

        // PUT api/playerContestant
        
        
    }
}