using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContestantsApi.Models;

namespace ContestantsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PlayerContestantController : ControllerBase
    {
        private readonly ContestantsApiContext _db;

        public PlayerContestantController(ContestantsApiContext db)
        {
            _db = db;
        }


        //GET api/JointTable
        [HttpGet]
        public async Task<IEnumerable<PlayerContestant>> get() {
            return await _db.PlayersContestants.ToListAsync();
        }
    }
}