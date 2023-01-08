using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        protected readonly AppDataContext _dbContext;
        public BaseApiController(AppDataContext dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}