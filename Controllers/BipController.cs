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
    }
}