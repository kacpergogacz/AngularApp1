using AngularApp1.Server.Data;
using AngularApp1.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly ContactDbContext _context;
    private readonly IConfiguration _configuration;

    public UserController(ContactDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] Login model)
    {
        var user = await _context.ContactDetails.FirstOrDefaultAsync(u => u.Email == model.Email);

        if (user == null || user.Password != model.Password)
        {
            return Unauthorized(new { message = "Invalid email or password" });
        }

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_configuration["ApplicationSettings:JWT_Secret"]);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.ContactID.ToString()),
                new Claim(ClaimTypes.Email, user.Email)
            }),
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);
        var tokenString = tokenHandler.WriteToken(token);

        return Ok(new { Token = tokenString });
    }
}
