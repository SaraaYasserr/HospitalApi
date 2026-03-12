using HospitalAPI.Data;
using HospitalAPI.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminLoginController : ControllerBase
    {
        private readonly AppDbContext _db;
        public AdminLoginController(AppDbContext db)
        {
            _db = db;

        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] AdminLogin adminDto)
            {
            var admin = _db.Admins.FirstOrDefault(a => (a.Name == adminDto.UserName && a.password== adminDto.Password));
        
        if (admin == null)
        {
            return Unauthorized(new { message = "Invalid Username or Password" });
        }

            return Ok(admin);
        }
    }
}
