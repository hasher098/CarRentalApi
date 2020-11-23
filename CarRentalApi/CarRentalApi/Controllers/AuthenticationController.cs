using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalApi.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using CarRentalApi.Controllers;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System.Security.Claims;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Data;
using Microsoft.AspNetCore.Authorization;
using SendGrid.Helpers.Mail;
using SendGrid;
using Microsoft.AspNetCore.WebUtilities;

namespace CarRentalApi.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IConfiguration _configuration;
        private readonly RoleManager<IdentityRole> roleManager;
 

        public AuthenticationController(UserManager<ApplicationUser> userManager, IConfiguration configuration, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            _configuration = configuration;
            this.roleManager = roleManager;
           

        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var userExist = await userManager.FindByNameAsync(model.UserName);
            if (userExist != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Authentication.Response { Status = "Error", Message = "User need Name" });
            ApplicationUser user = new ApplicationUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.UserName
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Authentication.Response { Status = "Error", Message = "User need Password" });
            }
            else
            {
                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                if (await roleManager.RoleExistsAsync(UserRoles.Admin))
                {
                    await userManager.AddToRoleAsync(user, UserRoles.User);
                }
                string token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                var confirmationUrl = Url.Action("ConfirmEmail", "Authentication", new { userId = user.Id, token = token });
                var url = $"https://localhost:44397" + confirmationUrl;
                var mailClient = new SendGridClient("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");
                var msg = new SendGridMessage()
                {
                    From = new EmailAddress("carrental101czs@gmail.com", "CarRent"),
                    Subject = "Potwierdź swój adres e-mail",
                    HtmlContent = $"<h5>Kliknij poniżej, aby zatwierdzić swój e-mail</h5><br>" +
                    $"<a href=\"{url}\">Potwierdź maila</a>"
                };
                msg.AddTo(new EmailAddress(user.Email));
                await mailClient.SendEmailAsync(msg);
                return Ok(new Authentication.Response { Status = "Success", Message = "User Created Successfully, confirmation required before you can log in." });
            }
        }
        [HttpGet, Route("ConfirmEmail")]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Authentication.Response { Status = "Error", Message = "UserId or token is null" });
            }
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Authentication.Response { Status = "Error", Message = $"User ID {userId} is invalid" });
            }
            var result = await userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                return Ok(new Authentication.Response { Status = "Success", Message = "Email confirmed!" });
            }
            return StatusCode(StatusCodes.Status500InternalServerError, new Authentication.Response { Status = "Error", Message = $"Email cannot be confirmed" });
        }
        [HttpGet, Route("ForgetPasswordAsync")]
        [AllowAnonymous]
        public async Task<UserManagerResponse> ForgetPasswordAsync(string email)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
                return new UserManagerResponse
                {
                    IsSuccess = false,
                    Message = "No user associated with email",
                };

            var token = await userManager.GeneratePasswordResetTokenAsync(user);
            var mailClient = new SendGridClient("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");
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("carrental101czs@gmail.com", "CarRent"),
                Subject = "Reset hasla",
                PlainTextContent = $"Kliknij w poniższy link, żeby ustawić nowe hasło." +
                    $"\n {user.Id} \n {token}"
            };
            msg.AddTo(new EmailAddress(user.Email, "test"));
            await mailClient.SendEmailAsync(msg);
            return new UserManagerResponse
            {
                IsSuccess = true,
                Message = "Reset password URL has been sent to the email successfully!"
            };
        }
        [HttpGet, Route("ResetPasswordAsync")]
        [AllowAnonymous]
        public async Task<UserManagerResponse> ResetPasswordAsync(ResetPasswordModel model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return new UserManagerResponse
                {
                    IsSuccess = false,
                    Message = "No user associated with email",
                };

            if (model.NewPassword != model.ConfirmPassword)
                return new UserManagerResponse
                {
                    IsSuccess = false,
                    Message = "Password doesn't match its confirmation",
                };

            var decodedToken = WebEncoders.Base64UrlDecode(model.Token);
            string normalToken = Encoding.UTF8.GetString(decodedToken);

            var result = await userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);

            if (result.Succeeded)
                return new UserManagerResponse
                {
                    Message = "Password has been reset successfully!",
                    IsSuccess = true,
                };

            return new UserManagerResponse
            {
                Message = "Something went wrong",
                IsSuccess = false,
                Errors = result.Errors.Select(e => e.Description),
            };
        }
        [HttpPost("ForgetPassword")]
        public async Task<IActionResult> ForgetPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
                return NotFound();

            var result = await ForgetPasswordAsync(email);

            if (result.IsSuccess)
            {
                return Ok(result); // 200
            }

            return BadRequest(result); // 400
        }

     
        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromForm] ResetPasswordModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await ResetPasswordAsync(model);

                if (result.IsSuccess)
                    return Ok(result);

                return BadRequest(result);
            }

            return BadRequest("Some properties are not valid");
        }




        [HttpPost]
        [Route("RegisterAdmin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        {
            var userExist = await userManager.FindByNameAsync(model.UserName);
            if (userExist != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Authentication.Response { Status = "Error", Message = "User need Name" });
            ApplicationUser user = new ApplicationUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.UserName
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Authentication.Response { Status = "Error", Message = "User need Password" });
            }
            if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
            if (!await roleManager.RoleExistsAsync(UserRoles.User))
                await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
            if (await roleManager.RoleExistsAsync(UserRoles.Admin))
            {
                await userManager.AddToRoleAsync(user, UserRoles.Admin);
            }

            return Ok(new Authentication.Response { Status = "Success", Message = "User Created Successfully" });

        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            if(user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };
                foreach(var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }
                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetConnectionString("CarRentalDB")));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT: ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256));

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo,
                    User = user.UserName,
                    Id=user.Id,
                    Role = userRoles,
                });
            }
            return Unauthorized();
            
        }
        [HttpPost, Route("UserEdit")]
         public async Task<IActionResult> UserEdit([FromBody] EditModel model)
        {
            var user = await userManager.FindByIdAsync(model.id);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userManager.GetUserId(User)}'.");
            }

            if (user.LastName != model.lastName)
            {
                user.LastName = model.lastName;
            }
            if (user.FirstName != model.firstName)
            {
                user.FirstName = model.firstName;
            }
            if (user.Address != model.Adress)
            {
                user.Address = model.Adress;
            }
            if (user.Pesel != model.pesel)
            {
                user.Pesel = model.pesel;
            }
            if(user.IDcardNumber != model.IdcardNumber)
            {
                user.IDcardNumber = model.IdcardNumber;
            }
            if(user.IsActive == false)
            {
                user.IsActive = true;
            }

            await userManager.UpdateAsync(user);

            return NoContent();


        }
    }
}
