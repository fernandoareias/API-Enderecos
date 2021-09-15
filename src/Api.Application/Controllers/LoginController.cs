

using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.DTOs;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [ApiController]
    [Route("v1/api/login")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [AllowAnonymous]
        [Route("")]
        public async Task<object> Login([FromServices] ILoginService service, [FromBody] LoginDTO user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (user == null)
                return BadRequest(user);

            try
            {
                var result = await service.FindByLogin(user);

                return result != null ? Ok(result) : NotFound();

            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}