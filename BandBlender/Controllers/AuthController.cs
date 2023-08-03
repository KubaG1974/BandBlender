using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using BandBlender.Models.DTOs;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Mvc;


namespace BandBlender.Controllers;

[Microsoft.AspNetCore.Components.Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    [HttpPost]
    public IActionResult Login(UserForAuthenticationDto userForAuth)
    {
        // here, you would usually authenticate the user credentials first
        // if they are valid, generate and return a JWT

        var secretKey = new SymmetricSecurityKey("YourSuperSecureKey"u8.ToArray());
        var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        var tokenOptions = new JwtSecurityToken(
            issuer: "http://localhost:5000",
            audience: "http://localhost:5000",
            claims: new List<Claim>(), // you could add some user-specific claims here
            expires: DateTime.Now.AddMinutes(30), // token expiration time
            signingCredentials: signinCredentials
        );

        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        return Ok(new { Token = tokenString });
    }
}
