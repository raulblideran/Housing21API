using Housing21.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;

namespace Housing21.Controllers
{
    [Route("api/housing/users")]
    [ApiController]
    public class Housing21Controller : ControllerBase
    {
        private Housing21appContext _context;

        public Housing21Controller(Housing21appContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User usr)
        {
            _context.Users.Add(usr);
            await _context.SaveChangesAsync();
            return usr;
        }

    }
}
