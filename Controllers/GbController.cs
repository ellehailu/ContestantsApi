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
    }

}
