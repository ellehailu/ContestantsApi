using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContestantsApi.Models;

namespace ContestantsApi.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class BipController : ControllerBase{
        private readonly ContestantsApiContext _db;

        public BipController(ContestantsApiContext db){
            _db = db;
        }

        // GET api/bipContestant
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BipContestant>>> Get(){
            return await _db.BipContestants.ToListAsync();
        }

        // GET api/gbContestant
        [HttpGet("{id}")]
        public async Task<ActionResult<BipContestant>> GetBipContestant (int id){
            BipContestant bipContestant = await _db.BipContestants.FindAsync(id);
            if (bipContestant == null){
                return NotFound();
            }
            return bipContestant;
        }

        // POST api/bipContestant
        [HttpPost]
        public async Task<ActionResult<BipContestant>> Post([FromBody] BipContestant bipContestant){
            _db.BipContestants.Add(bipContestant);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetBipContestant", new { id = bipContestant.BipContestantId }, bipContestant);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, BipContestant bipContestant){
            if(id != bipContestant.BipContestantId){
                return BadRequest();
            }

            _db.Entry(bipContestant).State = EntityState.Modified;

            try {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException){
                if(!BipContestantExists(id)){
                    return NotFound();
                }
                else {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBipContestant (int id){
            BipContestant bipContestant = await _db.BipContestants.FindAsync(id);

            if(bipContestant == null){
                return NotFound();
            }

            _db.BipContestants.Remove(bipContestant);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool BipContestantExists(int id){
            return _db.BipContestants.Any(e => e.BipContestantId == id);
        }
    }
}