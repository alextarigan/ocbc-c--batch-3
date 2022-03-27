using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        [Route("TestRun")]
        [HttpGet]

        public ActionResult TestRrun()
        {
            return Ok("Berhasil Memulai Test API");
        }
    }
}