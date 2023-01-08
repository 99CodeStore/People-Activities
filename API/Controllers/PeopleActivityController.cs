using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class PeopleActivityController : BaseApiController
    {
        public PeopleActivityController(AppDataContext dbContext):base(dbContext)
        {
            
        }

        [HttpGet]
        public async Task<ActionResult<List<PeopleActivity>>> GetActivities()
        {
           return await _dbContext.PeopleActivities.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<PeopleActivity>> GetActivitity(Guid Id)
        {
           return await _dbContext.PeopleActivities.FindAsync(Id);
        }
    }
}