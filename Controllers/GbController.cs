using ContestantsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace ContestantsApi.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class GbController : ControllerBase{
        private readonly ContestantsApiContext _db;

        public GbController(ContestantsApiContext db){
            _db = db;
        }

        //GET api/gbContestants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GbContestant>>> Get(){
            return await _db.GbContestants.ToListAsync();
        }

        //GET api/gbContestants/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<GbContestant>> GetGbContestant (int id){
            GbContestant gbContestant = await _db.GbContestants.FindAsync(id);

            if (gbContestant == null){
                return NotFound();
            }

            return gbContestant;
        }

        // POST api/gbContestant
        [HttpPost]
        public async Task<ActionResult<GbContestant>> Post([FromBody] GbContestant gbContestant) {
            _db.GbContestants.Add(gbContestant);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetGbContestant", new { id = gbContestant.GbContestantId }, gbContestant);
        }

        // PUT api/gbContestant
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, GbContestant gbContestant){
            if (id != gbContestant.GbContestantId){
                return BadRequest();
            }

            _db.Entry(gbContestant).State = EntityState.Modified;

            try{
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException){
                if(!GbContestantExists(id)){
                    return NotFound();
                }
                else{
                    throw;
                }
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGbContestant(int id){
            GbContestant gbContestant = await _db.GbContestants.FindAsync(id);
            if(gbContestant == null){
                return NotFound();
            }

            _db.GbContestants.Remove(gbContestant);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        private bool GbContestantExists(int id){
            return _db.GbContestants.Any(e => e.GbContestantId == id);
        }
    }

}
